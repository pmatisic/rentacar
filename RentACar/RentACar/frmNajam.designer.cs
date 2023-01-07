namespace RentACar
{
    partial class frmNajam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNajmovi = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.tbLokacijaOstavljanja = new System.Windows.Forms.TextBox();
            this.tbLokacijaPreuzimanja = new System.Windows.Forms.TextBox();
            this.tbZavrsetak = new System.Windows.Forms.TextBox();
            this.tbPocetak = new System.Windows.Forms.TextBox();
            this.tbIDvozila = new System.Windows.Forms.TextBox();
            this.tbIDklijenta = new System.Windows.Forms.TextBox();
            this.tbIDnajma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVrijediDo = new System.Windows.Forms.TextBox();
            this.tbVrijediOd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNajmovi
            // 
            this.dgvNajmovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNajmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNajmovi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNajmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajmovi.Location = new System.Drawing.Point(342, 75);
            this.dgvNajmovi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNajmovi.Name = "dgvNajmovi";
            this.dgvNajmovi.RowHeadersWidth = 51;
            this.dgvNajmovi.Size = new System.Drawing.Size(1147, 484);
            this.dgvNajmovi.TabIndex = 41;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(228, 531);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 40;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(49, 531);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.btnAzuriraj.TabIndex = 39;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(228, 470);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 38;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreiraj.Location = new System.Drawing.Point(49, 470);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(100, 28);
            this.btnKreiraj.TabIndex = 37;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // tbNapomena
            // 
            this.tbNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNapomena.Location = new System.Drawing.Point(196, 331);
            this.tbNapomena.Margin = new System.Windows.Forms.Padding(4);
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(132, 22);
            this.tbNapomena.TabIndex = 36;
            // 
            // tbLokacijaOstavljanja
            // 
            this.tbLokacijaOstavljanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLokacijaOstavljanja.Location = new System.Drawing.Point(196, 295);
            this.tbLokacijaOstavljanja.Margin = new System.Windows.Forms.Padding(4);
            this.tbLokacijaOstavljanja.Name = "tbLokacijaOstavljanja";
            this.tbLokacijaOstavljanja.Size = new System.Drawing.Size(132, 22);
            this.tbLokacijaOstavljanja.TabIndex = 35;
            // 
            // tbLokacijaPreuzimanja
            // 
            this.tbLokacijaPreuzimanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLokacijaPreuzimanja.Location = new System.Drawing.Point(196, 258);
            this.tbLokacijaPreuzimanja.Margin = new System.Windows.Forms.Padding(4);
            this.tbLokacijaPreuzimanja.Name = "tbLokacijaPreuzimanja";
            this.tbLokacijaPreuzimanja.Size = new System.Drawing.Size(132, 22);
            this.tbLokacijaPreuzimanja.TabIndex = 34;
            // 
            // tbZavrsetak
            // 
            this.tbZavrsetak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbZavrsetak.Location = new System.Drawing.Point(196, 223);
            this.tbZavrsetak.Margin = new System.Windows.Forms.Padding(4);
            this.tbZavrsetak.Name = "tbZavrsetak";
            this.tbZavrsetak.Size = new System.Drawing.Size(132, 22);
            this.tbZavrsetak.TabIndex = 33;
            // 
            // tbPocetak
            // 
            this.tbPocetak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPocetak.Location = new System.Drawing.Point(196, 185);
            this.tbPocetak.Margin = new System.Windows.Forms.Padding(4);
            this.tbPocetak.Name = "tbPocetak";
            this.tbPocetak.Size = new System.Drawing.Size(132, 22);
            this.tbPocetak.TabIndex = 32;
            // 
            // tbIDvozila
            // 
            this.tbIDvozila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDvozila.Location = new System.Drawing.Point(196, 146);
            this.tbIDvozila.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDvozila.Name = "tbIDvozila";
            this.tbIDvozila.Size = new System.Drawing.Size(132, 22);
            this.tbIDvozila.TabIndex = 31;
            // 
            // tbIDklijenta
            // 
            this.tbIDklijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDklijenta.Location = new System.Drawing.Point(196, 108);
            this.tbIDklijenta.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDklijenta.Name = "tbIDklijenta";
            this.tbIDklijenta.Size = new System.Drawing.Size(132, 22);
            this.tbIDklijenta.TabIndex = 30;
            // 
            // tbIDnajma
            // 
            this.tbIDnajma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDnajma.Location = new System.Drawing.Point(196, 75);
            this.tbIDnajma.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDnajma.Name = "tbIDnajma";
            this.tbIDnajma.Size = new System.Drawing.Size(132, 22);
            this.tbIDnajma.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Napomena:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Lokacija ostavljanja:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Lokacija preuzimanja:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Završetak najma:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Početak najma:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Šifra vozila:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Šifra klijenta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Šifra najma:";
            // 
            // tbVrijediDo
            // 
            this.tbVrijediDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbVrijediDo.Location = new System.Drawing.Point(196, 408);
            this.tbVrijediDo.Margin = new System.Windows.Forms.Padding(4);
            this.tbVrijediDo.Name = "tbVrijediDo";
            this.tbVrijediDo.Size = new System.Drawing.Size(132, 22);
            this.tbVrijediDo.TabIndex = 45;
            // 
            // tbVrijediOd
            // 
            this.tbVrijediOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbVrijediOd.Location = new System.Drawing.Point(196, 372);
            this.tbVrijediOd.Margin = new System.Windows.Forms.Padding(4);
            this.tbVrijediOd.Name = "tbVrijediOd";
            this.tbVrijediOd.Size = new System.Drawing.Size(132, 22);
            this.tbVrijediOd.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 412);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Najam vrijedi do:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 376);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Najam vrijedi od:";
            // 
            // frmNajam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 653);
            this.Controls.Add(this.tbVrijediDo);
            this.Controls.Add(this.tbVrijediOd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvNajmovi);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.tbLokacijaOstavljanja);
            this.Controls.Add(this.tbLokacijaPreuzimanja);
            this.Controls.Add(this.tbZavrsetak);
            this.Controls.Add(this.tbPocetak);
            this.Controls.Add(this.tbIDvozila);
            this.Controls.Add(this.tbIDklijenta);
            this.Controls.Add(this.tbIDnajma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNajam";
            this.Text = "Najmovi";
            this.Load += new System.EventHandler(this.frmNajam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNajmovi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.TextBox tbLokacijaOstavljanja;
        private System.Windows.Forms.TextBox tbLokacijaPreuzimanja;
        private System.Windows.Forms.TextBox tbZavrsetak;
        private System.Windows.Forms.TextBox tbPocetak;
        private System.Windows.Forms.TextBox tbIDvozila;
        private System.Windows.Forms.TextBox tbIDklijenta;
        private System.Windows.Forms.TextBox tbIDnajma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVrijediDo;
        private System.Windows.Forms.TextBox tbVrijediOd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}