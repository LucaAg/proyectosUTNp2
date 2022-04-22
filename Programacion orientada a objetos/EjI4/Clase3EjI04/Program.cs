using System;
using BibliotecaClase3EjI04;

namespace Clase3EjI04
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo1;
            Boligrafo boligrafo1 = new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo boligrafo2 = new Boligrafo(ConsoleColor.Red, 50);

            boligrafo1.Pintar(50, out dibujo1);
          
            Console.WriteLine(dibujo1);

            boligrafo2.Pintar(60, out dibujo1);
           
            Console.WriteLine(dibujo1);


            boligrafo2.Recargar();

            boligrafo2.Pintar(100, out dibujo1);
    
            Console.WriteLine(dibujo1);

            Console.ResetColor();
        }
    }
}
