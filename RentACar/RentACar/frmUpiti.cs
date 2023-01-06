using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RentACar
{
    public partial class frmUpiti : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmUpiti()
        {
            InitializeComponent();
        }

        public void prikazi_podatke1()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select model.naziv as \"Naziv modela\", najam.datumpocetkanajma as \"Početak najma\", najam.datumzavrsetkanajma as \"Završetak najma\" from model, vozilo, najam where vozilo.idmodel=model.\"IDmodel\" and najam.idvozilo=vozilo.\"IDvozilo\" and model.\"naziv\"='" + tbModel.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvUpit1.DataSource = dt;
            con.Close();
        }
        public void prikazi_podatke2()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select klijent.ime as \"Ime klijenta\", klijent.prezime as \"Prezime klijenta\", proizvodac.naziv as \"Proizvođač auta\", model.naziv as \"Naziv modela auta\", najam.datumpocetkanajma as \"Početak najma\", najam.datumzavrsetkanajma as \"Završetak najma\" from klijent join najam on (klijent.\"IDklijent\" = najam.idklijent) join vozilo on (vozilo.\"IDvozilo\"=najam.idvozilo) join model on (model.\"IDmodel\"=vozilo.idmodel) join proizvodac on (proizvodac.\"IDproizvodac\"=model.idproizvodac) where klijent.ime='" + tbKlijent.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvUpit2.DataSource = dt;
            con.Close();
        }
        public void prikazi_podatke3()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select proizvodac.naziv as \"Proizvođač auta\", model.naziv as \"Model auta\", klijent.ime as \"Ime klijenta\", klijent.prezime as \"Prezime kijenta\", najam.datumpocetkanajma as \"Početak najma\" from klijent, najam, vozilo, model, proizvodac where najam.idklijent=klijent.\"IDklijent\" and najam.idvozilo=vozilo.\"IDvozilo\" and vozilo.idmodel=model.\"IDmodel\" and model.idproizvodac=proizvodac.\"IDproizvodac\" and najam.datumzavrsetkanajma is null;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvUpit3.DataSource = dt;
            con.Close();
        }
        public void prikazi_podatke4()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select (select grad from lokacija where lokacija.\"IDlokacija\"=vozilo.idlokacijavozila) as \"Grad\", vozilo.registracijskeoznake as \"Registracijska oznaka\", proizvodac.naziv as \"Proizvođač auta\", (select model.naziv from model where model.\"IDmodel\"=vozilo.idmodel) as \"Model auta\" from vozilo join najam on (najam.idvozilo=vozilo.\"IDvozilo\") join model on (model.\"IDmodel\"=vozilo.idmodel) join proizvodac on (proizvodac.\"IDproizvodac\"=model.idproizvodac) where najam.datumzavrsetkanajma is not null and (select lokacija.\"grad\" from lokacija where lokacija.\"IDlokacija\"=vozilo.idlokacijavozila)='" + tbLokacija.Text + "' except select (select grad from lokacija where lokacija.\"IDlokacija\"=vozilo.idlokacijavozila) as \"Grad\", vozilo.registracijskeoznake as \"Registracijska oznaka\", proizvodac.naziv as \"Proizvođač auta\", (select model.naziv from model where Model.\"IDmodel\"=vozilo.idmodel) as \"Model auta\" from vozilo join najam on (najam.idvozilo=vozilo.\"IDvozilo\") join model on (model.\"IDmodel\"=vozilo.idmodel) join proizvodac on (proizvodac.\"IDproizvodac\"=model.idproizvodac) where najam.datumzavrsetkanajma is null and (select lokacija.\"grad\" from lokacija where lokacija.\"IDlokacija\"=vozilo.idlokacijavozila)='" + tbLokacija.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvUpit4.DataSource = dt;
            con.Close();
        }

        private void frmUpiti_Load(object sender, EventArgs e)
        {
            //prikazi_podatke();
        }

        private void btnPrikazi1_Click(object sender, EventArgs e)
        {
            prikazi_podatke1();
        }

        private void btnPrikazi2_Click(object sender, EventArgs e)
        {
            prikazi_podatke2();
        }

        private void btnPrikazi3_Click(object sender, EventArgs e)
        {
            prikazi_podatke3();
        }

        private void btnPrikazi4_Click(object sender, EventArgs e)
        {
            prikazi_podatke4();
        }
    }
}
