using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase07EjI03
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public float PromedioGoles
        {
            get { return (float)this.totalGoles / this.partidosJugados; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }
        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public string MostrarDatos()
        {
            StringBuilder datosJugador = new StringBuilder("Datos del jugador: \n");
            datosJugador.AppendLine($"DNI: {this.dni}");
            datosJugador.AppendLine($"NOMBRE: {this.nombre}");
            datosJugador.AppendLine($"PARTIDOS JUGADOS: {this.partidosJugados}");
            datosJugador.AppendLine($"TOTAL DE GOLES: {this.totalGoles}");
            datosJugador.AppendLine($"PROMEDIO DE GOL: {this.PromedioGoles}");

            return datosJugador.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
