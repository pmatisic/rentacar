create table osiguranje
(
    "IDosiguranje"  serial
        primary key,
    nazivosiguranja varchar(255) not null,
    opis            varchar(255) not null,
    polica          varchar(255)
);

alter table osiguranje
    owner to postgres;

create table nacinplacanja
(
    "IDnacinplacanja" serial
        primary key,
    naziv             varchar(255) not null,
    opis              varchar(255) not null
);

alter table nacinplacanja
    owner to postgres;

create table lokacija
(
    "IDlokacija" serial
        primary key,
    adresa       varchar(255) not null,
    grad         varchar(255) not null
);

alter table lokacija
    owner to postgres;

create table kategorija
(
    "IDkategorija" serial
        primary key,
    naziv          varchar(255) not null
);

alter table kategorija
    owner to postgres;

create table proizvodac
(
    "IDproizvodac" serial
        primary key,
    naziv          varchar(255) not null
);

alter table proizvodac
    owner to postgres;

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

alter table klijent
    owner to postgres;

create table model
(
    "IDmodel"    serial
        primary key,
    naziv        varchar(255) not null,
    idproizvodac integer      not null
        constraint "model_fk_IDproizvodac_idproizvodac"
            references proizvodac
);

alter table model
    owner to postgres;

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

alter table vozilo
    owner to postgres;

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

alter table najam
    owner to postgres;

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

alter table osiguranjenajma
    owner to postgres;

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
            references nacinplacanja
);

alter table racun
    owner to postgres;

create function prevent_vehicle_rental_from_different_location() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.idlokacijaostavljanja != NEW.idlokacijapreuzimanja) THEN
    RAISE EXCEPTION 'Vozilo se ne nalazi na istoj lokaciji na kojoj ga želite preuzeti.';
  END IF;
  RETURN NEW;
END;
$$;

alter function prevent_vehicle_rental_from_different_location() owner to postgres;

create trigger prevent_vehicle_rental_from_different_location
    before insert or update
    on najam
    for each row
execute procedure prevent_vehicle_rental_from_different_location();

create function update_vehicle_location_on_return() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.idlokacijaostavljanja != OLD.idlokacijapreuzimanja) THEN
    UPDATE vozilo
    SET idlokacijavozila = NEW.idlokacijaostavljanja
    WHERE IDvozilo = NEW.idvozilo;
  END IF;
  RETURN NEW;
END;
$$;

alter function update_vehicle_location_on_return() owner to postgres;

create trigger update_vehicle_location_on_return
    after insert or update
    on najam
    for each row
execute procedure update_vehicle_location_on_return();

create function check_rental_validity() returns trigger
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

alter function check_rental_validity() owner to postgres;

create trigger check_rental_validity
    before insert or update
    on najam
    for each row
execute procedure check_rental_validity();

create function prevent_double_rentals() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*) FROM najam WHERE idklijent = NEW.idklijent AND najam.datumzavrsetkanajma IS NULL) > 0) THEN
    RAISE EXCEPTION 'Ovaj klijent već ima aktivni najam vozila.';
  ELSIF (NEW.datumzavrsetkanajma IS NULL AND (SELECT COUNT(*) FROM najam WHERE idvozilo = NEW.idvozilo AND najam.datumzavrsetkanajma IS NULL) > 0) THEN
    RAISE EXCEPTION 'Ovo vozilo je već iznajmljeno.';
  END IF;
  RETURN NEW;
END;
$$;

alter function prevent_double_rentals() owner to postgres;

create trigger prevent_double_rentals
    before insert or update
    on najam
    for each row
execute procedure prevent_double_rentals();

create function prevent_frequent_rentals() returns trigger
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

alter function prevent_frequent_rentals() owner to postgres;

create trigger prevent_frequent_rentals
    before insert or update
    on najam
    for each row
execute procedure prevent_frequent_rentals();

create function prevent_unavailable_rentals() returns trigger
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

alter function prevent_unavailable_rentals() owner to postgres;

create trigger prevent_unavailable_rentals
    before insert or update
    on najam
    for each row
execute procedure prevent_unavailable_rentals();

create function check_vehicle_year() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.godinaproizvodnje < EXTRACT(YEAR FROM NOW())) THEN
    RAISE EXCEPTION 'Godina proizvodnje ne može biti manja od trenutne godine.';
  END IF;
  RETURN NEW;
END;
$$;

alter function check_vehicle_year() owner to postgres;

create trigger check_vehicle_year
    before insert or update
    on vozilo
    for each row
execute procedure check_vehicle_year();

create function check_vehicle_inspection_status() returns trigger
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

alter function check_vehicle_inspection_status() owner to postgres;

create trigger check_vehicle_inspection_status
    before insert or update
    on vozilo
    for each row
execute procedure check_vehicle_inspection_status();

create function apply_rental_discount() returns trigger
    language plpgsql
as
$$
BEGIN
  IF (NEW.datumzavrsetkanajma - NEW.datumpocetkanajma > 14) THEN
    UPDATE racun
    SET iznos = iznos * 0.9
    WHERE racun.idnajam = NEW."IDnajam";
  END IF;
  RETURN NEW;
END;
$$;

alter function apply_rental_discount() owner to postgres;

create trigger apply_rental_discount
    after insert or update
    on najam
    for each row
execute procedure apply_rental_discount();


