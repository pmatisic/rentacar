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
    public partial class frmVozilo : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmVozilo()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select \"IDvozilo\", registracijskeoznake as \"Registracijske oznake\", godinaproizvodnje as \"Datum proizvodnje auta\", kilometraza as \"Kilometraža\", boja as \"Boja\", idlokacijavozila as \"Šifra lokacije vozila\", idkategorija as \"Šifra kategorije\", idmodel as \"Šifra modela vozila\", pregled as \"Datum tehničkog pregleda\" from vozilo;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvVozila.DataSource = dt;
            con.Close();
        }

        private void frmVozilo_Load(object sender, EventArgs e)
        {
            prikazi_podatke();
        }

        private void tbKreiraj_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                NpgsqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vozilo values('" + tbID.Text + "', '" + tbRegistracijskeOznake.Text + "', '" + tbDatumProizvodnje.Text + "', '" + tbKilometraza.Text + "', '" + tbBoja.Text + "', '" + tbIDlokacije.Text + "', '" + tbIDkategorije.Text + "', '" + tbIDmodela.Text + "', '" + tbDatumPregleda.Text + "');";
                cmd.ExecuteNonQuery();
                con.Close();
                prikazi_podatke();
                MessageBox.Show("Zapis je unesen u bazu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void tbObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                NpgsqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from vozilo where \"IDvozilo\"='" + tbID.Text + "';";
                cmd.ExecuteNonQuery();
                con.Close();
                prikazi_podatke();
                MessageBox.Show("Zapis je obrisan iz baze!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void tbAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                NpgsqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update vozilo set registracijskeoznake='" + tbRegistracijskeOznake.Text + "', godinaproizvodnje='" + tbDatumProizvodnje.Text + "', kilometraza='" + tbKilometraza.Text + "', boja='" + tbBoja.Text + "', \"idlokacijavozila\"='" + tbIDlokacije.Text + "', \"idkategorija\"='" + tbIDkategorije.Text + "',  \"idmodel\"='" + tbIDmodela.Text + "', pregled='" + tbDatumPregleda.Text + "' where \"IDvozilo\"='" + tbID.Text + "';";
                cmd.ExecuteNonQuery();
                con.Close();
                prikazi_podatke();
                MessageBox.Show("Zapis je ažuriran u bazi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void tbPrikazi_Click(object sender, EventArgs e)
        {
            prikazi_podatke();
        }
    }
}
