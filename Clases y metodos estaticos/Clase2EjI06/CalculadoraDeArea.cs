using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjI06
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado = (double)Math.Pow(longitudLado, 2);
            return areaCuadrado;
        }
        
        public static double CalcularAreaTriangulo(double baseTri, double altura)
        {
            double areaTriangulo = (baseTri * altura) / 2;
            return areaTriangulo;
        }
        
        public static double CalcularAreaCirculo(double radio)
        {
            double areaCirculo = (double)Math.Pow(radio, 2) * Math.PI;
            return areaCirculo;
        }
    }
}
