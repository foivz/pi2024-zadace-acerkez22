using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranzitVZ
{
    public partial class FrmOdabir : Form
    {
        public FrmOdabir()
        {
            InitializeComponent();
        }

        private void btnVozniRed_Click(object sender, EventArgs e)
        {
            FrmVozniRed frmVozniRed = new FrmVozniRed();
            Hide();
            frmVozniRed.ShowDialog();
            Close();
        }

        private void btnVozniPark_Click(object sender, EventArgs e)
        {
            FrmVozniPark frmVozniPark = new FrmVozniPark();
            Hide();
            frmVozniPark.ShowDialog();
            Close();
        }
    }
}
