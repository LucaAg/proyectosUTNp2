using System;
using System.Text;

namespace Clase2EjI05
{
    class Program
    {
        public static string Multiplicador(Int32 numero)
        {
            StringBuilder myString = new StringBuilder($"Tabla de multiplcar del numero {numero}: \n");
            Int32 resultado = 0;
           // Console.WriteLine($"Tabla de multiplcar del numero {numero}:");
            for (int i = 1; i < 10; i++)
            {
                resultado = numero * i;
                myString.AppendLine($"{numero} x {i} = {resultado}");        
            }

            return myString.ToString(); 
        }
        static void Main(string[] args)
        {
            Int32 numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Multiplicador(numero));
        }
    }
}
