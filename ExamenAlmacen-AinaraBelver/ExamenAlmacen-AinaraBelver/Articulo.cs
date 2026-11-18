using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExamenAlmacen_AinaraBelver
{
    internal abstract class Articulo
    {
        public int cod;
        public string nombre;
        public int cant;

        public Articulo(int cod, string nombre, int cant)
        {
            this.cod = cod;
            this.nombre = nombre;
            this.cant = cant;
        }

        public abstract override string ToString();
    }
}
