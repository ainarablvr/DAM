using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5_poli
{
    internal class Factura : Imprimible
    {
        public string NumeroFactura { get; set; }

        public Factura(string numeroFactura)
        {
            NumeroFactura = numeroFactura;
        }

        public void imprimir()
        {
            Console.WriteLine($"Factura N°: {NumeroFactura}");
        }
    }
}
