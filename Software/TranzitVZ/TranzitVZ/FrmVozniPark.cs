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
    public partial class FrmVozniPark : Form
    {
        public FrmVozniPark()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOdabir frmOdabir = new FrmOdabir();
            Hide();
            frmOdabir.ShowDialog();
            Close();
        }

        private void FrmVozniPark_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_acerkez22_DB", "PI2324_acerkez22_User", "7P-ZyF0{");
            ShowVozniPark();
        }

        private void ShowVozniPark()
        {
            var vozniParks = VozniParkRepository.GetVozniParks();
            dgvVozniPark.DataSource = vozniParks;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajPark frmDodajPark = new FrmDodajPark();
            frmDodajPark.ShowDialog();
            ShowVozniPark();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            VozniPark odabran = dgvVozniPark.CurrentRow.DataBoundItem as VozniPark;

            FrmIzmijeniPark frmIzmijeniPark = new FrmIzmijeniPark(odabran);
            frmIzmijeniPark.ShowDialog();
            ShowVozniPark();
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            string trazi = txtTrazi.Text.Trim();

            if (!string.IsNullOrWhiteSpace(trazi))
            {
                var vozniPark = VozniParkRepository.SearchVozniPark(trazi);
                dgvVozniPark.DataSource = vozniPark;
            }
            else
            {
                ShowVozniPark();
            }
        }
    }
}
