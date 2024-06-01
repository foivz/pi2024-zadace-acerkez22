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
using TranzitVZ.Repositories;
using TranzitVZ.Models;
namespace TranzitVZ
{
    public partial class FrmIzmijeniRed : Form
    {
        private VozniRed odabran;
        public FrmIzmijeniRed(VozniRed odabran)
        {
            InitializeComponent();
            this.odabran = odabran;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_acerkez22_DB", "PI2324_acerkez22_User", "7P-ZyF0{");
            VozniRedRepository.PromijeniVozniRed(txtNazivStanice.Text, txtDodatniOpis.Text, txtVrijemePolaska.Text, int.Parse(odabran.BrojStanice.ToString()));
            Close();
        }

        private void FrmIzmijeniRed_Load(object sender, EventArgs e)
        {
            var vozniRed = VozniRedRepository.GetVozniRed(int.Parse(odabran.BrojStanice.ToString()));
            txtNazivStanice.Text = odabran.NazivStanice.ToString().Trim();
            txtDodatniOpis.Text = odabran.DodatniOpis.ToString().Trim();
            txtVrijemePolaska.Text = odabran.VrijemePolaska.ToString().Trim();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            DialogResult prozor = MessageBox.Show("Sigurno želite obrisati označeni red?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(prozor == DialogResult.Yes)
            {
                VozniRedRepository.BrisiVozniRed(int.Parse(odabran.BrojStanice.ToString()));
                MessageBox.Show("Brisanje uspješno.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
