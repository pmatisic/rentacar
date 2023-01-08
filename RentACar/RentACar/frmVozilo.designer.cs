namespace RentACar
{
    partial class frmVozilo
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
            this.tbDatumPregleda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.tbPrikazi = new System.Windows.Forms.Button();
            this.tbAzuriraj = new System.Windows.Forms.Button();
            this.tbObrisi = new System.Windows.Forms.Button();
            this.tbKreiraj = new System.Windows.Forms.Button();
            this.tbBoja = new System.Windows.Forms.TextBox();
            this.tbKilometraza = new System.Windows.Forms.TextBox();
            this.tbDatumProizvodnje = new System.Windows.Forms.TextBox();
            this.tbIDlokacije = new System.Windows.Forms.TextBox();
            this.tbIDkategorije = new System.Windows.Forms.TextBox();
            this.tbIDmodela = new System.Windows.Forms.TextBox();
            this.tbRegistracijskeOznake = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDatumPregleda
            // 
            this.tbDatumPregleda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDatumPregleda.Location = new System.Drawing.Point(199, 388);
            this.tbDatumPregleda.Margin = new System.Windows.Forms.Padding(4);
            this.tbDatumPregleda.Name = "tbDatumPregleda";
            this.tbDatumPregleda.Size = new System.Drawing.Size(132, 22);
            this.tbDatumPregleda.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 392);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Datum teh. pregleda:";
            // 
            // dgvVozila
            // 
            this.dgvVozila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozila.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Location = new System.Drawing.Point(376, 46);
            this.dgvVozila.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.RowHeadersWidth = 51;
            this.dgvVozila.Size = new System.Drawing.Size(925, 486);
            this.dgvVozila.TabIndex = 64;
            // 
            // tbPrikazi
            // 
            this.tbPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrikazi.Location = new System.Drawing.Point(231, 504);
            this.tbPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrikazi.Name = "tbPrikazi";
            this.tbPrikazi.Size = new System.Drawing.Size(100, 28);
            this.tbPrikazi.TabIndex = 63;
            this.tbPrikazi.Text = "Prikaži";
            this.tbPrikazi.UseVisualStyleBackColor = true;
            this.tbPrikazi.Click += new System.EventHandler(this.tbPrikazi_Click);
            // 
            // tbAzuriraj
            // 
            this.tbAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAzuriraj.Location = new System.Drawing.Point(46, 504);
            this.tbAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.tbAzuriraj.Name = "tbAzuriraj";
            this.tbAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.tbAzuriraj.TabIndex = 62;
            this.tbAzuriraj.Text = "Ažuriraj";
            this.tbAzuriraj.UseVisualStyleBackColor = true;
            this.tbAzuriraj.Click += new System.EventHandler(this.tbAzuriraj_Click);
            // 
            // tbObrisi
            // 
            this.tbObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbObrisi.Location = new System.Drawing.Point(231, 435);
            this.tbObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.tbObrisi.Name = "tbObrisi";
            this.tbObrisi.Size = new System.Drawing.Size(100, 28);
            this.tbObrisi.TabIndex = 61;
            this.tbObrisi.Text = "Obriši";
            this.tbObrisi.UseVisualStyleBackColor = true;
            this.tbObrisi.Click += new System.EventHandler(this.tbObrisi_Click);
            // 
            // tbKreiraj
            // 
            this.tbKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKreiraj.Location = new System.Drawing.Point(46, 435);
            this.tbKreiraj.Margin = new System.Windows.Forms.Padding(4);
            this.tbKreiraj.Name = "tbKreiraj";
            this.tbKreiraj.Size = new System.Drawing.Size(100, 28);
            this.tbKreiraj.TabIndex = 60;
            this.tbKreiraj.Text = "Kreiraj";
            this.tbKreiraj.UseVisualStyleBackColor = true;
            this.tbKreiraj.Click += new System.EventHandler(this.tbKreiraj_Click);
            // 
            // tbBoja
            // 
            this.tbBoja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBoja.Location = new System.Drawing.Point(199, 344);
            this.tbBoja.Margin = new System.Windows.Forms.Padding(4);
            this.tbBoja.Name = "tbBoja";
            this.tbBoja.Size = new System.Drawing.Size(132, 22);
            this.tbBoja.TabIndex = 59;
            // 
            // tbKilometraza
            // 
            this.tbKilometraza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKilometraza.Location = new System.Drawing.Point(199, 300);
            this.tbKilometraza.Margin = new System.Windows.Forms.Padding(4);
            this.tbKilometraza.Name = "tbKilometraza";
            this.tbKilometraza.Size = new System.Drawing.Size(132, 22);
            this.tbKilometraza.TabIndex = 58;
            // 
            // tbDatumProizvodnje
            // 
            this.tbDatumProizvodnje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDatumProizvodnje.Location = new System.Drawing.Point(199, 260);
            this.tbDatumProizvodnje.Margin = new System.Windows.Forms.Padding(4);
            this.tbDatumProizvodnje.Name = "tbDatumProizvodnje";
            this.tbDatumProizvodnje.Size = new System.Drawing.Size(132, 22);
            this.tbDatumProizvodnje.TabIndex = 57;
            // 
            // tbIDlokacije
            // 
            this.tbIDlokacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDlokacije.Location = new System.Drawing.Point(199, 219);
            this.tbIDlokacije.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDlokacije.Name = "tbIDlokacije";
            this.tbIDlokacije.Size = new System.Drawing.Size(132, 22);
            this.tbIDlokacije.TabIndex = 56;
            // 
            // tbIDkategorije
            // 
            this.tbIDkategorije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDkategorije.Location = new System.Drawing.Point(199, 177);
            this.tbIDkategorije.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDkategorije.Name = "tbIDkategorije";
            this.tbIDkategorije.Size = new System.Drawing.Size(132, 22);
            this.tbIDkategorije.TabIndex = 55;
            // 
            // tbIDmodela
            // 
            this.tbIDmodela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDmodela.Location = new System.Drawing.Point(199, 130);
            this.tbIDmodela.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDmodela.Name = "tbIDmodela";
            this.tbIDmodela.Size = new System.Drawing.Size(132, 22);
            this.tbIDmodela.TabIndex = 54;
            // 
            // tbRegistracijskeOznake
            // 
            this.tbRegistracijskeOznake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRegistracijskeOznake.Location = new System.Drawing.Point(199, 87);
            this.tbRegistracijskeOznake.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegistracijskeOznake.Name = "tbRegistracijskeOznake";
            this.tbRegistracijskeOznake.Size = new System.Drawing.Size(132, 22);
            this.tbRegistracijskeOznake.TabIndex = 53;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(199, 46);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(132, 22);
            this.tbID.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Boja:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Kilometraža:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Datum proizvodnje:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Šifra lokacije vozila:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Šifra kategorije:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Šifra modela vozila:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Registracijske oznake:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Šifra vozila:";
            // 
            // frmVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 578);
            this.Controls.Add(this.tbDatumPregleda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.tbPrikazi);
            this.Controls.Add(this.tbAzuriraj);
            this.Controls.Add(this.tbObrisi);
            this.Controls.Add(this.tbKreiraj);
            this.Controls.Add(this.tbBoja);
            this.Controls.Add(this.tbKilometraza);
            this.Controls.Add(this.tbDatumProizvodnje);
            this.Controls.Add(this.tbIDlokacije);
            this.Controls.Add(this.tbIDkategorije);
            this.Controls.Add(this.tbIDmodela);
            this.Controls.Add(this.tbRegistracijskeOznake);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVozilo";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.frmVozilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDatumPregleda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.Button tbPrikazi;
        private System.Windows.Forms.Button tbAzuriraj;
        private System.Windows.Forms.Button tbObrisi;
        private System.Windows.Forms.Button tbKreiraj;
        private System.Windows.Forms.TextBox tbBoja;
        private System.Windows.Forms.TextBox tbKilometraza;
        private System.Windows.Forms.TextBox tbDatumProizvodnje;
        private System.Windows.Forms.TextBox tbIDlokacije;
        private System.Windows.Forms.TextBox tbIDkategorije;
        private System.Windows.Forms.TextBox tbIDmodela;
        private System.Windows.Forms.TextBox tbRegistracijskeOznake;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}