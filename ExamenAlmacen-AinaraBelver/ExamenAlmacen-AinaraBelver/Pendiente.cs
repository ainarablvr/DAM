using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenAlmacen_AinaraBelver
{
    internal class Pendiente : Articulo
    {
        public Pendiente(int cod, string nombre, int cant) : base(cod, nombre, cant)
        {
            //CONSTRUCTOR, NO MENCIONADO EN LA HOJA PERO NECESARIO PARA LA CREACION
        }

        public override string ToString()
        {
            return $"PENDIENTES: CODIGO({cod}), NOMBRE({nombre}), CANTIDAD({cant})";
        }
    }
}
