using System;

namespace EjerI04
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 contador = 0;
            Int32 acumulador = 0;
            Int32 numeroIncremental = 0;
            Console.Title = "EJI04";
            do
            {
                numeroIncremental++;
                acumulador = 0;
                for (int divisor = 1; divisor < numeroIncremental; divisor++)
                {
                    if (numeroIncremental % divisor == 0) 
                    {
                        acumulador += divisor;
                    }
                }
                if (acumulador == numeroIncremental)
                {
                    Console.WriteLine("Numero perfecto: {0}", numeroIncremental);
                    contador++;
                }
            } while (contador < 4);
        }
    }
}
