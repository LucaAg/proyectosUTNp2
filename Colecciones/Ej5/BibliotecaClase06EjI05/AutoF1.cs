using System;
using System.Text;

namespace BibliotecaClase06EjI05
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder datosAuto = new StringBuilder("Datos auto: \n");
            datosAuto.AppendLine($"Numero: {this.numero}");
            datosAuto.AppendLine($"Escuderia: {this.escuderia}");
            datosAuto.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            datosAuto.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");
            if(this.enCompetencia)
            {
                datosAuto.AppendLine($"El auto compite? si");
            }
            else
            {
                datosAuto.AppendLine($"El auto compite? no");
            }

            return datosAuto.ToString();
        }

        public short cantCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public bool enComp
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia && a1.numero == a2.numero;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
