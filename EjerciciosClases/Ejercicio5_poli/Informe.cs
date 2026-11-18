using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5_poli
{
    internal class Informe : Imprimible
    {
        public string Titulo { get; set; }

        public Informe(string titulo)
        {
            Titulo = titulo;
        }

        public void imprimir()
        {
            Console.WriteLine($"Informe: {Titulo}");
        }
    }
}
