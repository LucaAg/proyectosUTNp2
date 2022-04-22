using System;
using System.Text;

namespace Clase06EjI04
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni,string nombre) :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni,string nombre,int totalGoles, int totalPartidos):this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder datosJugador = new StringBuilder("Datos del jugador: \n");
            datosJugador.AppendLine($"DNI: {this.dni}");
            datosJugador.AppendLine($"NOMBRE: {this.nombre}");
            datosJugador.AppendLine($"PARTIDOS JUGADOS: {this.partidosJugados}");
            datosJugador.AppendLine($"TOTAL DE GOLES: {this.totalGoles}");
            datosJugador.AppendLine($"PROMEDIO DE GOL: {GetPromedioGoles()}");

            return datosJugador.ToString();
        }

        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
