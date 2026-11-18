using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_Poli
{
    internal class Alumno : Persona
    {
       

        public string ciclo { get; set; }
        public double nota { get; set; }

        public Alumno(string nombre, int edad, string ciclo, double nota) : base (nombre, edad )
        {
            this.ciclo = ciclo;
            this.nota = nota;
        }

        public override void mostrarDatos()
        {

            base.mostrarDatos();
            Console.WriteLine($"Ciclo: {ciclo}, nota: {nota}");

        }
    }
}
