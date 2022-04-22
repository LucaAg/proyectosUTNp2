using System;

namespace Clase2EjI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 numero;
            Int32 acumulador = 0;
            char respuesta = 'S';

            while(Validador.ValidarRespuesta(respuesta) == true)
            {
                Console.WriteLine("Ingrese un numero para sumarlo: ");
                numero = Int32.Parse(Console.ReadLine());

                acumulador += numero;
                Console.WriteLine("La totalidad de los numeros ingresados es {0}.\n" +
                    "" +
                    "¿Desea continuar?(S/N)",acumulador);
                respuesta = char.Parse(Console.ReadLine());
            }
        }
    }
}
