using System;

namespace Clase2EjI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            Single promedio;
            Int32 numMax = 0;
            Int32 numMin = 0;
            Int32 acumulador = 0;
            bool cumpleRango;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero(-100 / 100): ");
                num = Int32.Parse(Console.ReadLine());
                cumpleRango = Validador.Validar(num, -100, 100);
                while(cumpleRango == false)
                {
                    Console.WriteLine("Error, el numero debe estar entre -100 y 100. Vuelva a ingresarlo:  ");
                    num = Int32.Parse(Console.ReadLine() );
                    cumpleRango = Validador.Validar(num, -100, 100);
                }

                if(i == 0 || numMax < num)
                {
                    numMax = num;
                }

                if(i == 0 || numMin > num)
                {
                    numMin = num;
                }

                acumulador += num;
            }
            promedio = (Single) acumulador / 10;

            Console.WriteLine("El promedio de los numeros ingresados es {0}, su maximo es {1}" +
                "y su valor minimo es {2}",promedio,numMax,numMin);
        }
    }
}
