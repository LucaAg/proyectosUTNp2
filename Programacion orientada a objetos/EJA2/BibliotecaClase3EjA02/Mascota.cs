using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase3EjA02
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private StringBuilder historialVacunacion;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento, StringBuilder historialVacunas)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.historialVacunacion = historialVacunas;
        }
        public string MostrarMascota()
        {
            string auxVacuna =this.historialVacunacion.ToString();
            StringBuilder datosMascota = new StringBuilder("Datos de la mascota: \n");
            datosMascota.AppendLine($"Especie: {this.especie}");
            datosMascota.AppendLine($"Nombre: {this.nombre}");
            datosMascota.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            if(string.IsNullOrEmpty(auxVacuna))
            { 
               datosMascota.AppendLine("-No esta vacunado / a.");
            }
            else
            {
                datosMascota.AppendLine($"Historial de vacunacion: {this.historialVacunacion}");
            }
            return datosMascota.ToString();
        }

        public void agregarVacuna(StringBuilder vacuna)
        {
            this.historialVacunacion.AppendLine($"-{vacuna}");
        }
    }
}
