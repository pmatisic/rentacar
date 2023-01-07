namespace RentACar
{
    partial class frmKategorija
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Naziv kategorije:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(708, 394);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 13;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(205, 394);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.btnAzuriraj.TabIndex = 12;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(313, 394);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreiraj.Location = new System.Drawing.Point(97, 394);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(100, 28);
            this.btnKreiraj.TabIndex = 10;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKategorije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategorije.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Location = new System.Drawing.Point(186, 31);
            this.dgvKategorije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.RowHeadersWidth = 51;
            this.dgvKategorije.Size = new System.Drawing.Size(536, 258);
            this.dgvKategorije.TabIndex = 9;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNaziv.Location = new System.Drawing.Point(450, 348);
            this.tbNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(132, 22);
            this.tbNaziv.TabIndex = 17;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(450, 318);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(132, 22);
            this.tbID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Šifra kategorije:";
            // 
            // frmKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 453);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvKategorije);
            this.Name = "frmKategorija";
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.frmKategorija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
    }
}