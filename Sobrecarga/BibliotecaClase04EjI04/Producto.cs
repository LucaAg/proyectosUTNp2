using System;
using System.Text;

namespace BibliotecaClase04EjI04
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder datosProducto = new StringBuilder("Datos del producto: \n");
            datosProducto.AppendLine($"Codigo de barra: {p.codigoDeBarra}");
            datosProducto.AppendLine($"Marca: {p.marca}");
            datosProducto.AppendLine($"Precio: {p.precio}");

            return datosProducto.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            return p1.marca == marca;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }
}
