using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormI01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = this.textBox1.Text ;
            string apellido = this.textBox2.Text;
            string materiaFav = this.cmb_Materias.Text;

            if ( !(String.IsNullOrWhiteSpace(nombre) )  &&  !(String.IsNullOrWhiteSpace(apellido) ) )
            {
                Saludo frmSaludoPrin = new Saludo(nombre,apellido,materiaFav);

                frmSaludoPrin.ShowDialog();

                
                //this.Hide();
            }
            else
            {
                if (String.IsNullOrWhiteSpace(nombre) && String.IsNullOrWhiteSpace(apellido))
                {
                    MessageBox.Show("Se deben completar los siguientes campos:\nNombre\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrWhiteSpace(nombre) )
                {
                    MessageBox.Show("Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Materias.Items.Add("Programación I");
            cmb_Materias.Items.Add("Laboratorio de Computación I");
            cmb_Materias.Items.Add("Sistema de procesamiento de datos");
            cmb_Materias.Items.Add("Inglés I");
            cmb_Materias.Items.Add("Matemática");
            cmb_Materias.Items.Add("Programación II");
            cmb_Materias.Items.Add("Laboratorio de Computación II");
            cmb_Materias.Items.Add("Inglés II");
            cmb_Materias.Items.Add("Metodología de la investigación");
            cmb_Materias.Items.Add("Arquitectura y sistemas operativos");
            cmb_Materias.Items.Add("Estadística");

            cmb_Materias.SelectedIndex = 0;
        }
    }
}
