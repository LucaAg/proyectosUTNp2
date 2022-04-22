using System;
using System.Collections.Generic;

namespace BibliotecaClase07EjI02
{
    public class Libro
    {
        private List<string> paginas; // instancio mi paginas de libro.

        public Libro()
        {
            this.paginas = new List<string>(); // inicializo mi lista de paginas del libro.
        }

        public int ObtengoIndex // funcion que me devuelve la cantidad de paginas, solo para corroborar error.
        {
            get { return this.paginas.Count; }
        }
        public string this [int index]
        {
            get
            {
                if(index >= 0 && index < this.paginas.Count) // vlaido quye el index sea mayor o igual a 0 y que este en rango.
                {
                    return paginas[index];
                }
                return string.Empty; // si no se enceuntra en rango devuelvo un string vacio.
            }
            set
            {
                if (index > this.paginas.Count)
                {                
                    this.paginas.Add(value);  // si el indice esta dentro de las paginas, lo agrego
                    //paginas[index] = value; esto no funciona porque estoy trabajando en una lista
                }
                else if(index >=0)
                {
                    this.paginas.Insert(index, value); // si el indice es superior a las paginas, lo inserto en una nueva
                }
                    
            }
        }
    }
}
