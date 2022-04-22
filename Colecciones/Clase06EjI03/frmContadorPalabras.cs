using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06EjI03
{
    public partial class FormContPalabras : Form
    {
        public FormContPalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = obtenerContadorPalabras();

            List<KeyValuePair<string, int>> listaAOrdenar = contadorPalabras.ToList();
            listaAOrdenar.Sort(CompararCantidadRepeticiones);
            MostrarLista(listaAOrdenar);
        }
        private void MostrarLista(List<KeyValuePair<string, int>> lista)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if(lista.Count == 0)
            {
                stringBuilder.AppendLine("No se ingresaron palabras.");
            }
            else
            {
                for (int i = 0; i < 3 && i < lista.Count; i++) // agregp a lista.count por si ingresaron menso de 3 palabras
                {
                    KeyValuePair<string, int> elemento = lista[i];
                    stringBuilder.AppendLine($"Palabra: {elemento.Key} - Cantidad {elemento.Value}");
                }
                /*
                foreach (KeyValuePair<string, int> elemento in lista)
                {
                    stringBuilder.AppendLine($"Palabra: {elemento.Key} - Cantidad {elemento.Value}");
                }*/
            }    
            MessageBox.Show(stringBuilder.ToString(), "Lista");
        }
        
    /*    private void MostrarLista(List<KeyValuePair<string, int>> lista)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, int> elemento in lista)
            {
                stringBuilder.AppendLine($"Palabra: {elemento.Key} - Cantidad {elemento.Value}");
            }
            MessageBox.Show(stringBuilder.ToString(), "Lista");
        } MUESTRO TODO*/
        private int CompararCantidadRepeticiones(KeyValuePair<string, int> elementoUno, 
            KeyValuePair<string, int> elementoDos)
        {
            /*if(elementoUno.Value < elementoDos.Value)
            {
                return -1;
            }

            if(elementoUno.Value < elementoDos.Value)
            {
                return 1;
            }*/
            return elementoDos.Value - elementoUno.Value; // doy vuelta la resta para que sea descendente
            /*return elementoUno.Value - elementoDos.Value; // si el primero es mas grande que el segundo me da + asc
            // si el segundo es mas grande me da negativo 
            // si son iguales da 0*/
        }
        private Dictionary<string, int> obtenerContadorPalabras()
        {
            string textoIngresado = rtxtContadorPalabras.Text;
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            string[] palabras = textoIngresado.Split(separacion, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                    // int contadorRep = contadorPalabras[palabra];
                    // cantidadRep = cantidadRep + 1;
                    // contadorPalarbas[palabra] = cantidadRep;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }
            return contadorPalabras;
        }

        
    }
}
