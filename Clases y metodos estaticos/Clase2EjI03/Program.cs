using System;

namespace Clase2EjI03
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            Int32 binario;
            Console.WriteLine("Ingrese un numero: ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Conversor.ConvertirDecimalABinario(num));

            Console.ReadLine();

            Console.WriteLine("Ingrese un binario para pasar a decimal: ");
            binario = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(binario) );

        }

    }
}
