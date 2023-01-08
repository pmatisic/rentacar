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
    public partial class frmOsiguranjeNajma : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmOsiguranjeNajma()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select osiguranjenajma.\"Idosiguranje\" as \"Šifra osiguranja\", osiguranje.nazivosiguranja as \"Naziv\", osiguranjenajma.\"Idnajam\" as \"Šifra najma\" from osiguranje, osiguranjenajma where osiguranjenajma.\"Idosiguranje\" = osiguranje.\"IDosiguranje\";";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOsiguranjaNajmova.DataSource = dt;
            con.Close();
        }

        private void frmOsiguranjeNajma_Load(object sender, EventArgs e)
        {
            prikazi_podatke();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                NpgsqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into osiguranjenajma values('" + tbIDos.Text + "', '" + tbIDnaj.Text + "');";
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                NpgsqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from osiguranjenajma where \"Idosiguranje\"='" + tbIDos.Text + "' and \"Idnajam\"='" + tbIDnaj.Text + "';";
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

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                NpgsqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update osiguranjenajma set \"Idosiguranje\" = '" + tbIDos.Text + "' where \"Idnajam\"='" + tbIDnaj.Text + "';";
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            prikazi_podatke();
        }
    }
}
