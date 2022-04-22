using System;

namespace Clase2EjI06
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoCuadrado;
            double areaCuadrado;

            double baseeTria;
            double alturaTria;
            double areaTriangulo;

            double radioCirculo;
            double areaCirculo;

            Console.WriteLine("Ingrese la longitud del lado del cuadrado: ");
            ladoCuadrado = double.Parse(Console.ReadLine());

            areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado);

            Console.WriteLine("Ingrese la base del triangulo: ");
            baseeTria = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo: ");
            alturaTria = double.Parse(Console.ReadLine());

            areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(baseeTria,alturaTria);

            Console.WriteLine("Ingrese el area del circulo: ");
            radioCirculo = double.Parse(Console.ReadLine());

            areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);

            Console.WriteLine($"El area del cuadrado es {areaCuadrado}\nEl area del triangulo es {areaTriangulo}" +
                $"\nEl area del circulo es {areaCirculo}");
        }
    }
}
