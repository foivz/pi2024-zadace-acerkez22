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
    public partial class FrmDodajPark : Form
    {
        public FrmDodajPark()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_acerkez22_DB", "PI2324_acerkez22_User", "7P-ZyF0{");
            VozniParkRepository.DodajVozniPark(txtProizvodjac.Text, int.Parse(txtBrojSjedala.Text), int.Parse(txtKilometraza.Text), txtRegistracija.Text);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
