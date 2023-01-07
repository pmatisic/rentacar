using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar
{
    public partial class frmKlijent : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmKlijent()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select \"IDklijent\" as \"Šifra klijenta\", ime as \"Ime\", prezime as \"Prezime\", datumrodenja as \"Datum rođenja\", adresa as \"Adresa\", grad as \"Grad\", postanskibroj as \"Postanski broj\", kontaktbroj as \"Kontakt broj\", brojvozackedozvole as \"Broj vozačke dozvole\" from klijent;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvKlijenti.DataSource = dt;
            con.Close();
        }

        private void frmKlijent_Load(object sender, EventArgs e)
        {
            prikazi_podatke();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into klijent values('" + tbID.Text + "', '" + tbIme.Text + "', '" + tbPrezime.Text + "', '" + tbDatum.Text + "', '" + tbAdresa.Text + "', '" + tbGrad.Text + "', '" + tbPostanski.Text + "', '" + tbKontakt.Text + "', '" + tbVozacka.Text + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            prikazi_podatke();
            MessageBox.Show("Zapis je unesen u bazu!");
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from klijent where \"IDklijent\"='" + tbID.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            prikazi_podatke();
            MessageBox.Show("Zapis je obrisan iz baze!");
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update klijent set ime='" + tbIme.Text + "', prezime='" + tbPrezime.Text + "', datumrodenja='" + tbDatum.Text + "', adresa='" + tbAdresa.Text + "', grad='" + tbGrad.Text + "', postanskibroj='" + tbPostanski.Text + "', kontaktbroj='" + tbKontakt.Text + "', brojvozackedozvole='" + tbVozacka.Text + "' where \"IDklijent\"='" + tbID.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            prikazi_podatke();
            MessageBox.Show("Zapis je ažuriran u bazi!");
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            prikazi_podatke();
        }
    }
}
