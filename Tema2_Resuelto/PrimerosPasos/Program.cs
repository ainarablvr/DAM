namespace PrimerosPasos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Program.cs decide qué ventana se abre al arrancar.
            // Mientras Form1 siga abierto, la aplicación sigue funcionando.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
