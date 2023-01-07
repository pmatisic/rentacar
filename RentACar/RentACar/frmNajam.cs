using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar
{
    public partial class frmNajam : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;");

        public frmNajam()
        {
            InitializeComponent();
        }

        public void prikazi_podatke()
        {
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select \"IDnajam\" as \"Šifra najma\", \"idklijent\" as \"Šifra klijenta\", \"idvozilo\" as \"Šifra vozila\", datumpocetkanajma as \"Datum početka najma\", datumzavrsetkanajma as \"Datum završetka najma\", idlokacijapreuzimanja as \"Šifra lokacije preuzimanja\", idlokacijaostavljanja as \"Šifra lokacije ostavljanja\", napomena as \"Napomena\", vrijediod as \"Vrijedi od\", vrijedido as \"Vrijedi do\" from najam;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            dgvNajmovi.DataSource = dt;
            con.Close();
        }

        private void frmNajam_Load(object sender, EventArgs e)
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
                cmd.CommandText = "insert into najam values('" + tbIDnajma.Text + "', '" + tbPocetak.Text + "', NULL, '" + tbNapomena.Text + "', '" + tbLokacijaPreuzimanja.Text + "', '" + tbLokacijaOstavljanja.Text + "', '" + tbIDvozila.Text + "', '" + tbIDklijenta.Text + "', NULL, NULL);";
                cmd.ExecuteNonQuery();
                con.Close();
                prikazi_podatke();
                MessageBox.Show("Zapis je unesen u bazu!");
            }
            catch(Exception ex)
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
                cmd.CommandText = "delete from najam where \"IDnajam\"='" + tbIDnajma.Text + "';";
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
                cmd.CommandText = "update najam set datumpocetkanajma='" + tbPocetak.Text + "', datumzavrsetkanajma='" + tbZavrsetak.Text + "', idlokacijapreuzimanja='" + tbLokacijaPreuzimanja.Text + "', idlokacijaostavljanja='" + tbLokacijaOstavljanja.Text + "', \"idklijent\"='" + tbIDklijenta.Text + "', \"idvozilo\"='" + tbIDvozila.Text + "',  napomena='" + tbNapomena.Text + "', vrijediod='" + tbVrijediOd.Text + "', vrijedido='" + tbVrijediDo.Text + "' where \"IDnajam\"='" + tbIDnajma.Text + "';";
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
