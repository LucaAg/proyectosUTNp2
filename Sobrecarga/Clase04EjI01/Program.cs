using System;
using BibliotecaClase04EjI01;

namespace Clase04EjI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador num1 = new Sumador(13);
            Sumador num2 = new Sumador(26);
            Sumador num3 = new Sumador(14);
            Sumador num4 = new Sumador(14);
            string cadena1 = "Pepe";
            string cadena2 = "Diaz Alvarez";
            long numLong1 = 14000;
            long numLong2 = 13000;
            Console.WriteLine((int)num1);
            num1 = new Sumador();
            Console.WriteLine((int)num1);

            Console.WriteLine(num1.Sumar(numLong1,numLong2));
            Console.WriteLine(num1.Sumar(cadena1, cadena2));

            Console.WriteLine(num2+num3);
            Console.WriteLine(num3|num1);
        }
    }
}
