namespace TranzitVZ
{
    partial class FrmOdabir
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
            this.btnVozniRed = new System.Windows.Forms.Button();
            this.btnVozniPark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVozniRed
            // 
            this.btnVozniRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozniRed.Location = new System.Drawing.Point(128, 31);
            this.btnVozniRed.Name = "btnVozniRed";
            this.btnVozniRed.Size = new System.Drawing.Size(162, 72);
            this.btnVozniRed.TabIndex = 0;
            this.btnVozniRed.Text = "Vozni Red";
            this.btnVozniRed.UseVisualStyleBackColor = true;
            this.btnVozniRed.Click += new System.EventHandler(this.btnVozniRed_Click);
            // 
            // btnVozniPark
            // 
            this.btnVozniPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozniPark.Location = new System.Drawing.Point(128, 118);
            this.btnVozniPark.Name = "btnVozniPark";
            this.btnVozniPark.Size = new System.Drawing.Size(162, 74);
            this.btnVozniPark.TabIndex = 1;
            this.btnVozniPark.Text = "Vozni Park";
            this.btnVozniPark.UseVisualStyleBackColor = true;
            this.btnVozniPark.Click += new System.EventHandler(this.btnVozniPark_Click);
            // 
            // FrmOdabir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 230);
            this.Controls.Add(this.btnVozniPark);
            this.Controls.Add(this.btnVozniRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmOdabir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir pregleda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVozniRed;
        private System.Windows.Forms.Button btnVozniPark;
    }
}