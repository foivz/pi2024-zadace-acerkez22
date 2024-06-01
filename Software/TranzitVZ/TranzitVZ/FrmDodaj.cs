using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranzitVZ.Models;
using TranzitVZ.Repositories;

namespace TranzitVZ
{
    public partial class FrmDodaj : Form
    {
        public event EventHandler Osvjezi;
        public FrmDodaj()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_acerkez22_DB", "PI2324_acerkez22_User", "7P-ZyF0{");
            VozniRedRepository.DodajVozniRed(txtNazivStanice.Text, txtDodatniOpis.Text, txtVrijemePolaska.Text);
            Osvjezi?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
