using System;

namespace BibliotecaWinssI03
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            //this.cantidad = cantidad;
            Dolar.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar dolares)
        {
            return new Euro(dolares.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar dolares)
        {
            return new Pesos(dolares.cantidad * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d == (Dolar)e);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == (Dolar)e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d == (Dolar)p);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == (Dolar)p);
        }

        public static bool operator ==(Dolar d, Dolar d2)
        {
            return (d.cantidad == d2.cantidad);
        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d == d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).GetCantidad());
        }
    }
}
