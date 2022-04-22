using System;
using BibliotecaClase3EjI02;

namespace Clase3EjI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona miPersona = new Persona();
            miPersona.AsignarNombre("Nahuel");
            miPersona.AsignarFechaNacimiento(new DateTime(2000,02,22));
            miPersona.AsignarDni(42417493);
            Console.WriteLine(miPersona.Mostrar());

            Persona miPersona2 = new Persona();
            miPersona.AsignarNombre("Bianca");
            miPersona.AsignarFechaNacimiento(new DateTime(1996, 06, 26));
            miPersona.AsignarDni(39642326);
            Console.WriteLine(miPersona.Mostrar());

            Persona miPersona3 = new Persona();
            miPersona.AsignarNombre("Leandro");
            miPersona.AsignarFechaNacimiento(new DateTime(2015, 12, 27));
            miPersona.AsignarDni(18263648);
            Console.WriteLine(miPersona.Mostrar());
        }
    }
}
