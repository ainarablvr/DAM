using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_Poli
{
    internal class Persona
    {
    

        public string nombre { get; set; }
        public int edad { get; set; }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public virtual void mostrarDatos()
        {
            Console.WriteLine($"Nombre: {nombre}, edad: {edad}");
        }

    }
}
