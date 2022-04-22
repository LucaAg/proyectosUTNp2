using System;

namespace Clase2EjI04
{
    class Program
    {
        static void Main(string[] args)
        {
            Single num1;
            Single num2;
            char operando;
            char respuesta = 'S';

            while(respuesta == 'S')
            {
                Console.WriteLine("Ingrese un numero: ");
                num1 = Single.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                num2 = Single.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese un operador(+,-,* o /): ");
                operando = char.Parse(Console.ReadLine());

                Console.WriteLine(Calculadora.Calcular(num1, num2, operando) ); 

                Console.WriteLine("Desea realizar otra operacion?(S/N)");
                respuesta = char.Parse(Console.ReadLine());
                while(respuesta != 'S' && respuesta!= 'N')
                {
                    Console.WriteLine("Error, debe ingresar S o N. Vuelva a intentarlo: ");
                    respuesta = char.Parse(Console.ReadLine());
                }
            }
           
        }
    }
}
