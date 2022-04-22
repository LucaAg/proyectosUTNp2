using System;

namespace EjerI08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJI08";
            Int32 alturaTri;
            Int32 ancho = 1;

            Console.WriteLine("Ingrese la altura del triangulo(numero mayor a 0): ");
            alturaTri = Int32.Parse(Console.ReadLine());
            while(alturaTri < 1)
            {
                Console.WriteLine("Error, debe ingresar un numero mayor a 0. Vuelva a ingresarlo: ");
                alturaTri = Int32.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= alturaTri; i++)
            {
                Console.Write("\n");
                for (int k = 0; k < ancho; k++)
                {
                        Console.Write("*"); 
                }
                ancho += 2;
            }
        }
    }
}
