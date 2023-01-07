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

namespace RentACar
{
    public partial class frmRačun : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmRačun()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select \"IDracun\" as \"Šifra računa\", \"idnajam\" as \"Šifra najma\", \"idnacinplacanja\" as \"Šifra načina plaćanja\", datumizdavanja as \"Datum izdavanja\", iznos as \"Iznos računa\", iskoristeno as \"Iskorišteni kupon\" from racun;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvRacuni.DataSource = dt;
            con.Close();
        }

        private void frmRačun_Load(object sender, EventArgs e)
        {
            prikazi_podatke();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into racun values('" + tbID.Text + "', '" + tbDatum.Text + "', '" + tbIznos.Text + "', '" + tbIDNajma.Text + "', '" + tbIDNacina.Text + "', '" + tbIskoristeno.Text + "');";
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
            cmd.CommandText = "delete from racun where \"IDracun\"='" + tbID.Text + "';";
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
            cmd.CommandText = "update racun set datumizdavanja='" + tbDatum.Text + "', iznos='" + tbIznos.Text + "', idnajam='" + tbIDNajma.Text + "', idnacinplacanja='" + tbIDNacina.Text + "', iskoristeno='" + tbIskoristeno.Text + "' where \"IDracun\"='" + tbID.Text + "';";
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
