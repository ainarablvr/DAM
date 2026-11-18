using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeEstudios2
{
    public class Alumno : Usuario
    {
        public Alumno(string nombre) : base(nombre)
        {
        }

        public override string ToString()
        {
            return $"Alumno: {Nombre}";
        }
    }
}
