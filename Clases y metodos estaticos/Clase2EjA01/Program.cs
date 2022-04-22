using System;

namespace Clase2EjA01
{
    class Program
    {
        public static long Factorial(Int32 numero)
        {
            long numFact = -1;
            if(numero >=0)
            {
                numFact = 1;
                for (Int32 i = 1; i <= numero; i++)
                {
                    numFact *= i;
                }
            }         
            return numFact;
        }
        static void Main(string[] args)
        {
            Int32 num;
            long numFactorial;
            Console.WriteLine("Ingrese un numero, para asi calcular su factorial: ");
            num = Int32.Parse(Console.ReadLine());
            
            numFactorial = Factorial(num);
            if(numFactorial == -1)
            {
                Console.WriteLine("Error, no se puede calcular el factorial de un numero negativo");
            }
            else
            {
                Console.WriteLine($"El factorial de {num} es: {numFactorial}");
            }        
        }
    }
}
