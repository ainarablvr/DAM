using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Producto producto = new Producto("Cerezas", 1, 20);
        Console.WriteLine($"Nombre: {producto.Nombre}, precio: {producto.precio} y stock: {producto.stock} ");
    }
}