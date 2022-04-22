using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase04EjI04
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            //productos = new Producto[capacidad];
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder datosEstante = new StringBuilder("DATOS ESTANTE: \n");
            foreach (Producto unProducto in e.productos)
            {
                datosEstante.AppendLine($"{Producto.MostrarProducto(unProducto)}");
            }
            datosEstante.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");

            return datosEstante.ToString();
        }

        public static bool operator == (Estante e, Producto p)
        {
            bool está = false;

            /* for (int i = 0; i < e.productos.Length; i++)
             {
                 if(e.productos[i] == p)
                 {
                     está = true;
                 }
             }*/
            foreach (Producto unProducto in e.productos)    
            {
                if (unProducto is not null)
                {
                    if(unProducto == p)
                    {
                        está = true;
                        break;
                    }
                }
            }
            return está;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool sePuede = false;
            if(e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        sePuede = true;
                        break;
                    }
                }
            }
            return sePuede;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }
    }
}
