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
    public partial class Saludo : Form
    {
        private string nombre;
        private string apellido;
        private string materiaFavorita;
        public Saludo()
        {
            InitializeComponent();
        }

        public Saludo(string nomb, string ape):this()
        {
            this.nombre = nomb;
            this.apellido = ape;
        }

       public Saludo(string nomb, string ape,string materiaFav):this(nomb, ape)
        {
            this.materiaFavorita = materiaFav;
        }

        public void Saludo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Saludo_Load(object sender, EventArgs e)
        {
            lb_SaludoSoy.Text = "Soy " + nombre + " " + apellido + " y mi materia favorita es " + materiaFavorita;
        }
    }
}
