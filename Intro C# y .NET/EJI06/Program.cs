using System;

namespace EJI06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJI06";
            Int32 anioInicial;
            Int32 anioFinal;
            Console.WriteLine("Ingrese un año de inicio: ");
            anioInicial = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un año final: ");
            anioFinal = Int32.Parse(Console.ReadLine());

            for (int i = anioInicial; i <= anioFinal; i++)
            {
                if(  ( ( i % 4 ) == 0 ) && ((i % 100) != 0) )
                {
                    Console.WriteLine("El año {0} es bisiesto",i);
                }
                else if( ( ( i % 100 ) == 0 ) && ( (i % 4) == 0 ) )
                {
                    if ((i % 400) == 0 )
                    {
                        Console.WriteLine("El año {0} es bisiesto", i);
                    }      
                }
            }


        }
    }
}
