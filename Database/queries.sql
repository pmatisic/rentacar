---Upit 1---
select model.naziv               as "Naziv modela",
       najam.datumpocetkanajma   as "Početak najma",
       najam.datumzavrsetkanajma as "Završetak najma"
from model,
     vozilo,
     najam
where vozilo.idmodel = model."IDmodel"
  and najam.idvozilo = vozilo."IDvozilo"
  and model."naziv" = 'Octavia';

---Upit 2---
select klijent.ime               as "Ime klijenta",
       klijent.prezime           as "Prezime klijenta",
       proizvodac.naziv          as "Proizvođač auta",
       model.naziv               as "Naziv modela auta",
       najam.datumpocetkanajma   as "Početak najma",
       najam.datumzavrsetkanajma as "Završetak najma"
from klijent
         join najam on (klijent."IDklijent" = najam.idklijent)
         join vozilo on (vozilo."IDvozilo" = najam.idvozilo)
         join model on (model."IDmodel" = vozilo.idmodel)
         join proizvodac on (proizvodac."IDproizvodac" = model.idproizvodac)
where klijent.ime = 'Petar';

---Upit 3---
select proizvodac.naziv        as "Proizvođač auta",
       model.naziv             as "Model auta",
       klijent.ime             as "Ime klijenta",
       klijent.prezime         as "Prezime kijenta",
       najam.datumpocetkanajma as "Početak najma"
from klijent,
     najam,
     vozilo,
     model,
     proizvodac
where najam.idklijent = klijent."IDklijent"
  and najam.idvozilo = vozilo."IDvozilo"
  and vozilo.idmodel = model."IDmodel"
  and model.idproizvodac = proizvodac."IDproizvodac"
  and najam.datumzavrsetkanajma IS NULL;

---Upit 4---
select (select Grad
        from Lokacija
        where Lokacija."IDlokacija" = Vozilo.idlokacijavozila)                as "Grad",
       Vozilo.registracijskeoznake                                            as "Registracijska oznaka",
       proizvodac.Naziv                                                       as "Proizvodjac",
       (select Model.Naziv from Model where Model."IDmodel" = Vozilo.idmodel) as "Model"
from Vozilo
         join Najam on (Najam.idvozilo = Vozilo."IDvozilo")
         join Model on (Model."IDmodel" = Vozilo.idmodel)
         join proizvodac on (proizvodac."IDproizvodac" = Model.idproizvodac)
where Najam.datumzavrsetkanajma is not null
  and (select Lokacija.grad from Lokacija where Lokacija."IDlokacija" = Vozilo.idlokacijavozila) =
      'Zagreb'
except
select (select Grad
        from Lokacija
        where Lokacija."IDlokacija" = Vozilo.idlokacijavozila)                as "Grad",
       Vozilo.registracijskeoznake                                            as "Registracijska oznaka",
       proizvodac.Naziv                                                       as "Proizvodjac",
       (select Model.Naziv from Model where Model."IDmodel" = Vozilo.idmodel) as "Model"
from Vozilo
         join Najam on (Najam.idvozilo = Vozilo."IDvozilo")
         join Model on (Model."IDmodel" = Vozilo.idmodel)
         join proizvodac on (proizvodac."IDproizvodac" = Model.idproizvodac)
where Najam.datumzavrsetkanajma is null
  and (select Lokacija.grad from Lokacija where Lokacija."IDlokacija" = Vozilo.idlokacijavozila) =
      'Zagreb';