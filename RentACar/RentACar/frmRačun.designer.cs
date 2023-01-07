namespace RentACar
{
    partial class frmRačun
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
            this.tbIskoristeno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.tbIznos = new System.Windows.Forms.TextBox();
            this.tbIDNacina = new System.Windows.Forms.TextBox();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.tbIDNajma = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIskoristeno
            // 
            this.tbIskoristeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIskoristeno.Location = new System.Drawing.Point(177, 317);
            this.tbIskoristeno.Margin = new System.Windows.Forms.Padding(4);
            this.tbIskoristeno.Name = "tbIskoristeno";
            this.tbIskoristeno.Size = new System.Drawing.Size(132, 22);
            this.tbIskoristeno.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Iskorišten kupon:";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(344, 118);
            this.dgvRacuni.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 51;
            this.dgvRacuni.Size = new System.Drawing.Size(832, 341);
            this.dgvRacuni.TabIndex = 46;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(209, 431);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 45;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(55, 431);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.btnAzuriraj.TabIndex = 44;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(209, 371);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 43;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreiraj.Location = new System.Drawing.Point(55, 371);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(100, 28);
            this.btnKreiraj.TabIndex = 42;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // tbIznos
            // 
            this.tbIznos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIznos.Location = new System.Drawing.Point(177, 273);
            this.tbIznos.Margin = new System.Windows.Forms.Padding(4);
            this.tbIznos.Name = "tbIznos";
            this.tbIznos.Size = new System.Drawing.Size(132, 22);
            this.tbIznos.TabIndex = 41;
            // 
            // tbIDNacina
            // 
            this.tbIDNacina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDNacina.Location = new System.Drawing.Point(177, 236);
            this.tbIDNacina.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDNacina.Name = "tbIDNacina";
            this.tbIDNacina.Size = new System.Drawing.Size(132, 22);
            this.tbIDNacina.TabIndex = 40;
            // 
            // tbDatum
            // 
            this.tbDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDatum.Location = new System.Drawing.Point(177, 195);
            this.tbDatum.Margin = new System.Windows.Forms.Padding(4);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(132, 22);
            this.tbDatum.TabIndex = 39;
            // 
            // tbIDNajma
            // 
            this.tbIDNajma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIDNajma.Location = new System.Drawing.Point(177, 156);
            this.tbIDNajma.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDNajma.Name = "tbIDNajma";
            this.tbIDNajma.Size = new System.Drawing.Size(132, 22);
            this.tbIDNajma.TabIndex = 38;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(177, 118);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(132, 22);
            this.tbID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Iznos:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Način plaćanja:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Datum izdavanja:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Šifra najma:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Šifra računa:";
            // 
            // frmRačun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 577);
            this.Controls.Add(this.tbIskoristeno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.tbIznos);
            this.Controls.Add(this.tbIDNacina);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.tbIDNajma);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRačun";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.frmRačun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIskoristeno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox tbIznos;
        private System.Windows.Forms.TextBox tbIDNacina;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.TextBox tbIDNajma;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}