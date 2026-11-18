using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.Producto
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, int precio, int stock)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }

        public void  MostrarFicha()
        {
            Console.WriteLine($"Nombre: {Nombre}, precio: {Precio} y stock: {Stock} ");

        }
    }
}
