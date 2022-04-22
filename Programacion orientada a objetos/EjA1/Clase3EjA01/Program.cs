using System;
using BibliotecaClase3EjA01;

namespace Clase3EjA01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cantidadConductoresMax = 3;
            string[] conductores = new string[cantidadConductoresMax] { "Nelson", "Bart", "Bort" };
            Single[] kilometros1 = { 200, 30, 300, 390, 200, 0, 0 };
            Single[] kilometros2 = { 300, 460, 200, 40, 69, 900, 60 };
            Single[] kilometros3 = { 150, 100, 30, 40, 600, 0, 0 };

            Conductores[] misConductores = new Conductores[cantidadConductoresMax];

            misConductores[0] = new Conductores(conductores[0], kilometros1);
            misConductores[1] = new Conductores(conductores[1], kilometros2);
            misConductores[2] = new Conductores(conductores[2], kilometros3);

            for (int i = 0; i < cantidadConductoresMax; i++)
            {
                Console.WriteLine(misConductores[i].Mostrar()); 
            }
            Console.WriteLine($"El conductor que mas km hizo es : {Conductores.ConductorMasKm(misConductores, cantidadConductoresMax)}");
            Console.WriteLine($"El conductor que mas km hizo en el dia 3 es: {Conductores.conductorMasKmDiaTres(misConductores, cantidadConductoresMax)}");
            Console.WriteLine($"El conductor que mas km hizo en el dia 3 es: {Conductores.conductorMasKmDiaCinco(misConductores, cantidadConductoresMax)}");

        }
    }
}