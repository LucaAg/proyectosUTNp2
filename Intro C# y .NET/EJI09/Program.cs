using System;

namespace EJI09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJI09";
            Int32 alturaTri;
            Int32 ancho = 1;

            Console.WriteLine("Ingrese la altura del triangulo equilatero: ");
            alturaTri = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < alturaTri; i++)
            {
                Console.Write("\n");

                for (int j = i; j < alturaTri - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < ancho; k++) 
                {
                    
                    Console.Write("*");
                }
                Console.Write(" ");
                ancho += 2;
            }
        }
    }
}
