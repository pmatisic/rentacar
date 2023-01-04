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

namespace RentACar
{
    public partial class frmPočetna : Form
    {
        public frmPočetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLokacija forma1 = new frmLokacija();
            forma1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategorija forma2 = new frmKategorija();
            forma2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProizvođač forma3 = new frmProizvođač();
            forma3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmModel forma4 = new frmModel();
            forma4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmVozilo forma5 = new frmVozilo();
            forma5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmNačinPlaćanja forma6 = new frmNačinPlaćanja();
            forma6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmRačun forma7 = new frmRačun();
            forma7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmNajam forma8 = new frmNajam();
            forma8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmKlijent forma9 = new frmKlijent();
            forma9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmOsiguranje forma10 = new frmOsiguranje();
            forma10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmOsiguranjeNajma forma11 = new frmOsiguranjeNajma();
            forma11.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmUpiti forma12 = new frmUpiti();
            forma12.Show();
        }
    }
}
