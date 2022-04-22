using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaWinFormI05;

namespace WindowsFormI05
{
    public partial class frmConversorNumerico : Form
    {
        public frmConversorNumerico()
        {
            InitializeComponent();
        }

        private void btnBinDec_Click(object sender, EventArgs e)
        {
            NumeroBinario numBin = txtIngresoBinADec.Text;
            double numDec = ((NumeroDecimal)numBin).MostrarDec;
            txtBinADec.Text = numDec.ToString();
        }

        private void btnDecBin_Click(object sender, EventArgs e)
        {
            NumeroDecimal numDec = double.Parse(txtIngresoDecABin.Text);
            string numBin = ((NumeroBinario)numDec).MostrarBin;
            txtDecABin.Text = numBin;
        }
    }
}
