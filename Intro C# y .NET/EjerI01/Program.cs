using System;

namespace EjerI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Single nMax = 0;
            Single nMin = 0;
            Single flagMax = 0;
            Single acumulador = 0;
            Single contador = 0;
            Single promedio;
            Console.Title = "EJI01";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                Single num_1 = Single.Parse(Console.ReadLine());
                if (nMax < num_1 || flagMax == 0)       
                {
                    flagMax = 1;
                    nMax = num_1;
                }
                if (nMin > num_1 || i == 0)
                {
                    nMin = num_1;
                }
                contador++;
                acumulador += num_1;
            }
            promedio = (float) acumulador / contador;
            Console.WriteLine("El valor minimo es {0}\nEl maximo {1} \nEl promedio es {2}", nMin, nMax, promedio);
            //Para reducir la cantidad de decimales Math.Round(numero a reducir, cantidad que quiero); con float
            //para decimal decimal.Round();
            Console.ReadKey();
        }
    }
}
