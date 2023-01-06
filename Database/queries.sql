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