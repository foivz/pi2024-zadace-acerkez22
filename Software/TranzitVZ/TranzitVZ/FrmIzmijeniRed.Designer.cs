namespace TranzitVZ
{
    partial class FrmIzmijeniRed
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtNazivStanice = new System.Windows.Forms.TextBox();
            this.txtDodatniOpis = new System.Windows.Forms.TextBox();
            this.txtVrijemePolaska = new System.Windows.Forms.TextBox();
            this.lblNazivStanice = new System.Windows.Forms.Label();
            this.lblDodatniOpis = new System.Windows.Forms.Label();
            this.lblVrijemePolaska = new System.Windows.Forms.Label();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(23, 297);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(81, 36);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(110, 297);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(81, 36);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtNazivStanice
            // 
            this.txtNazivStanice.Location = new System.Drawing.Point(23, 38);
            this.txtNazivStanice.Name = "txtNazivStanice";
            this.txtNazivStanice.Size = new System.Drawing.Size(246, 20);
            this.txtNazivStanice.TabIndex = 2;
            // 
            // txtDodatniOpis
            // 
            this.txtDodatniOpis.Location = new System.Drawing.Point(23, 88);
            this.txtDodatniOpis.Multiline = true;
            this.txtDodatniOpis.Name = "txtDodatniOpis";
            this.txtDodatniOpis.Size = new System.Drawing.Size(246, 103);
            this.txtDodatniOpis.TabIndex = 3;
            // 
            // txtVrijemePolaska
            // 
            this.txtVrijemePolaska.Location = new System.Drawing.Point(23, 223);
            this.txtVrijemePolaska.Name = "txtVrijemePolaska";
            this.txtVrijemePolaska.Size = new System.Drawing.Size(81, 20);
            this.txtVrijemePolaska.TabIndex = 4;
            // 
            // lblNazivStanice
            // 
            this.lblNazivStanice.AutoSize = true;
            this.lblNazivStanice.Location = new System.Drawing.Point(20, 22);
            this.lblNazivStanice.Name = "lblNazivStanice";
            this.lblNazivStanice.Size = new System.Drawing.Size(74, 13);
            this.lblNazivStanice.TabIndex = 5;
            this.lblNazivStanice.Text = "Naziv stanice:";
            // 
            // lblDodatniOpis
            // 
            this.lblDodatniOpis.AutoSize = true;
            this.lblDodatniOpis.Location = new System.Drawing.Point(20, 72);
            this.lblDodatniOpis.Name = "lblDodatniOpis";
            this.lblDodatniOpis.Size = new System.Drawing.Size(69, 13);
            this.lblDodatniOpis.TabIndex = 6;
            this.lblDodatniOpis.Text = "Dodatni opis:";
            // 
            // lblVrijemePolaska
            // 
            this.lblVrijemePolaska.AutoSize = true;
            this.lblVrijemePolaska.Location = new System.Drawing.Point(20, 207);
            this.lblVrijemePolaska.Name = "lblVrijemePolaska";
            this.lblVrijemePolaska.Size = new System.Drawing.Size(84, 13);
            this.lblVrijemePolaska.TabIndex = 7;
            this.lblVrijemePolaska.Text = "Vrijeme polaska:";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(204, 297);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(81, 36);
            this.btnBrisi.TabIndex = 8;
            this.btnBrisi.Text = "Izbriši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // FrmIzmijeniRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 372);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.lblVrijemePolaska);
            this.Controls.Add(this.lblDodatniOpis);
            this.Controls.Add(this.lblNazivStanice);
            this.Controls.Add(this.txtVrijemePolaska);
            this.Controls.Add(this.txtDodatniOpis);
            this.Controls.Add(this.txtNazivStanice);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIzmijeniRed";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena podataka";
            this.Load += new System.EventHandler(this.FrmIzmijeniRed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtNazivStanice;
        private System.Windows.Forms.TextBox txtDodatniOpis;
        private System.Windows.Forms.TextBox txtVrijemePolaska;
        private System.Windows.Forms.Label lblNazivStanice;
        private System.Windows.Forms.Label lblDodatniOpis;
        private System.Windows.Forms.Label lblVrijemePolaska;
        private System.Windows.Forms.Button btnBrisi;
    }
}