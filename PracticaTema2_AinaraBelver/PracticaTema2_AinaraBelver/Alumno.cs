using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaTema2_AinaraBelver
{
    public class Alumno
    {
        public string matricula { get; set; } = "";

        public string nombre { get; set; } = "";

        public string apellido { get; set; } = "";

        public string grupo { get; set; } = "";

        public Alumno(string matricula, string nombre, string apellido, string grupo)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.grupo = grupo;
        }

        public override string ToString()
        {
            return "matricula: " + matricula + "nombre: " + nombre + "apellido: " + apellido + "grupo: " + grupo;
        }



    }
}
