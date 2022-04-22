using System;

namespace Clase2EjI07
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaTriangulo;
            double baseTrinagulo;
            double hipotenusa;
           
            Console.WriteLine("Ingresar la altura del triangulo(en centimetros): ");
            alturaTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la base del triangulo(en centimetros): ");
            baseTrinagulo = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt( ( Math.Pow(baseTrinagulo,2) + Math.Pow(alturaTriangulo,2) ) );

            Console.WriteLine($"La hipotenusa del triangulo rectangulo es {hipotenusa:#,#.00} cm");
        }
    }
}
