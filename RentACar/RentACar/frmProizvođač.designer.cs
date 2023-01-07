namespace RentACar
{
    partial class frmProizvođač
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
            this.dgvProizvodaci = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvodaci
            // 
            this.dgvProizvodaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProizvodaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodaci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProizvodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodaci.Location = new System.Drawing.Point(419, 137);
            this.dgvProizvodaci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProizvodaci.Name = "dgvProizvodaci";
            this.dgvProizvodaci.RowHeadersWidth = 51;
            this.dgvProizvodaci.Size = new System.Drawing.Size(488, 229);
            this.dgvProizvodaci.TabIndex = 26;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(262, 338);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 25;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(101, 338);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.btnAzuriraj.TabIndex = 24;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(262, 263);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 23;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreiraj.Location = new System.Drawing.Point(101, 263);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(100, 28);
            this.btnKreiraj.TabIndex = 22;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNaziv.Location = new System.Drawing.Point(228, 190);
            this.tbNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(132, 22);
            this.tbNaziv.TabIndex = 21;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(228, 137);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(132, 22);
            this.tbID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Šifra proizvođača:";
            // 
            // frmProizvođač
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 503);
            this.Controls.Add(this.dgvProizvodaci);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvođač";
            this.Text = "Proizvođači";
            this.Load += new System.EventHandler(this.frmProizvođač_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodaci;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}