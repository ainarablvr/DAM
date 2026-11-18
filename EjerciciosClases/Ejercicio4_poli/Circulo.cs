using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4_poli
{
    internal class Circulo : Figura
    {

        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double calcularArea()
        {
            return Math.PI * Radio * Radio;
        }

    }
}
