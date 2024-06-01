namespace TranzitVZ
{
    partial class FrmDodajPark
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
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtBrojSjedala = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblBrojSjedala = new System.Windows.Forms.Label();
            this.lblKilometraza = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(23, 38);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(246, 20);
            this.txtProizvodjac.TabIndex = 0;
            // 
            // txtBrojSjedala
            // 
            this.txtBrojSjedala.Location = new System.Drawing.Point(23, 88);
            this.txtBrojSjedala.Name = "txtBrojSjedala";
            this.txtBrojSjedala.Size = new System.Drawing.Size(100, 20);
            this.txtBrojSjedala.TabIndex = 1;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(23, 142);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(100, 20);
            this.txtKilometraza.TabIndex = 2;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(23, 194);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(246, 20);
            this.txtRegistracija.TabIndex = 3;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(23, 244);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(81, 36);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(110, 244);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(81, 36);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(20, 22);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(64, 13);
            this.lblProizvodjac.TabIndex = 7;
            this.lblProizvodjac.Text = "Proizvođač:";
            // 
            // lblBrojSjedala
            // 
            this.lblBrojSjedala.AutoSize = true;
            this.lblBrojSjedala.Location = new System.Drawing.Point(20, 72);
            this.lblBrojSjedala.Name = "lblBrojSjedala";
            this.lblBrojSjedala.Size = new System.Drawing.Size(64, 13);
            this.lblBrojSjedala.TabIndex = 8;
            this.lblBrojSjedala.Text = "Broj sjedala:";
            // 
            // lblKilometraza
            // 
            this.lblKilometraza.AutoSize = true;
            this.lblKilometraza.Location = new System.Drawing.Point(20, 126);
            this.lblKilometraza.Name = "lblKilometraza";
            this.lblKilometraza.Size = new System.Drawing.Size(64, 13);
            this.lblKilometraza.TabIndex = 9;
            this.lblKilometraza.Text = "Kilometraža:";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Location = new System.Drawing.Point(20, 178);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(65, 13);
            this.lblRegistracija.TabIndex = 10;
            this.lblRegistracija.Text = "Registracija:";
            // 
            // FrmDodajPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 372);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.lblKilometraza);
            this.Controls.Add(this.lblBrojSjedala);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtBrojSjedala);
            this.Controls.Add(this.txtProizvodjac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDodajPark";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtBrojSjedala;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblBrojSjedala;
        private System.Windows.Forms.Label lblKilometraza;
        private System.Windows.Forms.Label lblRegistracija;
    }
}