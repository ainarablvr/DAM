using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeEstudios2
{
    internal class SalaEstudio : IConsultable
    {

        //VARIABLES
        List<Usuario> usuarios = new List<Usuario>();
        Usuario[,] sala = new Usuario[4, 5];
        Stack<(Usuario usu, int f, int c)> reservas = new Stack<(Usuario, int, int)>();
        int cambios = 0, libres = 25, reservados = 0;


        public void MostrarMenu()
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

        public void registrarUsuario()
        {
            Console.WriteLine("Introduzca un nombre:");
            string nom = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nom)) //SI EL NOMBRE NO ES NULO LO GUARDAMOS
            {
                Console.Write("Tipo (1. Alumno / 2. Profesor): ");
                string tipo = Console.ReadLine();

                if (tipo == "1")
                {
                    usuarios.Add(new Alumno(nom));
                    Console.WriteLine("Alumno registrado");
                }
                else if (tipo == "2")
                {
                    usuarios.Add(new Profesor(nom));
                    Console.WriteLine("Alumno registrado");
                }

                else Console.WriteLine("Tipo no válido.");
            }
            else
            {
                Console.WriteLine("El nombre no puede estar vacío.");
            }
            Console.WriteLine();
        }

        public void mostrarUsuariosRegistrados()
        {
            Console.WriteLine("\n--- USUARIOS ---");
            for (int i = 0; i < usuarios.Count; i++)
                Console.WriteLine($"{i + 1}. {usuarios[i]}");

            Console.WriteLine($"Total: {usuarios.Count}");
        }

        public void mostrarEstadoSala()
        {
            Console.WriteLine("\n--- ESTADO SALA ---");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(sala[i, j] == null ? "[ L ] " : "[ R ] ");
                Console.WriteLine();
            }
        }

        public void reservarPuesto()
        {
            if (usuarios.Count == 0) { 
                Console.WriteLine("No hay usuarios."); 
            }

            mostrarUsuariosRegistrados();
            Console.Write("Número de usuario: ");
            int pos = int.Parse(Console.ReadLine()) - 1;

            if (pos < 0 || pos >= usuarios.Count) { 
                Console.WriteLine("Usuario no válido."); 
            }

            Usuario u = usuarios[pos];

            // Validar si ya tiene reserva
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 5; j++)
                    if (sala[i, j] == u) { 
                        Console.WriteLine("El usuario ya tiene reserva."); 
                    }

            Console.Write("Fila (0-3): ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Columna (0-4): ");
            int col = int.Parse(Console.ReadLine());

            if (sala[fila, col] != null) { 
                Console.WriteLine("Puesto ocupado."); 
            }

            sala[fila, col] = u;
            reservas.Push((u, fila, col));
            Console.WriteLine("Reserva realizada.");
            libres--;
            reservados++;
        }

        public void consultarReserva(string nombre)
        {
            Usuario usuarioBuscado = null;

            // Buscar si el usuario existe
            foreach (Usuario u in usuarios)
            {
                if (u.Nombre.Equals(nombre))
                {
                    usuarioBuscado = u;
                }
            }

            if (usuarioBuscado == null)
            {
                Console.WriteLine("El usuario no existe.");
            }

            // Buscar si tiene reserva
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (sala[i, j] == usuarioBuscado)
                    {
                        Console.WriteLine($"El usuario tiene una reserva en la Fila {i}, Columna {j}.");
                    }
                }
            }

            Console.WriteLine("El usuario no tiene ninguna reserva."); Console.WriteLine("No se encontraron reservas activas.");
        }
        

        public void deshacerUltimaReserva()
        {
            if (reservas.Count > 0)
            {
                var ult = reservas.Pop();
                if (sala[ult.f, ult.c] == ult.usu)
                {
                    sala[ult.f, ult.c] = null;
                    Console.WriteLine($"Reserva de {ult.usu.Nombre} cancelada.");
                    cambios++;
                    libres++;
                    reservados--;
                }
            }
            else Console.WriteLine("No hay reservas para deshacer.");
        }

        public void mostrarResumenOcupacion()
        {
            Console.WriteLine($"\nTotal Libres: {libres} | Total Reservados: {reservados} | Total cambios: {cambios}");
        }
    }
}
