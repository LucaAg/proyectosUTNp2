using System;
using System.Text;

namespace BibliotecaClase3EjA02
{
    public class Clientes
    {
        private string domicilio;
        private string nombre_Apellido;
        private Int32 telefono;
        private Int32 cantidadMascotas;
        private Mascota[] mascotas;

        public Clientes(string domicilio, string nombre_Apellido, Int32 telefono, Int32 cantidadMascotas, Mascota[] mascotas)
        {
            this.domicilio = domicilio;
            this.nombre_Apellido = nombre_Apellido;
            this.telefono = telefono;
            this.cantidadMascotas = cantidadMascotas;
            this.mascotas = mascotas;
        }
        public string mostrarCliente(Mascota[] mascotas)
        {
            StringBuilder datosClientes = new StringBuilder("Datos de la persona: \n");
            datosClientes.AppendLine($"Domicilio: {this.domicilio}");
            datosClientes.AppendLine($"Nombre y apellido: {this.nombre_Apellido}");
            datosClientes.AppendLine($"Telefono: {this.telefono}");
            datosClientes.AppendLine($"Cantidad de mascotas: {this.cantidadMascotas}");
            for (int i = 0; i < this.cantidadMascotas; i++)
            {
                datosClientes.AppendLine($"\n{mascotas[i].MostrarMascota()}");
            }
            return datosClientes.ToString();
        }
    }
}
