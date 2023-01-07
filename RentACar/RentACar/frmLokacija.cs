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
    public partial class frmLokacija : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmLokacija()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select \"IDlokacija\" as \"Šifra lokacije\", adresa as \"Adresa\", grad as \"Grad\" from lokacija;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLokacije.DataSource = dt;
            con.Close();
        }

        private void frmLokacija_Load(object sender, EventArgs e)
        {
            prikazi_podatke();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into lokacija values('" + tbID.Text + "', '" + tbAdresa.Text + "', '" + tbGrad.Text + "')";
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
            cmd.CommandText = "delete from lokacija where \"IDlokacija\"='" + tbID.Text + "'";
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
            cmd.CommandText = "update lokacija set adresa='" + tbAdresa.Text + "', grad='" + tbGrad.Text + "' where \"IDlokacija\"='" + tbID.Text + "'";
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
