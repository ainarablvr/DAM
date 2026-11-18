// =====================================================================
//  FormRegreso  ·  6.2 volver a la MISMA ventana principal
// =====================================================================
//  Recibe una REFERENCIA a la principal (no una copia): es "el mando a
//  distancia" de la ventana que ya existe. Con ella puede volver a
//  mostrarla.
// =====================================================================
namespace Ventanas
{
    public partial class FormRegreso : Form
    {
        // Campo donde guardamos la referencia recibida.
        // readonly = solo se asigna en el constructor.
        private readonly Form1 principal;

        public FormRegreso(Form1 origen)
        {
            InitializeComponent();
            principal = origen;
            // FormClosed salta al cerrar por CUALQUIER camino:
            // el botón Cerrar o la X. Así no se nos olvida ninguno.
            FormClosed += FormRegreso_FormClosed;
        }

        private void FormRegreso_FormClosed(object? sender, FormClosedEventArgs e)
        {
            principal.Show();       // vuelve a verse
            principal.Activate();   // y se pone delante
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // EJERCICIO 6.2-2: escribe un nombre en la principal, pulsa
        // "Abrir y ocultar" y vuelve con Cerrar; repite con la X.
        // El nombre sigue ahí y no aparecen principales nuevas.
    }
}
