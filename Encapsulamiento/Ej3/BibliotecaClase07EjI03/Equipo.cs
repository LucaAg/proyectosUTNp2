using System;
using System.Collections.Generic;

namespace BibliotecaClase07EjI03
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool sePuede = false;
            int cantidadJugadoresMax = e.jugadores.Count;
            if (!e.jugadores.Contains(j) && cantidadJugadoresMax < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                sePuede = true;
            }
            return sePuede;
        }
    }
}
