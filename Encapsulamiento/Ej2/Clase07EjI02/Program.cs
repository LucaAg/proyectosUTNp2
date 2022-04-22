using System;
using BibliotecaClase07EjI02;

namespace Clase07EjI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro();

            miLibro[0] = "La dependienta";
            miLibro[1] = "1984";
            //Console.WriteLine($"TAMAÑO INDICE: {miLibro.ObtengoIndex}");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(miLibro[i]);
            }
            Console.ReadKey();
            miLibro[1] = "Un mundo feliz";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(miLibro[i]);
            }
            //Console.WriteLine($"TAMAÑO INDICE: {miLibro.ObtengoIndex}");
        }
    }
}
