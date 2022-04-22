using System;

namespace BibliotecaClase04EjI01
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {

        }

        public long Sumar(long num1, long num2)
        {
            return num1 + num2;
        }

        public string Sumar(string cadena1, string cadena2)
        {
            return cadena1 + cadena2;
        }

        public static explicit operator int(Sumador unSumador)
        {
            return unSumador.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long cantidadSLong = s1.cantidadSumas + s2.cantidadSumas;
            return cantidadSLong;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas == s2.cantidadSumas);
        }
    }
}
