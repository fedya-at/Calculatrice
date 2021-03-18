using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculatrice;

namespace WinFormCalcul
{
    public partial class FrmCalculeBasic : Form
    {
        public FrmCalculeBasic()
        {
            InitializeComponent();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Voulez vous quitter?", "Confirmation", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
                Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Acceuil().Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var valeur1 = int.Parse(txtValeur1.Text);
            var valeur2 = int.Parse(txtValeur2.Text);
            result.Text = CalculBasic.Addition(valeur1, valeur2).ToString();

        }

        private void btnSous_Click(object sender, EventArgs e)
        {
            var valeur1 = int.Parse(txtValeur1.Text);
            var valeur2 = int.Parse(txtValeur2.Text);
            result.Text = CalculBasic.Soustraction(valeur1, valeur2).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            var valeur1 = int.Parse(txtValeur1.Text);
            var valeur2 = int.Parse(txtValeur2.Text);
            result.Text = CalculBasic.Multiplication(valeur1, valeur2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            var valeur1 = int.Parse(txtValeur1.Text);
            var valeur2 = int.Parse(txtValeur2.Text);
            result.Text = CalculBasic.Division(valeur1, valeur2).ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            var valeur1 = int.Parse(txtValeur1.Text);
            var valeur2 = int.Parse(txtValeur2.Text);
            result.Text = CalculBasic.Mod(valeur1, valeur2).ToString();
        }
    }
}
