using System;
using BibliotecaClase3EjI03;

namespace Clase3EjI03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Nahuel","Agnoli", "111976");
            estudiante1.SetNotaPrimerParcial(9);
            estudiante1.SetNotaSegundoParcial(8);

            Estudiante estudiante2 = new Estudiante("Leandro", "Avalos", "789101");
            estudiante2.SetNotaPrimerParcial(7);
            estudiante2.SetNotaSegundoParcial(7);

            Estudiante estudiante3 = new Estudiante("Bianca", "Casetta", "123456");
            estudiante3.SetNotaPrimerParcial(4);
            estudiante3.SetNotaSegundoParcial(3);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
