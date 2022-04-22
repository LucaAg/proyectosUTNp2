using System;
using System.Text;

namespace BibliotecaClase3EjI03
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private Int32 notaPrimerParical;
        private Int32 notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido,string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(Int32 notaDelPrimerParcial)
        {
            this.notaPrimerParical = notaDelPrimerParcial;
        }

        public void SetNotaSegundoParcial(Int32 notaDelSegundoParcial)
        {
            this.notaSegundoParcial = notaDelSegundoParcial;
        }

        private Single CalcularPromedio()
        {
            Single promedio;
            promedio = ((Single)notaPrimerParical + notaSegundoParcial) / 2;
            return promedio;
        }

        private Int32 CalcularNotaFinal()
        {
            Int32 numRandom = -1;
            if(this.notaPrimerParical >= 4 && this.notaSegundoParcial >=4)
            {
                numRandom = random.Next(6, 10);
            }
            return numRandom;
        }

        public string Mostrar()
        {
            StringBuilder datosEstudiante = new StringBuilder("Datos del alumno/a: \n");
            datosEstudiante.AppendLine($"Nombre: {this.nombre}, apellido: {this.apellido}, legajo: {this.legajo}");
            datosEstudiante.AppendLine($"Nota del primer parcial: {this.notaPrimerParical}\nNota del segundo parcial: {this.notaSegundoParcial}");
            datosEstudiante.AppendLine($"Promedio: {CalcularPromedio()}");
            if(CalcularNotaFinal() > -1)
            {
                datosEstudiante.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            else
            {
                datosEstudiante.AppendLine("Alumno desaprobado.");
            }
            return datosEstudiante.ToString();
        }
    }
}
