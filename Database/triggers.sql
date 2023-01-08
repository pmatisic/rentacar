---Trigger 1---
CREATE OR REPLACE FUNCTION prevent_vehicle_rental_from_different_location()
    RETURNS TRIGGER AS
$$
BEGIN
    IF (OLD.idlokacijaostavljanja != NEW.idlokacijapreuzimanja) THEN
        RAISE EXCEPTION 'Vozilo se ne nalazi na istoj lokaciji na kojoj ga želite preuzeti.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER prevent_vehicle_rental_from_different_location
    BEFORE INSERT OR UPDATE
    ON najam
    FOR EACH ROW
EXECUTE PROCEDURE prevent_vehicle_rental_from_different_location();

---Trigger 2---
CREATE OR REPLACE FUNCTION update_vehicle_location_on_return()
    RETURNS TRIGGER AS
$$
BEGIN
    IF (NEW.idlokacijaostavljanja != OLD.idlokacijapreuzimanja) THEN
        UPDATE vozilo
        SET idlokacijavozila = NEW.idlokacijaostavljanja
        WHERE vozilo."IDvozilo" = NEW."idvozilo";
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER update_vehicle_location_on_return
    AFTER INSERT OR UPDATE
    ON najam
    FOR EACH ROW
EXECUTE PROCEDURE update_vehicle_location_on_return();

---Trigger 3---
CREATE OR REPLACE FUNCTION check_rental_validity()
    RETURNS TRIGGER AS
$$
BEGIN
    IF (NEW.vrijediod > NEW.vrijedido) THEN
        RAISE EXCEPTION 'Početak vremenskog raspona validnosti najma ne može biti poslije kraja raspona.';
    ELSIF (NEW.datumpocetkanajma < NEW.vrijediod OR NEW.datumpocetkanajma > NEW.vrijedido) THEN
        RAISE EXCEPTION 'Datum početka najma nije unutar vremenskog raspona validnosti najma.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER check_rental_validity
    BEFORE INSERT OR UPDATE
    ON najam
    FOR EACH ROW
EXECUTE PROCEDURE check_rental_validity();

---Trigger 4---
CREATE OR REPLACE FUNCTION prevent_double_rentals()
    RETURNS TRIGGER AS
$$
BEGIN
    -- Provjera je li najam nekog klijenta aktivan
    IF (NEW.datumzavrsetkanajma IS NULL AND
        (SELECT COUNT(*) FROM najam WHERE idklijent = NEW.idklijent AND najam.datumzavrsetkanajma IS NULL) > 0) THEN
        RAISE EXCEPTION 'Ovaj klijent već ima aktivni najam vozila.';
    -- Provjera je li klijent već iznajmio neko vozilo u rasponu od datuma početka najma do datuma završetka najma
    ELSIF (NEW.datumzavrsetkanajma IS NULL AND
           (SELECT COUNT(*)
            FROM najam
            WHERE idklijent = NEW.idklijent
              AND datumpocetkanajma <= NEW.datumpocetkanajma
              AND datumzavrsetkanajma >= NEW.datumpocetkanajma) > 0) THEN
        RAISE EXCEPTION 'Ovaj klijent već ima iznajmljeno vozilo u odabranom vremenskom rasponu.';
    -- Provjera je li najam nekog vozila aktivan
    ELSIF (NEW.datumzavrsetkanajma IS NULL AND
           (SELECT COUNT(*) FROM najam WHERE idvozilo = NEW.idvozilo AND najam.datumzavrsetkanajma IS NULL) > 0) THEN
        RAISE EXCEPTION 'Ovo vozilo je već iznajmljeno.';
    -- Provjera je li vozilo već iznajmljeno u rasponu od datuma početka najma do datuma završetka najma
    ELSIF (NEW.datumzavrsetkanajma IS NULL AND
           (SELECT COUNT(*)
            FROM najam
            WHERE idvozilo = NEW.idvozilo
              AND datumpocetkanajma <= NEW.datumpocetkanajma
              AND datumzavrsetkanajma >= NEW.datumpocetkanajma) > 0) THEN
        RAISE EXCEPTION 'Ovo vozilo je već iznajmljeno u odabranom vremenskom rasponu.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER prevent_double_rentals
    BEFORE INSERT OR UPDATE
    ON najam
    FOR EACH ROW
EXECUTE PROCEDURE prevent_double_rentals();

---Trigger 5---
CREATE OR REPLACE FUNCTION prevent_frequent_rentals()
    RETURNS TRIGGER AS
$$
BEGIN
    IF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*)
                                             FROM najam
                                             WHERE idklijent = NEW.idklijent
                                               AND najam.datumzavrsetkanajma IS NOT NULL
                                               AND datumzavrsetkanajma >= NEW.datumpocetkanajma - INTERVAL '7 days') >
                                            0) THEN
        RAISE EXCEPTION 'Ovaj klijent je unajmio vozilo u zadnjih 7 dana.';
    ELSIF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*)
                                                FROM najam
                                                WHERE idvozilo = NEW.idvozilo
                                                  AND najam.datumzavrsetkanajma IS NOT NULL
                                                  AND datumzavrsetkanajma >= NEW.datumpocetkanajma - INTERVAL '7 days') >
                                               0) THEN
        RAISE EXCEPTION 'Ovo vozilo je unajmljeno u zadnjih 7 dana.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER prevent_frequent_rentals
    BEFORE INSERT OR UPDATE
    ON najam
    FOR EACH ROW
EXECUTE PROCEDURE prevent_frequent_rentals();

---Trigger 6---
CREATE OR REPLACE FUNCTION prevent_unavailable_rentals()
    RETURNS TRIGGER AS
$$
BEGIN
    IF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*)
                                             FROM najam
                                             WHERE idvozilo = NEW.idvozilo
                                               AND najam.datumzavrsetkanajma IS NULL
                                               AND najam.vrijedido >= NEW.datumpocetkanajma) > 0) THEN
        RAISE EXCEPTION 'Ovo vozilo je trenutno u uporabi ili je unajmljeno u budućnosti.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER prevent_unavailable_rentals
    BEFORE INSERT OR UPDATE
    ON najam
    FOR EACH ROW
EXECUTE PROCEDURE prevent_unavailable_rentals();

---Trigger 7---
CREATE OR REPLACE FUNCTION check_vehicle_inspection_status()
    RETURNS TRIGGER AS
$$
BEGIN
    IF (NEW.pregled < NOW() - INTERVAL '12 months') THEN
        RAISE EXCEPTION 'Ovo vozilo nije bilo na pregledu u zadnjih 12 mjeseci.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER check_vehicle_inspection_status
    BEFORE INSERT OR UPDATE
    ON vozilo
    FOR EACH ROW
EXECUTE PROCEDURE check_vehicle_inspection_status();

---Trigger 8---
CREATE OR REPLACE FUNCTION apply_rental_discount()
    RETURNS TRIGGER AS
$$
DECLARE
    idracun integer;
    iskor boolean;
BEGIN
    -- Dohvaćanje ID-a računa za određeni najam
    SELECT "IDracun" INTO idracun FROM racun WHERE racun.idnajam = NEW."IDnajam";
    -- Provjera da li je okidač već izvršen
    SELECT iskoristeno into iskor FROM racun WHERE "IDracun" = idracun;
    IF (iskor=true) THEN
        RETURN NEW;
    END IF;
    -- Provjera da li je razdoblje najma veće od 14 dana
    IF (NEW.datumzavrsetkanajma - NEW.datumpocetkanajma > 14) THEN
        -- Dohvaćanje ID-a računa za određeni najam
        SELECT "IDracun" INTO idracun FROM racun WHERE idnajam = NEW."IDnajam";
        -- Ažuriranje računa
        UPDATE racun
        SET iznos       = iznos * 0.9,
            iskoristeno = true
        WHERE racun."IDracun" = idracun;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER apply_rental_discount
    AFTER INSERT OR UPDATE
    ON najam
    FOR EACH ROW
EXECUTE PROCEDURE apply_rental_discount();

