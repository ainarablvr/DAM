using Ejercicio5_poli;

internal class Program
{
    private static void Main(string[] args)
    {
        Imprimible factura = new Factura("FAC-001");
        Imprimible informe = new Informe("Informe Anual de Ventas");

        factura.imprimir();
        informe.imprimir();
    }
}