using Ejercicio2;

internal class Program
{
    private static void Main(string[] args)
    {
        Producto pro = new Producto(347834, "queso", 2.3);
        Producto pro2 = new Producto(234474, "pavo", 3.9);
        Producto pro3 = new Producto(321434, "jamon", 2.9);
        Producto pro4 = new Producto(545654, "empanada", 3.6);
        Console.WriteLine(pro.GetType());
        Console.WriteLine(pro.GetHashCode());
        Console.WriteLine(pro.ToString());

        List<Producto> lista = new List<Producto>();
        lista.Add(pro);
        lista.Add(pro2);
        lista.Add(pro3);
        lista.Add(pro4);

        foreach(Producto p in lista)
        {
            Console.WriteLine(p);
        }

        object dato;
        dato = "Holi";
        Console.WriteLine(dato.GetType());
        dato = 100;
        Console.WriteLine(dato.GetType());
        dato = new Producto(176534, "chorizo", 1.9);
        Console.WriteLine(dato.GetType());


        if( dato is Producto producto)
        {
            Console.WriteLine(producto.nombre);
            
        }

    }
}