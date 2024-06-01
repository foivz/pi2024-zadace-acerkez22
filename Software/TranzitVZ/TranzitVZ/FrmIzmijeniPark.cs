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
    public partial class FrmIzmijeniPark : Form
    {
        private VozniPark odabran;
        public FrmIzmijeniPark(VozniPark odabran)
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
            VozniParkRepository.PromijeniVozniPark(txtProizvodjac.Text, int.Parse(txtBrojSjedala.Text), int.Parse(txtKilometraza.Text), txtRegistracija.Text, int.Parse(odabran.BrojAutobusa.ToString()));
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            DialogResult prozor = MessageBox.Show("Sigurno želite obrisati označeni red?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (prozor == DialogResult.Yes)
            {
                VozniParkRepository.BrisiVozniPark(int.Parse(odabran.BrojAutobusa.ToString()));
                MessageBox.Show("Brisanje uspješno.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void FrmIzmijeniPark_Load(object sender, EventArgs e)
        {
            var vozniPark = VozniParkRepository.GetVozniPark(int.Parse(odabran.BrojAutobusa.ToString()));
            txtProizvodjac.Text = odabran.Proizvodjac.ToString().Trim();
            txtBrojSjedala.Text = odabran.BrojSjedala.ToString().Trim();
            txtKilometraza.Text = odabran.Kilometraza.ToString().Trim();
            txtRegistracija.Text = odabran.Registracija.ToString().Trim();
        }
    }
}
