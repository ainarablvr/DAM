using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4_poli
{
    internal class Rectangulo : Figura
    {

        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double calcularArea()
        {
            return Ancho * Alto;
        }
    }
}
