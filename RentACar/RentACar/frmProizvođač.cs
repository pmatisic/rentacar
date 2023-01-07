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
    public partial class frmProizvođač : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmProizvođač()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select \"IDproizvodac\" as \"Šifra proizvođača\", naziv as \"Naziv proizvođača\" from proizvodac;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvProizvodaci.DataSource = dt;
            con.Close();
        }

        private void frmProizvođač_Load(object sender, EventArgs e)
        {
            prikazi_podatke();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into proizvodac values('" + tbID.Text + "', '" + tbNaziv.Text + "');";
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
            cmd.CommandText = "delete from proizvodac where \"IDproizvodac\"='" + tbID.Text + "';";
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
            cmd.CommandText = "update proizvodac set naziv='" + tbNaziv.Text + "' where \"IDproizvodac\"='" + tbID.Text + "';";
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
