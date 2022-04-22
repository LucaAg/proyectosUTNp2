using System;
using System.Text;

namespace BibliotecaClase07EjNeiner
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder datosTempera = new StringBuilder("Datos de la tempera: \n");
            datosTempera.AppendLine($"Color: {color}");
            datosTempera.AppendLine($"Marca: {marca}");
            datosTempera.AppendLine($"Cantidad: {cantidad}");

            return datosTempera.ToString();
        }

        public static string Mostrar(Tempera unaTempera)
        {
            return unaTempera.Mostrar();
        }

        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool esTrue = false;
            if(tempera1 is not null && tempera2 is not null)
            {
                if(tempera1.marca == tempera2.marca && tempera1.color == tempera2.color)
                {
                    esTrue = true;
                }
            }
            return esTrue;
        }

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }

        public static implicit operator int(Tempera unaTempera)
        {
            return unaTempera.cantidad;
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            Tempera laTempera = new Tempera(tempera1.color, tempera1.marca, tempera1.cantidad);
            if (tempera1 == tempera2)
            {
                laTempera.cantidad += tempera2.cantidad;
            }
            return laTempera;
        }

        public static Tempera operator +(Tempera tempera1, int cantidad)
        {
            tempera1.cantidad += cantidad;
            return tempera1;
        }


    }
}
