using SalaDeEstudios2;

internal class Program
{
    private static void Main(string[] args)
    {
        SalaEstudio sala = new SalaEstudio();
        int opc;

        do
        {
            sala.MostrarMenu();
            Console.WriteLine("Elige una opción:");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: sala.registrarUsuario(); break;
                case 2: sala.mostrarUsuariosRegistrados(); break;
                case 3: sala.mostrarEstadoSala(); break;
                case 4: sala.reservarPuesto(); break;
                case 5:
                    Console.Write("Nombre a buscar: ");
                    string nom = Console.ReadLine();
                    sala.consultarReserva(nom);
                    break;
                case 6: sala.deshacerUltimaReserva(); break;
                case 7: sala.mostrarResumenOcupacion(); break;
            }
        } while (opc != 0);
    }
}
