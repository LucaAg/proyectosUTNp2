using System;
using System.Text;

namespace BibliotecaClase3EjI01
{
    public class Cuenta
    {
        private string titular; // todos los atributos deben ser privados
        private Single cantidad; // "" ""
        public Cuenta(string nombreTitular, Single cantidadTitular)
        {
            this.titular = nombreTitular;
            this.cantidad = cantidadTitular;
        }

        public string BuscarTitular()
        {
            return this.titular;
        }

        public Single BuscarCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder datosCuenta = new StringBuilder("Datos cuenta: \n");
            datosCuenta.AppendLine($"Titular: {BuscarTitular()}");
            datosCuenta.AppendLine($"Cantidad: {BuscarCantidad()}");

            return datosCuenta.ToString();
        }

        public void Ingresar(Single montoIngresado)
        {
            if(montoIngresado > 0)
            {
                this.cantidad += montoIngresado;
            }
        }

        public void Retirar(Single retirarMonto)
        {
            if(retirarMonto > 0 )
            {
                this.cantidad -= retirarMonto;
            }
        }
    }
}
