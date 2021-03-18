using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculWinForm
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CalculBasic().Show();
            this.Hide();
        }

        private void btnCalculAvance_Click(object sender, EventArgs e)
        {
            new C().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Voulez vous quitter?","Confirmation", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
                Application.Exit();
        }
    }
}
