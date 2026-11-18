using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenAlmacen_AinaraBelver
{
    internal class Existencia : Articulo
    {
        
        public Existencia(int cod, string nombre, int cant) : base(cod, nombre, cant)
        {
            //CONSTRUCTOR, NO MENCIONADO EN LA HOJA PERO NECESARIO PARA LA CREACION
        }

        public override string ToString()
        {
            return $"EXISTENCIAS: CODIGO({cod}), NOMBRE({nombre}), CANTIDAD({cant})";
        }
    }
}
