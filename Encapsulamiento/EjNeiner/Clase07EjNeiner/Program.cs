using System;
using BibliotecaClase07EjNeiner;
namespace Clase07EjNeiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera primerTempera = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera segundaTempera = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera tercerTempera = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera cuartaTempera = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera quintaTempera = new Tempera(ConsoleColor.Green, "Temperita", 50);

     /*       Paleta unaPaleta = 2;
            unaPaleta = unaPaleta + primerTempera;
            unaPaleta = unaPaleta + tercerTempera;

            Console.WriteLine( (string)unaPaleta);

            unaPaleta = unaPaleta - tercerTempera;

            Console.WriteLine((string)unaPaleta); 


            //1) == 2)
            //1) == 3)
            //1) == 4)
            //1) == null
            //null == 1)
            Console.WriteLine(primerTempera == segundaTempera);
            Console.WriteLine(primerTempera == tercerTempera);
            Console.WriteLine(primerTempera == cuartaTempera);
            Console.WriteLine(primerTempera == null);
            Console.WriteLine(null == primerTempera);

            //Sumar(temperas):
            //1) +2)
            //1) +3)
            //1) +4)
            //1) +null
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(primerTempera + segundaTempera);
            Console.WriteLine(primerTempera + tercerTempera);
            Console.WriteLine(primerTempera + cuartaTempera);
            Console.WriteLine(primerTempera + null);

            //Sumar(temperas):
            //1) +20
            //2) +30
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(primerTempera + 20);
            Console.WriteLine(segundaTempera + 30);

            Console.WriteLine(Tempera.Mostrar(primerTempera));
            Console.WriteLine(Tempera.Mostrar(segundaTempera));
            Console.WriteLine(Tempera.Mostrar(tercerTempera));
            Console.WriteLine(Tempera.Mostrar(cuartaTempera));
            Console.WriteLine(Tempera.Mostrar(quintaTempera));
     */
            Console.WriteLine("------------------------------------------");
            Paleta paleta = 3;
     

            //p == 1)
            Console.WriteLine(paleta == primerTempera);
           // p + 1)
            //p + 2)
            //p + 3)
            //p + 4)
            //p + 5)
            Console.WriteLine("------------------------------------------");
            paleta = paleta + primerTempera;
            paleta = paleta + segundaTempera;
            paleta = paleta + tercerTempera;
            paleta = paleta + cuartaTempera;
            paleta = paleta + quintaTempera;
            Console.WriteLine((string) paleta );

            Console.WriteLine("------------------------------------------");

            //p - 1)
            //p - 2)
            //p - 5)
            paleta = paleta - primerTempera;
            paleta = paleta - segundaTempera;
            paleta = paleta - quintaTempera;
            Console.WriteLine((string) paleta  );

            Console.WriteLine("------------------------------------------");
            Paleta paleta2 = 2;
            paleta2 = paleta2 + quintaTempera;
            paleta2 = paleta2 + cuartaTempera;
            paleta2 = paleta2 + tercerTempera;
            paleta2 = paleta2 + segundaTempera;
            Console.WriteLine((string) paleta2 );

            Console.WriteLine("------------------------------------------");

            paleta2 = paleta2 + paleta;
            Console.WriteLine((string) paleta2 );
        }
    }
}
