using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaWinssI03;

namespace WindowsFormI03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCotDolar_Leave(object sender, EventArgs e)
        {
            txtCotDolar.ReadOnly = true;
        }

        private void btLock_Click(object sender, EventArgs e)
        {
            int flagEntro = 1;
            if(flagEntro == 1)
            {
                txtCotDolar.Enabled = true;
                txtCotEuro.Enabled = true;
                txtCotPeso.Enabled = true;
                flagEntro = 0;
            }
            else
            {
                txtCotDolar.Enabled = false;
                txtCotEuro.Enabled = false;
                txtCotPeso.Enabled = false;
            }
            
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            double cotEuro = 0;
            double ingresoEuro=0;
            if(double.TryParse(txtIngresoEuro.Text, out ingresoEuro) && double.TryParse(txtCotEuro.Text,out cotEuro) )
            {

                Euro euro1 = ingresoEuro;
                Euro.SetCotizacion(cotEuro);

                txtEuroAEuro.Text = euro1.GetCantidad().ToString();
                txtEuroADolar.Text = ((Dolar)euro1).GetCantidad().ToString();
                txtEuroAPeso.Text = ((Pesos)euro1).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Error, debe llenar la cotizacion del Euro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            double ingresoDolar = 0;
            if (double.TryParse(txtIngresoDolar.Text, out ingresoDolar) && double.TryParse(txtCotDolar.Text, out _))
            {
                Dolar dolar1 = ingresoDolar;

                txtDolarAEuro.Text = ((Euro)dolar1).GetCantidad().ToString();
                txtDolarADolar.Text = dolar1.GetCantidad().ToString();
                txtDolarAPeso.Text = ((Pesos)dolar1).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Error, debe llenar la cotizacion del Dolar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            double cotPeso = 0;
            double ingresoPeso = 0;
            if (double.TryParse(txtIngresoPeso.Text, out ingresoPeso) && double.TryParse(txtCotDolar.Text, out cotPeso))
            {
                Pesos peso1 = ingresoPeso;
                Pesos.SetCotizacion(cotPeso);

                txtPesoAPeso.Text = peso1.GetCantidad().ToString();
                txtPesoAEuro.Text = ((Euro)peso1).GetCantidad().ToString();
                txtPesoADolar.Text = ((Dolar)peso1).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Error, debe llenar la cotizacion del Peso","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
