using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaWinFormI02;

namespace WindowsFormI02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Pais.Items.Add("Argentina");
            listBox_Pais.Items.Add("Chile");
            listBox_Pais.Items.Add("Uruguay");
        }

        private void button_Ingreso_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_Nombre.Text;
            string direccion = this.txt_Direccion.Text;
            int edad = (int)this.num_Edad.Value;
            string[] cursos = new string[3];
            string genero;
            string pais = listBox_Pais.Text;

            if(rb_Masc.Checked)
            {
                genero = this.rb_Masc.Text;
            }
            else if(rb_Fem.Checked)
            {
                genero = this.rb_Fem.Text;
            }
            else
            {
                genero = this.rb_NoBin.Text;
            }

            if (checkBox_C.Checked)
            {
                cursos[0] = this.checkBox_C.Text;               
            }

            if(checkBox_Cmas.Checked)
            {
                cursos[1]= this.checkBox_Cmas.Text;
            }

            if(checkBox_Java.Checked)
            {
                cursos[2]= this.checkBox_Java.Text;
            }

            Ingresante ingresante1 = new Ingresante(cursos, direccion, edad, genero, nombre, pais);

            MessageBox.Show(ingresante1.Mostrar());
        }
    }
}
