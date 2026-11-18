using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeEstudios2
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public abstract override string ToString();
    }
}
