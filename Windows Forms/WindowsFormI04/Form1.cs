using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaWinFormI04;

namespace WindowsFormI04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFahrenheit_Click(object sender, EventArgs e)
        {
            double tempFahr;
            if (double.TryParse(txtEntradaFahre.Text, out tempFahr))
            {
                Fahrenheit fahren1 = tempFahr;

                txtFahrAFahr.Text = fahren1.GetGrados().ToString();
                txtFarhACelsius.Text = ((Celsius)fahren1).GetGrados().ToString();
                txtFarhAKelvin.Text = ((Kelvin)fahren1).GetGrados().ToString();
            }
            else
            {
                MessageBox.Show("Error al ingresar la temperatura Fahrenheit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCelsius_Click(object sender, EventArgs e)
        {
            double tempCelsius;
            if (double.TryParse(txtEntradaCelsius.Text, out tempCelsius))
            {
                Celsius celsius1 = tempCelsius;

                txtCelsiusACelsius.Text = celsius1.GetGrados().ToString();
                txtCelsiusAFahr.Text = ((Fahrenheit)celsius1).GetGrados().ToString();
                txtCelsiusAKelvin.Text = ((Kelvin)celsius1).GetGrados().ToString();
            }
            else
            {
                MessageBox.Show("Error al ingresar la temperatura Celsius", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btKelvin_Click(object sender, EventArgs e)
        {
            double tempKelvin;
            if (double.TryParse(txtEntradaKelvin.Text, out tempKelvin))
            {
                Kelvin kelvin1 = tempKelvin;

                txtKelvinAKelvin.Text = kelvin1.GetGrados().ToString();
                txtKelvinAFahr.Text = ((Fahrenheit)kelvin1).GetGrados().ToString();
                txtKelvinACelsius.Text = ((Celsius)kelvin1).GetGrados().ToString();
            }
            else
            {
                MessageBox.Show("Error al ingresar la temperatura Kelvin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
