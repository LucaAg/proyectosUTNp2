using System;

namespace EjerI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJI02";
            Console.WriteLine("Ingrese un numero: ");
            Single num_1 = Single.Parse(Console.ReadLine());
            while (num_1 < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
                num_1 = Single.Parse(Console.ReadLine());
            }
            Single num_2 = (float) Math.Pow(num_1, 2 ) ;
            Single num_3 = (float)Math.Pow(num_1, 3) ;
            Console.WriteLine("El cuadrado del numero es: {0}\nEl cubo del numero es: {1}",num_2,num_3);
        }
    }
}
