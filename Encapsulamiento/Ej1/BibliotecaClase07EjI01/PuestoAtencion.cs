using System;
using System.Threading;

namespace BibliotecaClase07EjI01
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public int NumeroActual
        {
            get { return PuestoAtencion.numeroActual; }
        }

        public bool Atender(Cliente cli)
        {
            int miDelay = 2000;
            bool tiempoCumplido = false;
            if(cli is not null)
            {
                Thread.Sleep(miDelay);
                tiempoCumplido = true;
            }
            
            return tiempoCumplido;
        }

        
    }
}
