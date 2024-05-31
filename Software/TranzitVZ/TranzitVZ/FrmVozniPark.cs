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
    }
}
