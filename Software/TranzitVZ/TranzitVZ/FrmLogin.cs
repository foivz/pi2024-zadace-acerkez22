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
    public partial class FrmLogin : Form
    {
        string username = "zaposlenik";
        string password = "test";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtUsername.Text == "")
            {
                MessageBox.Show("Unesite podatke za prijavu.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unešena.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    FrmOdabir frmOdabir = new FrmOdabir();
                    Hide();
                    frmOdabir.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
