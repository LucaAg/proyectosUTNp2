using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWinssI03
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Pesos()
        {
            Pesos.cotzRespectoDolar = 102.65;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            //this.cantidad = cantidad;
            Pesos.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotzRespectoDolar;
        }

        public static explicit operator Dolar(Pesos e)
        {
            return new Dolar((e.cantidad * Dolar.GetCotizacion()) / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos e)
        {
            return new Euro(e.cantidad * Euro.GetCotizacion() / Pesos.GetCotizacion());
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return (p == (Pesos)d);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == (Pesos)d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return (p == (Pesos)e);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == (Pesos)e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).GetCantidad());
        }

        public static void SetCotizacion(double cotizacion)
        {
            Pesos.cotzRespectoDolar = cotizacion;
        }
    }
}
