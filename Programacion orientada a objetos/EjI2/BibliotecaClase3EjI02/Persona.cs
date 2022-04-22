using System;
using System.Text;

namespace BibliotecaClase3EjI02
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private Int32 dni;

        public Persona()
        {
            this.nombre = "";
            this.fechaNacimiento = DateTime.Now;
            this.dni = 00000000;
        }

        public string BuscarNombre()
        {
            return this.nombre;
        }

        public DateTime BuscarFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public Int32 BuscarDni()
        {
            return this.dni;
        }

        public void AsignarNombre(string nombre)
        {
            if(!string.IsNullOrWhiteSpace(nombre))
            {
                this.nombre = nombre;
            }   
        }

        public void AsignarFechaNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaNacimiento = fechaDeNacimiento;
        }

        public void AsignarDni( Int32 dni)
        {
            if(dni > 0)
            {
                this.dni = dni;
            }
        }

        private Int32 CalcularEdad()
        {
            Int32 edadRetorno;
            edadRetorno = DateTime.Now.Year - this.BuscarFechaNacimiento().Year;
            if(DateTime.Now.Month < this.BuscarFechaNacimiento().Month)
            {
                edadRetorno--;
            }
            else if(DateTime.Now.Month == this.BuscarFechaNacimiento().Month)
            {
                if(DateTime.Now.Day < this.BuscarFechaNacimiento().Day)
                {
                    edadRetorno--;
                }
            }
            return edadRetorno;
        }

        public string Mostrar()
        {
            StringBuilder datosPersona = new StringBuilder("Los datos de la persona son: \n");
            datosPersona.AppendLine($"Nombre: {BuscarNombre()}");
            datosPersona.AppendLine($"Fecha: {BuscarFechaNacimiento().ToShortDateString()}");
            datosPersona.AppendLine($"DNI: {BuscarDni()}");
            datosPersona.AppendLine($"Edad actual: {CalcularEdad()}");
            datosPersona.AppendLine($"Es adulto? {EsMayorDeEdad()}");

            return datosPersona.ToString();
        }

        public string EsMayorDeEdad()
        {
            string mayorOMenor = "";
            if(CalcularEdad() > 17)
            {
                mayorOMenor += "Es mayor de edad";
            }
            else
            {
                mayorOMenor += "Es menor";
            }
            return mayorOMenor;
        }
    }
}
