using Clases.Persona;
using Clases.Producto;

internal class Program
{
    private static void Main(string[] args)
    {
        Producto producto = new Producto("Cerezas", 1, 20);
        Console.WriteLine($"Nombre: {producto.Nombre}, precio: {producto.Precio} y stock: {producto.Stock} ");

        Persona p1 = new Persona("aina", 19);
        Persona p2 = new Persona("ana", 20);
        Console.WriteLine($"Nombre: {p1.nombre}, edad: {p1.edad}");
        Console.WriteLine($"Nombre: {p2.nombre}, edad: {p2.edad}");
    }
}


