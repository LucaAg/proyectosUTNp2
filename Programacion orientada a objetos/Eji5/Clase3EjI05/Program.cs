using System;
using Geometria;
using System.Text;

namespace Clase3EjI05
{
    class Program
    {
        static string Mostrar(Rectangulo rectangulo)
        {
            StringBuilder datosRectangulo = new StringBuilder("Caracteristicas del rectangulo: \n");
            datosRectangulo.AppendLine($"Area: {rectangulo.GetArea()}");
            datosRectangulo.AppendLine($"Perimetro: {rectangulo.GetPerimetro()}");
            return datosRectangulo.ToString();
        }
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(2, 3);
            Punto vertice3 = new Punto(7, -1);
            Rectangulo miRectangulo = new Rectangulo(vertice1,vertice3);

            Console.WriteLine(Mostrar(miRectangulo));

        }
    }
}
