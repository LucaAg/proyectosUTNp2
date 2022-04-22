using System;
using System.Text;
using BibliotecaClase3EjA02;

namespace Clase3EjA02
{
    class Program
    {
        static void Main(string[] args)
        {
            const Int32 tamClientes = 3;
            const Int32 tamMascotas = 4;
            Clientes[] clientes = new Clientes[tamClientes];
            string[] nombresClientes = new string[tamClientes] { "Nelson", "Bart", "Bort" };
            string[] domicilios = new string[tamClientes] { "Lavalleja 416", "Peña Aeronautica 2221", "Moreno 1220" };
            Int32[] telefonos = { 1128963344, 1122831588, 1165696865 };
            Int32[] cantidadMascotas = { 1, 1, 2 };
            StringBuilder vacunaMascota2 = new StringBuilder();
            vacunaMascota2.AppendLine("Triple Felina");

            StringBuilder vacunaMascota3 = new StringBuilder();
            vacunaMascota3.AppendLine("Vacuna antirabica");

            Mascota[] mascotas = new Mascota[1];
            Mascota[] mascotas2 = new Mascota[1];
            Mascota[] mascotas3 = new Mascota[2];

            string[] especies = { "Perro", "Gato", "Gato", "Perro" };
            string[] nombresMascotas = { "Lisa", "Juana", "Negra", "Ailu" };
            DateTime[] fechas = { new DateTime(2019, 04, 16), new DateTime(2012, 12, 14), new DateTime(2019, 04, 18), new DateTime(2007, 06, 21) };
            StringBuilder[] historialVacunas = { new StringBuilder(""), new StringBuilder(""), new StringBuilder(""), new StringBuilder("") };


            mascotas[0] = new Mascota(especies[0], nombresMascotas[0], fechas[0], historialVacunas[0]);
            mascotas2[0] = new Mascota(especies[1], nombresMascotas[1], fechas[1], historialVacunas[1]);
            mascotas3[0] = new Mascota(especies[2], nombresMascotas[2], fechas[2], historialVacunas[2]);
            mascotas3[1] = new Mascota(especies[3], nombresMascotas[3], fechas[3], historialVacunas[3]);

            clientes[0] = new Clientes(domicilios[0], nombresClientes[0], telefonos[0], cantidadMascotas[0], mascotas);
            clientes[1] = new Clientes(domicilios[1], nombresClientes[1], telefonos[1], cantidadMascotas[1], mascotas2);
            clientes[2] = new Clientes(domicilios[2], nombresClientes[2], telefonos[2], cantidadMascotas[2], mascotas3);

            mascotas2[0].agregarVacuna(vacunaMascota2);
            mascotas3[1].agregarVacuna(vacunaMascota3);

            Console.WriteLine(clientes[0].mostrarCliente(mascotas));
            Console.WriteLine(clientes[1].mostrarCliente(mascotas2));
            Console.WriteLine(clientes[2].mostrarCliente(mascotas3));
        }
    }
}
