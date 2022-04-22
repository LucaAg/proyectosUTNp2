using System;
using System.Text;

namespace BibliotecaWinFormI02
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder datosIngresantes = new StringBuilder();
            datosIngresantes.AppendLine($"Nombre : {this.nombre}");
            datosIngresantes.AppendLine($"Edad : {this.edad}");
            datosIngresantes.AppendLine($"Direccion : {this.direccion}");
            datosIngresantes.AppendLine($"Genero : {this.genero}");
            datosIngresantes.AppendLine($"Pais : {this.pais}");
            datosIngresantes.AppendLine($"Cursos : ");
            foreach (string curso in cursos)
            {
                if(!(string.IsNullOrWhiteSpace(curso)))
                {
                    datosIngresantes.AppendLine($"{curso}");
                }           
            }
            return datosIngresantes.ToString();
        }
    }
}
