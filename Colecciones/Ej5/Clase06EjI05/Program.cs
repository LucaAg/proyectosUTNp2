using System;
using BibliotecaClase06EjI05;

namespace Clase06EjI05
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(1, "escu1");
            AutoF1 a2 = new AutoF1(4, "escu2");
            AutoF1 a3 = new AutoF1(5, "escu3");
            AutoF1 a4 = new AutoF1(1, "escu1");
            AutoF1 a5 = new AutoF1(2, "escu4");
            Competencia competencia = new Competencia(5, 10);


            Console.WriteLine(competencia.MostrarDatos()); 
            if (competencia + a1)
            {
                Console.WriteLine(a1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a2)
            {
                Console.WriteLine(a2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a3)
            {
                Console.WriteLine(a3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a4)
            {
                Console.WriteLine(a4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a5)
            {
                Console.WriteLine(a5.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
        }
    }
}
