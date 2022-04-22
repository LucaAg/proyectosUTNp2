using System;
using System.Text;

namespace BibliotecaClase3EjA01
{
    public class Conductores
    {
        private string nombreConductor;
        private Single[] kilometros = new Single[7];
        private const int diasSemana = 7;

        public Conductores(string nombre,Single[] kilometros)
        {
        
            this.nombreConductor = nombre;
            
            for (int i = 0; i < diasSemana; i++)
            {
                this.kilometros[i] = kilometros[i];
            }
        }

        public static string ConductorMasKm(Conductores[] conductores, Int32 tamConductores)
        {
            Single acumuladorKm = 0;
            Single masKm = 0;
            string choferMaxKm = "";
            for (int i = 0; i < tamConductores; i++)
            {
                for (int j = 0; j < diasSemana; j++)
                {
                    acumuladorKm += conductores[i].kilometros[j];
                }
                if(i == 0 || masKm < acumuladorKm)
                {
                    masKm = acumuladorKm;
                    choferMaxKm = conductores[i].nombreConductor;
                }
                acumuladorKm = 0;
            }
            return choferMaxKm;      
        }

        public static string conductorMasKmDiaTres(Conductores[] conductores, Int32 tamConductores)
        {
            Single masKm = 0;
            string choferMaxKm = "";
            int dia_tres = 2;
            for (int i = 0; i < tamConductores; i++)
            {
                if (i == 0 || masKm < conductores[i].kilometros[dia_tres])
                {
                    masKm = conductores[i].kilometros[dia_tres];
                    choferMaxKm = conductores[i].nombreConductor;
                }
            }
            return choferMaxKm;
        }

        public static string conductorMasKmDiaCinco(Conductores[] conductores, Int32 tamConductores)
        {
            Single masKm = 0;
            string choferMaxKm = "";
            int dia_cinco = 4;
            for (int i = 0; i < tamConductores; i++)
            {
                if (i == 0 || masKm < conductores[i].kilometros[dia_cinco])
                {
                    masKm = conductores[i].kilometros[dia_cinco];
                    choferMaxKm = conductores[i].nombreConductor;
                }
            }
            return choferMaxKm;
        }

        public string Mostrar()
        {
            StringBuilder datosChofer = new StringBuilder("Datos del conductor: \n");
            datosChofer.AppendLine($"Nombre: {this.nombreConductor}");
            for (int i = 0; i < diasSemana; i++)
            {
                datosChofer.AppendLine($"Km realizados dia {i + 1}: {this.kilometros[i]}");
            }
            return datosChofer.ToString();
        }
    }
}
