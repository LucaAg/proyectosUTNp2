using System;
using BibliotecaClase04EjI03;

namespace Clase04EjI03
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal objDecimal = 40;
            NumeroBinario objBinario = "1111011";
            NumeroDecimal objDecimal1 = 10;
            NumeroBinario objBinario2 = "1000";
            /*
                        Console.WriteLine($"El numero binario {(string)objBinario} + el numero decimal {(double)objDecimal} es : {objBinario + objDecimal}");
                        Console.WriteLine($"El numero binario {(string)objBinario} - el numero decimal {(double)objDecimal} es : {objBinario - objDecimal}");
                        Console.WriteLine(objDecimal + objBinario);
                        Console.WriteLine(objDecimal - objBinario);
                        Console.WriteLine(objBinario == objDecimal);
                        Console.WriteLine(objBinario != objDecimal);
                        Console.WriteLine(objDecimal == objBinario);
                        Console.WriteLine(objDecimal != objBinario);*/
            Console.WriteLine(objDecimal1 - objBinario2);
            Console.WriteLine(objBinario2 - objDecimal1);

        }
    }
}
