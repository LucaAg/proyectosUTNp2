using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase06EjI05
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder datosCompetencia = new StringBuilder("DATOS DE LA COMPETENCIA: \n");
            datosCompetencia.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            datosCompetencia.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
           /* foreach (AutoF1 auto in competidores)
            {
                datosCompetencia.AppendLine(auto.MostrarDatos() );
            }*/
            return datosCompetencia.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool autoEsta = false;
            foreach (AutoF1 auto in c.competidores)
            {
                if(a == auto)
                {
                    autoEsta = true;
                    break;
                }
            }
            return autoEsta;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool sePudoSumar = false;
            int cantidadAutosMax = c.competidores.Count;
            Random r = new Random();
                
            if(cantidadAutosMax < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                if(c.competidores.Contains(a))
                {
                    a.enComp = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.cantCombustible = (short)r.Next(15, 101);
                }
                sePudoSumar = true; 
            }
            return sePudoSumar;
        }

        public static bool operator - (Competencia c, AutoF1 a)
        {
            bool seRemovio = false;
            if(c == a)
            {
                c.competidores.Remove(a);
            }
            return seRemovio;
        }
    }
}
