create table osiguranje
(
    "IDosiguranje"  serial
        primary key,
    nazivosiguranja varchar(255) not null,
    opis            varchar(255) not null,
    polica          varchar(255) not null
);

alter table osiguranje
    owner to postgres;

create table nacinplacanja
(
    "IDnacinplacanja" serial
        primary key,
    naziv             varchar(255) not null,
    opis              varchar      not null
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
            references model
);

alter table vozilo
    owner to postgres;

create table najam
(
    "IDnajam"             serial
        primary key,
    datumpocetkanajma     date    not null,
    datumzavrsetkanajma   date    not null,
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
            references klijent
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


