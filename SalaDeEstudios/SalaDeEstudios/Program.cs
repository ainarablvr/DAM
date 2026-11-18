using System;
using System.Collections.Generic;

internal class Program
{
    //VARIABLES
    private static List<string> clientes = new List<string>();
    private static string[,] sala = new string[5, 5];
    private static string cliente;
    private static int ultimaFila = -1, ultimaColumna = -1, cambios = 0, libres = 25, reservados = 0;

    private static void Main(string[] args) //MAIN
    {
        int opc;

        do
        {
            MostrarMenu();
            Console.WriteLine("Elige una opción:");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: registrarUsuario(); break;
                case 2: mostrarUsuariosRegistrados(); break;
                case 3: mostrarEstadoSala(); break;
                case 4: reservarPuesto(); break;
                case 5: consultarReservaUsuario(); break;
                case 6: deshacerUltimaReserva(); break;
                case 7: mostrarResumenOcupacion(); break;
                case 0: Console.WriteLine("Fin del programa"); break;
                default: Console.WriteLine("Opción no válida"); break;
            }
        } while (opc != 0);
    }

    private static void MostrarMenu()
    {
        Console.WriteLine("\n--- MENÚ ---");
        Console.WriteLine("1. Registrar un usuario.");
        Console.WriteLine("2. Mostrar los usuarios registrados.");
        Console.WriteLine("3. Mostrar el estado de la sala.");
        Console.WriteLine("4. Reservar un puesto.");
        Console.WriteLine("5. Consultar la reserva de un usuario.");
        Console.WriteLine("6. Deshacer la última reserva.");
        Console.WriteLine("7. Mostrar un resumen de ocupación");
        Console.WriteLine("0. Salir.");
    }

    private static void registrarUsuario()
    {
        Console.WriteLine("Introduzca un nombre:");
        string nom = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nom)) //SI EL NOMBRE NO ES NULO LO GUARDAMOS
        {
            clientes.Add(nom);
            Console.WriteLine("Cliente registrado con éxito.");
        }
        else
        {
            Console.WriteLine("El nombre no puede estar vacío.");
        }
        Console.WriteLine();
    }

    private static void mostrarUsuariosRegistrados()
    {
        int cont = 1;
        Console.WriteLine("\n--- CLIENTES REGISTRADOS ---");
        if (clientes.Count == 0)
        {
            Console.WriteLine("No hay clientes registrados.");
            return;
        }

        foreach (string c in clientes) //FOREACH PARA MOSTRAR LA LISTA CON LOS CLIENTES
        {
            Console.WriteLine($"{cont}. {c}");
            cont++;
        }
    }

    private static void mostrarEstadoSala()
    {
        Console.WriteLine("\n--- ESTADO DE LA SALA ---");
        for (int fila = 0; fila < sala.GetLength(0); fila++)
        {
            for (int columna = 0; columna < sala.GetLength(1); columna++)
            {
                if (string.IsNullOrEmpty(sala[fila, columna]))
                {
                    Console.Write("[ L ]\t"); // Libre
                }
                else
                {
                    Console.Write($"[{sala[fila, columna]}]\t"); // Ocupado
                }
            }
            Console.WriteLine();
        }
    }

    private static void reservarPuesto()
    {
        if (clientes.Count == 0)
        {
            Console.WriteLine("\nNo hay clientes registrados. Debes registrar al menos uno antes de reservar.");
            return;
        }

        mostrarUsuariosRegistrados();
        Console.WriteLine("\nElige el número del usuario que realiza la reserva:");
        int numUsuario = int.Parse(Console.ReadLine()); //elige el usuario

        if (numUsuario < 1 || numUsuario > clientes.Count)
        {
            Console.WriteLine("Número de cliente no válido.");
            return;
        }

        Console.WriteLine("Introduce la fila (de 0 a 4):"); //elegir fila
        int fila = int.Parse(Console.ReadLine());
        if (fila < 0 || fila >= 5)
        {
            Console.WriteLine("Fila incorrecta. Debe estar entre 0 y 4.");
            return;
        }

        Console.WriteLine("Introduce la columna (de 0 a 4):"); //elegir columna
        int columna = int.Parse(Console.ReadLine());
        if (columna < 0 || columna >= 5)
        {
            Console.WriteLine("Columna incorrecta. Debe estar entre 0 y 4.");
            return;
        }

        if (string.IsNullOrEmpty(sala[fila, columna]))
        {
            string usuarioActual = clientes[numUsuario - 1];
            sala[fila, columna] = " R ";

            // Guardamos las coordenadas de la última reserva
            ultimaFila = fila;
            ultimaColumna = columna;

            Console.WriteLine($"Reserva realizada con éxito para {usuarioActual} en [{fila}, {columna}]!");
            reservados++;
            libres--;
        }
        else
        {
            Console.WriteLine($"El puesto [{fila}, {columna}] ya está ocupado.");
        }
    }

    private static void consultarReservaUsuario()
    {
        Console.WriteLine("Dime el nombre del cliente: ");
        cliente = Console.ReadLine();

        bool encontrado = false;
        for (int fila = 0; fila < sala.GetLength(0); fila++)
        {
            for (int columna = 0; columna < sala.GetLength(1); columna++)
            {
                // Como guardamos " R ", comprobamos si hay reserva y si coincide el cliente buscado
                if (sala[fila, columna] == " R ")
                {
                    Console.WriteLine($"El cliente {cliente} tiene una reserva en el puesto [{fila}, {columna}].");
                    encontrado = true;
                }
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontraron reservas activas.");
        }
    }

    private static void deshacerUltimaReserva()
    {
        if (ultimaFila != -1 && ultimaColumna != -1)
        {
            sala[ultimaFila, ultimaColumna] = " L "; // Libera el puesto
            Console.WriteLine($"Se ha deshecho la última reserva en el puesto [{ultimaFila}, {ultimaColumna}].");
            ultimaFila = -1;
            ultimaColumna = -1;
            cambios++;
            libres++;
            reservados--;
        }
        else
        {
            Console.WriteLine("No hay ninguna reserva reciente que deshacer.");
        }
    }

    private static void mostrarResumenOcupacion()
    {
        Console.WriteLine("\n--- RESUMEN DE LA SALA ---");
        Console.WriteLine($"Total puestos libres: {libres}");
        Console.WriteLine($"Total puestos reservados: {reservados}");
        Console.WriteLine($"Total cambios: {cambios}");
    }
}