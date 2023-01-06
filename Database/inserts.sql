INSERT INTO public.kategorija ("IDkategorija", naziv) VALUES (6, 'Kategorija 6');
INSERT INTO public.kategorija ("IDkategorija", naziv) VALUES (5, 'Kategorija 5');
INSERT INTO public.kategorija ("IDkategorija", naziv) VALUES (4, 'Kategorija 4');
INSERT INTO public.kategorija ("IDkategorija", naziv) VALUES (3, 'Kategorija 3');
INSERT INTO public.kategorija ("IDkategorija", naziv) VALUES (2, 'Kategorija 2');
INSERT INTO public.kategorija ("IDkategorija", naziv) VALUES (1, 'Kategorija 1');

INSERT INTO public.klijent ("IDklijent", ime, prezime, datumrodenja, adresa, grad, postanskibroj, kontaktbroj, brojvozackedozvole) VALUES (1, 'Petar', 'Matisic', '2001-04-24', 'Medimurska 18', 'Varazdin', 42000, 111, 123456789);
INSERT INTO public.klijent ("IDklijent", ime, prezime, datumrodenja, adresa, grad, postanskibroj, kontaktbroj, brojvozackedozvole) VALUES (2, 'Ante', 'Antic', '2002-04-24', 'Medimurska 17', 'Zagreb', null, 111222, 987654321);
INSERT INTO public.klijent ("IDklijent", ime, prezime, datumrodenja, adresa, grad, postanskibroj, kontaktbroj, brojvozackedozvole) VALUES (3, 'Ivo', 'Ivic', '1995-04-24', 'Medimurska 19', 'Osijek', 12000, 222333, 12345678);
INSERT INTO public.klijent ("IDklijent", ime, prezime, datumrodenja, adresa, grad, postanskibroj, kontaktbroj, brojvozackedozvole) VALUES (4, 'Ana', 'Anic', '1989-04-24', 'Medimurska 11', 'Rijeka', 23000, 333444, 876543210);
INSERT INTO public.klijent ("IDklijent", ime, prezime, datumrodenja, adresa, grad, postanskibroj, kontaktbroj, brojvozackedozvole) VALUES (5, 'Marko', 'Markovic', '1999-04-24', 'Medimurska 12', 'Split', null, 444555, 123487654);
INSERT INTO public.klijent ("IDklijent", ime, prezime, datumrodenja, adresa, grad, postanskibroj, kontaktbroj, brojvozackedozvole) VALUES (6, 'Josip', 'Josipovic', '2000-04-24', 'Medimurska 14', 'Pula', 43000, 555666, 876541234);

INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (1, 'Vukovarska 12', 'Zagreb');
INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (2, 'Avenija Dubrovnik 15', 'Zagreb');
INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (3, 'Tresnjevka 16', 'Zagreb');
INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (4, 'Ducanska 12', 'Varazdin');
INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (5, 'Riva 13', 'Split');
INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (6, 'Cakovecka 19', 'Cakovec');
INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (7, 'Osijecka 17', 'Osijek');
INSERT INTO public.lokacija ("IDlokacija", adresa, grad) VALUES (8, 'Pulska 20', 'Pula');

INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (1, 'CX-3', 1);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (2, 'Picasso', 3);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (3, 'Octavia', 2);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (4, 'Golf 5', 5);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (5, 'RS6', 6);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (6, 'X5', 7);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (7, 'McLaren', 8);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (8, 'Cayman GT4', 9);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (9, 'Phantom', 10);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (10, 'Nevera', 11);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (11, 'Veyron', 12);
INSERT INTO public.model ("IDmodel", naziv, idproizvodac) VALUES (12, 'Corsa', 4);

INSERT INTO public.nacinplacanja ("IDnacinplacanja", naziv, opis) VALUES (1, 'Gotovina', 'Na lokaciji.');
INSERT INTO public.nacinplacanja ("IDnacinplacanja", naziv, opis) VALUES (2, 'Gotovina', 'Postom.');
INSERT INTO public.nacinplacanja ("IDnacinplacanja", naziv, opis) VALUES (3, 'Mobitel', 'Na lokaciji.');
INSERT INTO public.nacinplacanja ("IDnacinplacanja", naziv, opis) VALUES (4, 'Mobitel', 'Online.');
INSERT INTO public.nacinplacanja ("IDnacinplacanja", naziv, opis) VALUES (5, 'Kartica', 'Na lokaciji.');
INSERT INTO public.nacinplacanja ("IDnacinplacanja", naziv, opis) VALUES (6, 'Kartica', 'Online.');

INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (1, '2022-01-01', '2022-01-30', 'Najam auta na 30 dana.', 1, 2, 1, 1);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (2, '2022-02-01', '2022-04-30', 'Najam auta na skoro 3 mjeseca.', 2, 2, 3, 5);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (3, '2022-06-15', '2022-08-15', 'Najam auta na 2 mjeseca.', 4, 1, 6, 2);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (6, '2022-02-01', '2022-04-30', 'Najam auta na skoro 3 mjeseca.', 2, 2, 3, 5);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (7, '2022-06-15', '2022-08-15', 'Najam auta na 2 mjeseca.', 4, 1, 6, 2);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (8, '2022-11-01', '2022-12-24', 'Najam auta do Bozica.', 6, 3, 7, 6);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (10, '2022-02-01', '2022-04-30', 'Najam auta na skoro 3 mjeseca.', 2, 2, 3, 5);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (11, '2022-06-15', '2022-08-15', 'Najam auta na 2 mjeseca.', 4, 1, 6, 2);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (12, '2022-11-01', '2022-12-24', 'Najam auta do Bozica.', 6, 3, 7, 6);
INSERT INTO public.najam ("IDnajam", datumpocetkanajma, datumzavrsetkanajma, napomena, idlokacijapreuzimanja, idlokacijaostavljanja, idvozilo, idklijent) VALUES (13, '2022-09-20', '2022-09-30', 'Najam auta na kratak period.', 3, 5, 8, 4);

INSERT INTO public.osiguranje ("IDosiguranje", nazivosiguranja, opis, polica) VALUES (1, 'Croatia Osiguranje', 'Kasko 4+', 'najskuplja');
INSERT INTO public.osiguranje ("IDosiguranje", nazivosiguranja, opis, polica) VALUES (2, 'Euroherc Osiguranje', 'Full Kasko', 'najisplativija');
INSERT INTO public.osiguranje ("IDosiguranje", nazivosiguranja, opis, polica) VALUES (3, 'Adriatic Osiguranje', 'Kasko + bonusi', 'najpovoljnija');

INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (1, 2);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (2, 1);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (1, 3);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (1, 6);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (3, 7);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (3, 8);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (2, 10);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (3, 11);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (1, 12);
INSERT INTO public.osiguranjenajma ("Idosiguranje", "Idnajam") VALUES (3, 13);

INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (1, 'Mazda');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (2, 'Skoda');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (3, 'Citroen');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (4, 'Opel');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (5, 'VW');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (6, 'Audi');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (7, 'BMW');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (8, 'Mercedes');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (9, 'Porsche');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (10, 'Rolls Royce');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (11, 'Rimac');
INSERT INTO public.proizvodac ("IDproizvodac", naziv) VALUES (12, 'Bugatti');

INSERT INTO public.racun ("IDracun", datumizdavanja, iznos, idnajam, idnacinplacanja) VALUES (1, '2022-01-30', 95, 1, 1);
INSERT INTO public.racun ("IDracun", datumizdavanja, iznos, idnajam, idnacinplacanja) VALUES (2, '2022-04-30', 290, 2, 4);
INSERT INTO public.racun ("IDracun", datumizdavanja, iznos, idnajam, idnacinplacanja) VALUES (3, '2022-08-15', 200, 3, 5);
INSERT INTO public.racun ("IDracun", datumizdavanja, iznos, idnajam, idnacinplacanja) VALUES (5, '2022-12-23', 170, 6, 6);
INSERT INTO public.racun ("IDracun", datumizdavanja, iznos, idnajam, idnacinplacanja) VALUES (6, '2022-09-30', 30, 7, 2);

INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (1, 12345, '2011-03-04', 340000, 'crvena', 1, 3, 1);
INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (2, 54321, '2019-02-26', 180000, 'plava', 2, 5, 2);
INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (3, 98765, '2020-05-30', 140000, 'roza', 3, 5, 3);
INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (4, 56789, '2021-07-28', 90000, 'zelena', 4, 6, 4);
INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (5, 1234, '2016-01-15', 230000, 'zuta', 5, 4, 5);
INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (6, 43210, '2018-08-13', 190000, 'siva', 6, 5, 6);
INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (7, 87654, '2012-02-24', 280000, 'smedja', 7, 2, 7);
INSERT INTO public.vozilo ("IDvozilo", registracijskeoznake, godinaproizvodnje, kilometraza, boja, idlokacijavozila, idkategorija, idmodel) VALUES (8, 45678, '2014-09-14', 200000, 'narancasta', 8, 4, 8);
s