namespace RentACar
{
    partial class frmLokacija
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
            this.dgvLokacije = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLokacije
            // 
            this.dgvLokacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLokacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLokacije.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLokacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokacije.Location = new System.Drawing.Point(317, 144);
            this.dgvLokacije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLokacije.Name = "dgvLokacije";
            this.dgvLokacije.RowHeadersWidth = 51;
            this.dgvLokacije.Size = new System.Drawing.Size(607, 265);
            this.dgvLokacije.TabIndex = 32;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(186, 380);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 31;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(63, 380);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.btnAzuriraj.TabIndex = 30;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(186, 321);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 29;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreiraj.Location = new System.Drawing.Point(63, 321);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(100, 28);
            this.btnKreiraj.TabIndex = 28;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Grad:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Adresa:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Šifra lokacije:";
            // 
            // tbGrad
            // 
            this.tbGrad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGrad.Location = new System.Drawing.Point(154, 254);
            this.tbGrad.Margin = new System.Windows.Forms.Padding(4);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(132, 22);
            this.tbGrad.TabIndex = 24;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAdresa.Location = new System.Drawing.Point(154, 198);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(132, 22);
            this.tbAdresa.TabIndex = 23;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(154, 144);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(132, 22);
            this.tbID.TabIndex = 22;
            // 
            // frmLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvLokacije);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbID);
            this.Name = "frmLokacija";
            this.Text = "Lokacije";
            this.Load += new System.EventHandler(this.frmLokacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLokacije;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbID;
    }
}