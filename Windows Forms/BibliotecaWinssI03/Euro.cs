using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWinssI03
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 0.92;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            //this.cantidad = cantidad;
            Euro.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Dolar.GetCotizacion() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad * Pesos.GetCotizacion() / Euro.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e == (Euro)d);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == (Euro)d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return (e == (Euro)p);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == (Euro)p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).GetCantidad());
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).GetCantidad());
        }

        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }

    }
}
