using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase07EjI01
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n,Cliente c)
        {
            bool estaEnCola = false;
            foreach (Cliente cliente in n.clientes)
            {
                if(cliente == c)
                {
                    estaEnCola = true;
                    break;
                }
            }
            return estaEnCola;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n,Cliente c)
        {
            bool seSumoALista = false;
            if(n != c)
            {
                n.clientes.Enqueue(c);
                seSumoALista = true;
            }
            return seSumoALista;
        }
        
        public static bool operator ~(Negocio n)
        {
            bool sePudoAtender = false;
            if(n.clientes.Count > 0  && n.caja.Atender(n.Cliente)) //  usar el propiedad count.
            {
                sePudoAtender = true;
            }
            return sePudoAtender;
        }
        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set { _ = this + value; }
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }


    }
}
