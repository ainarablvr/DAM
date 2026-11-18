// =====================================================================
//  FormDetalle  ·  segunda ventana (Agregar > Windows Form)
// =====================================================================
//  CONSTRUCTOR = método que se ejecuta al hacer "new". Se llama igual
//  que la clase y no tiene tipo de retorno.
//  Le añadimos un PARÁMETRO (string nombre) para RECIBIR un dato.
// =====================================================================
namespace Ventanas
{
    public partial class FormDetalle : Form
    {
        public FormDetalle(string nombre)
        {
            InitializeComponent();          // siempre primero
            lblSaludo.Text = "Hola, " + nombre;

            // EJERCICIO 6.2-1: longitud del nombre recibido.
            // Abre con "Ana" (3) y con "Alejandro" (9): cada ventana
            // guarda los datos de cuando se abrió.
            lblLongitud.Text = "Longitud del nombre: " + nombre.Length;
        }

        // EJERCICIO 6.1-1: cada ventana tiene su propio txtNotas.
        // Abre dos no modales y escribe algo distinto en cada una:
        // son objetos diferentes.

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();   // cierra SOLO esta ventana
        }
    }
}
