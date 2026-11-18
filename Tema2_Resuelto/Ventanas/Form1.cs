// =====================================================================
//  Ventanas  ·  6.1 (Show / ShowDialog) y 6.2 (enviar datos y regresar)
// =====================================================================
//  Un formulario es una CLASE. Para abrir una ventana hay que crear un
//  OBJETO con new:  new FormDetalle(...)
//  Dos "new" = dos ventanas distintas aunque tengan el mismo diseño.
//
//  Show()           -> NO MODAL: la principal sigue usable y el código
//                      continúa SIN esperar.
//  ShowDialog(this) -> MODAL: bloquea la principal y el código ESPERA
//                      hasta que se cierre la secundaria.
//
//  Hide()  -> oculta (sigue existiendo, con sus datos).
//  Close() -> cierra. Si cierras la principal, se acaba el programa.
// =====================================================================
namespace Ventanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoModal_Click(object sender, EventArgs e)
        {
            // 6.2: enviamos el nombre al constructor de FormDetalle.
            // Se envía el texto de ESTE momento: si luego cambias la casilla,
            // la ventana ya abierta no cambia.
            FormDetalle detalle = new FormDetalle(txtNombre.Text.Trim());
            detalle.Show();

            // EJERCICIO 6.1-1 (observación): esta línea se ejecuta AL MOMENTO,
            // sin esperar a que cierres la secundaria.
            lblEstado.Text = "No modal abierta: el código siguió sin esperar.";
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            // using -> libera la ventana al terminar. Vale con ShowDialog porque
            // espera. NO lo uses con Show(): destruiría la ventana enseguida.
            using FormDetalle detalle = new FormDetalle(txtNombre.Text.Trim());
            detalle.ShowDialog(this);   // "this" = esta ventana es la dueña

            // EJERCICIO 6.1-2: esto solo se ejecuta DESPUÉS de cerrar la modal
            // (también si la cierras con la X).
            lblEstado.Text = "La secundaria modal ha terminado.";
        }

        // 6.2  Ocultar la principal y volver a ELLA MISMA
        private void btnOcultar_Click(object sender, EventArgs e)
        {
            // Pasamos "this" (esta misma ventana), NO new Form1():
            // new Form1() crearía OTRA principal vacía.
            FormRegreso ventana = new FormRegreso(this);
            ventana.Show();
            Hide();   // ocultar, no cerrar (cerrar acabaría el programa)
        }
    }
}
