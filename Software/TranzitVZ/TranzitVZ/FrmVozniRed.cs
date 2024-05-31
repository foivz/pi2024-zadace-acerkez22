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
    public partial class FrmVozniRed : Form
    {
        public FrmVozniRed()
        {
            InitializeComponent();
        }

        private void FrmVozniRed_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_acerkez22_DB", "PI2324_acerkez22_User", "7P-ZyF0{");
            ShowVozniRed();
        }
        private void ShowVozniRed()
        {
            var vozniReds = VozniRedRepository.GetVozniReds();
            dgvVozniRed.DataSource = vozniReds;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FrmOdabir frmOdabir = new FrmOdabir();
            Hide();
            frmOdabir.ShowDialog();
            Close();
        }
    }
}
