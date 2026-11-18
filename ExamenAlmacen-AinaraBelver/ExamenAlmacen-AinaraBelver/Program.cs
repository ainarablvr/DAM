namespace ExamenAlmacen_AinaraBelver
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int opc;
            Almacen almacen = new Almacen();
            almacen.iniciar();
            do
            {
                mostrarMenu();
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: almacen.consultar(); break;
                    case 2:
                        Console.WriteLine("Introduce el codigo: ");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la cantidad a sacar: ");
                        int cantidad = int.Parse(Console.ReadLine());
                        almacen.retirar(codigo, cantidad); break;
                    case 3:
                        Console.WriteLine("Introduce el codigo: ");
                        int cod = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la cantidad a añadir: ");
                        int cant = int.Parse(Console.ReadLine());
                        almacen.reponer(cod, cant);
                        break;
                    case 0: Console.WriteLine("Saliendo del programa..."); break;

                }
            } while (opc != 0);
        }

        public static void mostrarMenu()
        {
            Console.WriteLine("\n---ALMACÉN---");
            Console.WriteLine("1. Consultar almacén");
            Console.WriteLine("2. Retirar unidades");
            Console.WriteLine("3. Reponer unidades");
            Console.WriteLine("0. Salir ");
        }
    }
}