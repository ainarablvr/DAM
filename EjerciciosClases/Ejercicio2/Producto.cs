using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    internal class Producto
    {
        int codigo { get; set; } 
        public string nombre { get; set; }
        double precio { get; set; }

        public Producto(int codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public override string ToString()
        {
            return codigo + " - " + nombre + " - " + precio;
        }

    }
}
