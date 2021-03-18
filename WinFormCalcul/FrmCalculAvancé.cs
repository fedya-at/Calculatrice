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
    public partial class FrmCalculAvancé : Form
    {
        public FrmCalculAvancé()
        {
            InitializeComponent();
        }

        private void BtnFact_Click(object sender, EventArgs e)
        {
            var valeur1 = int.Parse(txtValeur1.Text);
            var valeur2 = int.Parse(txtValeur2.Text);
            result.Text = CalculAvancé.Factoriel(valeur1, valeur2).ToString();
        }
    }
}
