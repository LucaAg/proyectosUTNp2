using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06EjI04
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

        public Equipo(short cantidad,string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool sePuede = false;
            int cantidadJugadoresMax = e.jugadores.Count;
            if(!e.jugadores.Contains(j) && cantidadJugadoresMax < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                sePuede = true;
            }
            return sePuede;
        }
    }
}
