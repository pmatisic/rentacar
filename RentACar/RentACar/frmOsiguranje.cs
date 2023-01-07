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
    public partial class frmOsiguranje : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmOsiguranje()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select \"IDosiguranje\" as \"Šifra osiguranja\", nazivosiguranja as \"Naziv\", opis as \"Opis\", polica as \"Polica\" from osiguranje;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOsiguranja.DataSource = dt;
            con.Close();
        }

        private void frmOsiguranje_Load(object sender, EventArgs e)
        {
            prikazi_podatke();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into osiguranje values('" + tbID.Text + "', '" + tbNaziv.Text + "', '" + tbOpis.Text + "', '" + tbPolica.Text + "');";
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
            cmd.CommandText = "delete from osiguranje where \"IDosiguranje\"='" + tbID.Text + "';";
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
            cmd.CommandText = "update osiguranje set nazivosiguranja='" + tbNaziv.Text + "', opis='" + tbOpis.Text + "', polica='" + tbPolica.Text +"' where \"IDosiguranje\"='" + tbID.Text + "';";
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
