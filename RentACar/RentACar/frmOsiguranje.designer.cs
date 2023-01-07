namespace RentACar
{
    partial class frmOsiguranje
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
            this.dgvOsiguranja = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.tbPolica = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsiguranja
            // 
            this.dgvOsiguranja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOsiguranja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsiguranja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOsiguranja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsiguranja.Location = new System.Drawing.Point(361, 150);
            this.dgvOsiguranja.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOsiguranja.Name = "dgvOsiguranja";
            this.dgvOsiguranja.RowHeadersWidth = 51;
            this.dgvOsiguranja.Size = new System.Drawing.Size(769, 276);
            this.dgvOsiguranja.TabIndex = 25;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(209, 397);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 24;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(64, 397);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.btnAzuriraj.TabIndex = 23;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(209, 338);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreiraj.Location = new System.Drawing.Point(64, 338);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(100, 28);
            this.btnKreiraj.TabIndex = 21;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // tbPolica
            // 
            this.tbPolica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPolica.Location = new System.Drawing.Point(176, 269);
            this.tbPolica.Margin = new System.Windows.Forms.Padding(4);
            this.tbPolica.Name = "tbPolica";
            this.tbPolica.Size = new System.Drawing.Size(132, 22);
            this.tbPolica.TabIndex = 20;
            // 
            // tbOpis
            // 
            this.tbOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOpis.Location = new System.Drawing.Point(176, 228);
            this.tbOpis.Margin = new System.Windows.Forms.Padding(4);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(132, 22);
            this.tbOpis.TabIndex = 19;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNaziv.Location = new System.Drawing.Point(176, 189);
            this.tbNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(132, 22);
            this.tbNaziv.TabIndex = 18;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(176, 150);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(132, 22);
            this.tbID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Polica:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Šifra osiguranja:";
            // 
            // frmOsiguranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 576);
            this.Controls.Add(this.dgvOsiguranja);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.tbPolica);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOsiguranje";
            this.Text = "Osiguranja";
            this.Load += new System.EventHandler(this.frmOsiguranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOsiguranja;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox tbPolica;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}