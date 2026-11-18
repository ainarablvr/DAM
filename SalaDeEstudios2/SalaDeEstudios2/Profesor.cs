using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeEstudios2
{
    public class Profesor : Usuario
    {
        public Profesor (string nombre) : base(nombre) { }

        public override string ToString()
        {
            return $"Profesor: {Nombre}";
        }
    }
}
