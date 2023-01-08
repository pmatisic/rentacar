create table osiguranje
(
    "IDosiguranje"  serial
        primary key,
    nazivosiguranja varchar(255) not null,
    opis            varchar(255) not null,
    polica          varchar(255)
);

create table nacinplacanja
(
    "IDnacinplacanja" serial
        primary key,
    naziv             varchar(255) not null,
    opis              varchar(255) not null
);

create table lokacija
(
    "IDlokacija" serial
        primary key,
    adresa       varchar(255) not null,
    grad         varchar(255) not null
);

create table kategorija
(
    "IDkategorija" serial
        primary key,
    naziv          varchar(255) not null
);

create table proizvodac
(
    "IDproizvodac" serial
        primary key,
    naziv          varchar(255) not null
);

create table klijent
(
    "IDklijent"        serial
        primary key,
    ime                varchar(255) not null,
    prezime            varchar(255) not null,
    datumrodenja       date         not null,
    adresa             varchar(255) not null,
    grad               varchar(255) not null,
    postanskibroj      integer,
    kontaktbroj        integer      not null,
    brojvozackedozvole integer      not null
);

create table model
(
    "IDmodel"    serial
        primary key,
    naziv        varchar(255) not null,
    idproizvodac integer      not null
        constraint "model_fk_IDproizvodac_idproizvodac"
            references proizvodac
);

create table vozilo
(
    "IDvozilo"           serial
        primary key,
    registracijskeoznake integer      not null,
    godinaproizvodnje    date         not null,
    kilometraza          integer      not null,
    boja                 varchar(255) not null,
    idlokacijavozila     integer      not null
        constraint "vozilo_fk_IDlokacija_idlokacijavozila"
            references lokacija,
    idkategorija         integer      not null
        constraint "vozilo_fk_IDkategorija_idkategorija"
            references kategorija,
    idmodel              integer      not null
        constraint "vozilo_fk_IDmodel_idmodel"
            references model,
    pregled              timestamp
);

create table najam
(
    "IDnajam"             serial
        primary key,
    datumpocetkanajma     date    not null,
    datumzavrsetkanajma   date,
    napomena              varchar(255),
    idlokacijapreuzimanja integer not null
        constraint "najam_fk_IDlokacija_idlokacijapreuzimanja"
            references lokacija,
    idlokacijaostavljanja integer not null
        constraint "najam_fk_IDlokacija_idlokacijaostavljanja"
            references lokacija,
    idvozilo              integer not null
        constraint "najam_fk_IDvozilo_idvozilo"
            references vozilo,
    idklijent             integer not null
        constraint "najam_fk_IDklijent_idklijent"
            references klijent,
    vrijediod             timestamp,
    vrijedido             timestamp
);

create table osiguranjenajma
(
    "Idosiguranje" integer not null
        constraint "osiguranjenajma_fk_IDosiguranje_Idosiguranje"
            references osiguranje,
    "Idnajam"      integer not null
        constraint "osiguranjenajma_fk_IDnajam_Idnajam"
            references najam,
    constraint osiguranjenajma_pk
        primary key ("Idosiguranje", "Idnajam")
);

create table racun
(
    "IDracun"       serial
        primary key,
    datumizdavanja  date    not null,
    iznos           integer not null,
    idnajam         integer not null
        constraint "racun_fk_IDnajam_idnajam"
            references najam,
    idnacinplacanja integer not null
        constraint "racun_fk_IDnacinplacanja_idnacinplacanja"
            references nacinplacanja,
    iskoristeno     boolean
);

create or replace function check_rental_validity() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.vrijediod > NEW.vrijedido) THEN
    RAISE EXCEPTION 'Početak vremenskog raspona validnosti najma ne može biti poslije kraja raspona.';
  ELSIF (NEW.datumpocetkanajma < NEW.vrijediod OR NEW.datumpocetkanajma > NEW.vrijedido) THEN
    RAISE EXCEPTION 'Datum početka najma nije unutar vremenskog raspona validnosti najma.';
  END IF;
  RETURN NEW;
END;
$$;

create trigger check_rental_validity
    before insert or update
    on najam
    for each row
execute procedure check_rental_validity();

create or replace function prevent_frequent_rentals() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*) FROM najam WHERE idklijent = NEW.idklijent AND najam.datumzavrsetkanajma IS NOT NULL AND datumzavrsetkanajma >= NEW.datumpocetkanajma - INTERVAL '7 days') > 0) THEN
    RAISE EXCEPTION 'Ovaj klijent je unajmio vozilo u zadnjih 7 dana.';
  ELSIF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*) FROM najam WHERE idvozilo = NEW.idvozilo AND najam.datumzavrsetkanajma IS NOT NULL AND datumzavrsetkanajma >= NEW.datumpocetkanajma - INTERVAL '7 days') > 0) THEN
    RAISE EXCEPTION 'Ovo vozilo je unajmljeno u zadnjih 7 dana.';
  END IF;
  RETURN NEW;
END;
$$;

create trigger prevent_frequent_rentals
    before insert or update
    on najam
    for each row
execute procedure prevent_frequent_rentals();

create or replace function prevent_unavailable_rentals() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*) FROM najam WHERE idvozilo = NEW.idvozilo AND najam.datumzavrsetkanajma IS NULL AND najam.vrijedido >= NEW.datumpocetkanajma) > 0) THEN
    RAISE EXCEPTION 'Ovo vozilo je trenutno u uporabi ili je unajmljeno u budućnosti.';
  END IF;
  RETURN NEW;
END;
$$;

create trigger prevent_unavailable_rentals
    before insert or update
    on najam
    for each row
execute procedure prevent_unavailable_rentals();

create or replace function check_vehicle_inspection_status() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.pregled < NOW() - INTERVAL '12 months') THEN
    RAISE EXCEPTION 'Ovo vozilo nije bilo na pregledu u zadnjih 12 mjeseci.';
  END IF;
  RETURN NEW;
END;
$$;

create trigger check_vehicle_inspection_status
    before insert or update
    on vozilo
    for each row
execute procedure check_vehicle_inspection_status();

create or replace function prevent_vehicle_rental_from_different_location() returns trigger
    language plpgsql
as
$$
BEGIN
    IF (OLD.idlokacijaostavljanja != NEW.idlokacijapreuzimanja) THEN
        RAISE EXCEPTION 'Vozilo se ne nalazi na istoj lokaciji na kojoj ga želite preuzeti.';
    END IF;
    RETURN NEW;
END;
$$;

create trigger prevent_vehicle_rental_from_different_location
    before insert or update
    on najam
    for each row
execute procedure prevent_vehicle_rental_from_different_location();

create or replace function update_vehicle_location_on_return() returns trigger
    language plpgsql
as
$$
BEGIN
    IF (NEW.idlokacijaostavljanja != OLD.idlokacijapreuzimanja) THEN
        UPDATE vozilo
        SET idlokacijavozila = NEW.idlokacijaostavljanja
        WHERE vozilo."IDvozilo" = NEW."idvozilo";
    END IF;
    RETURN NEW;
END;
$$;

create trigger update_vehicle_location_on_return
    after insert or update
    on najam
    for each row
execute procedure update_vehicle_location_on_return();

create or replace function prevent_double_rentals() returns trigger
    language plpgsql
as
$$
BEGIN
    -- Provjera je li najam nekog klijenta aktivan
    IF (NEW.datumzavrsetkanajma IS NULL AND
        (SELECT COUNT(*) FROM najam WHERE idklijent = NEW.idklijent AND najam.datumzavrsetkanajma IS NULL) > 0) THEN
        RAISE EXCEPTION 'Ovaj klijent već ima aktivni najam vozila.';
    -- Provjera je li klijent već iznajmio neko vozilo u rasponu od datuma početka najma do datuma završetka najma
    ELSIF (NEW.datumzavrsetkanajma IS NULL AND
        (SELECT COUNT(*) FROM najam WHERE idklijent = NEW.idklijent AND datumpocetkanajma <= NEW.datumpocetkanajma AND datumzavrsetkanajma >= NEW.datumpocetkanajma) > 0) THEN
        RAISE EXCEPTION 'Ovaj klijent već ima iznajmljeno vozilo u odabranom vremenskom rasponu.';
    -- Provjera je li najam nekog vozila aktivan
    ELSIF (NEW.datumzavrsetkanajma IS NULL AND
           (SELECT COUNT(*) FROM najam WHERE idvozilo = NEW.idvozilo AND najam.datumzavrsetkanajma IS NULL) > 0) THEN
        RAISE EXCEPTION 'Ovo vozilo je već iznajmljeno.';
    -- Provjera je li vozilo već iznajmljeno u rasponu od datuma početka najma do datuma završetka najma
    ELSIF (NEW.datumzavrsetkanajma IS NULL AND
           (SELECT COUNT(*) FROM najam WHERE idvozilo = NEW.idvozilo AND datumpocetkanajma <= NEW.datumpocetkanajma AND datumzavrsetkanajma >= NEW.datumpocetkanajma) > 0) THEN
        RAISE EXCEPTION 'Ovo vozilo je već iznajmljeno u odabranom vremenskom rasponu.';
    END IF;
    RETURN NEW;
END;
$$;

create trigger prevent_double_rentals
    before insert or update
    on najam
    for each row
execute procedure prevent_double_rentals();

create or replace function apply_rental_discount() returns trigger
    language plpgsql
as
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
$$;

create trigger apply_rental_discount
    after insert or update
    on najam
    for each row
execute procedure apply_rental_discount();


