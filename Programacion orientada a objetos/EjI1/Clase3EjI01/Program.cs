using System;
using BibliotecaClase3EjI01;

namespace Clase3EjI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta("Nahuel",0);
            miCuenta.Ingresar(5000);
            Console.WriteLine(miCuenta.Mostrar());
            miCuenta.Retirar(8000);
            Console.WriteLine(miCuenta.Mostrar());
        }
    }
}
