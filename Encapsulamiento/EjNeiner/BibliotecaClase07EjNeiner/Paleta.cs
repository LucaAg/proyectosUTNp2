using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase07EjNeiner
{
    public class Paleta
    {
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        private Paleta()
        {
            temperas = new List<Tempera>();
        }

        private Paleta(int cantidadMax) : this()
        {
            // temperas = new List<Tempera>();
            this.cantidadMaximaColores = cantidadMax;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            StringBuilder datosPaleta = new StringBuilder("Datos paleta: \n");
            datosPaleta.AppendLine($"Cantidad maxima de colores: {cantidadMaximaColores}");
            foreach (Tempera temperasGuardar in temperas)
            {
                datosPaleta.AppendLine($"{Tempera.Mostrar(temperasGuardar)}");
            }
            return datosPaleta.ToString();
        }

        private int obtenerIndice(Tempera listaTemperas)
        {
            int indice = -1;
            int tamañoList = this.temperas.Count();
            for (int i = 0; i < tamañoList; i++)
            {
                if(this.temperas[i] == listaTemperas)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public static explicit operator string(Paleta unaPaleta)
        {
            return unaPaleta.Mostrar();
        }

        public static bool operator ==(Paleta unaPaleta,Tempera unaTempera)
        {
            bool estaEnLista = false;
            foreach (Tempera temperaEnLista in unaPaleta.temperas)
            {
                if(temperaEnLista == unaTempera)
                {
                    estaEnLista = true;
                    break;
                }
            }
            return estaEnLista;
        }

        public static bool operator !=(Paleta unaPaleta, Tempera unaTempera)
        {
            return !(unaPaleta == unaTempera);
        }

        public static Paleta operator +(Paleta unaPaleta, Tempera unaTempera)
        {
            int indice;
            if(unaPaleta == unaTempera)
            {
                indice = unaPaleta.obtenerIndice(unaTempera);
                unaPaleta.temperas[indice] += unaTempera;
            }
            else if(unaPaleta.temperas.Count() < unaPaleta.cantidadMaximaColores)
            {
                unaPaleta.temperas.Add(unaTempera);
            }
            return unaPaleta;
        }

        public static Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {
            int indice;
            int cantidadTempera;
            if (unaPaleta == unaTempera)
            {
                indice = unaPaleta.obtenerIndice(unaTempera);
                unaPaleta.temperas[indice] += -(unaTempera);
                cantidadTempera = unaPaleta.temperas[indice];

                if (cantidadTempera <= 0)
                {
                    unaPaleta.temperas.RemoveAt(indice);
                }
            }
            return unaPaleta;
        }
       public static Paleta operator +(Paleta paleta1, Paleta paleta2)
        {
            //asigno tamaño
            Paleta nuevaPaleta = paleta1.cantidadMaximaColores + paleta2.cantidadMaximaColores;

            //asigno paleta1 a nuevaPaleta
            foreach (Tempera unaTempera in paleta1.temperas)
            {
                nuevaPaleta = nuevaPaleta + unaTempera;
            }
            //asigno paleta2 a nuevaPaleta
            foreach (Tempera unaTempera in paleta2.temperas)
            {
                nuevaPaleta = nuevaPaleta + unaTempera;
            }

            return nuevaPaleta;
        }
    }
}
