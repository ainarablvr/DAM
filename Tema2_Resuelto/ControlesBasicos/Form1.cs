// =====================================================================
//  ControlesBasicos  ·  Apartados 3.1 (TextBox) y 3.2 (CheckBox)
// =====================================================================
//  TextBox con propiedades útiles (se ponen en el diseñador, F4):
//    Multiline = true   -> varias líneas (luego puedes hacerlo más alto)
//    ScrollBars         -> barra de desplazamiento
//    ReadOnly = true    -> NO se puede editar, pero SÍ seleccionar y copiar
//    Enabled  = false   -> gris, no se puede ni tocar
//    TextAlign = Right  -> números alineados a la derecha
//
//  OJO: Enabled/ReadOnly solo limitan a la PERSONA. El código sí puede
//  cambiar el Text de un control deshabilitado.
// =====================================================================
namespace ControlesBasicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // EJERCICIO 3.1-1: un resultado de solo lectura (ReadOnly = true,
            // Enabled = true). Le damos el texto DESDE EL CÓDIGO.
            // Pruébalo: lo puedes seleccionar y copiar (Ctrl+C) pero no editar.
            // Compáralo con txtResultado (Enabled = false): ese ni se selecciona.
            txtResultadoCopiable.Text = "125";
        }

        // 3.1  Limpiar la entrada y dejar el cursor listo
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
            txtEntrada.Focus();
        }

        // EJERCICIO 3.1-2: copiar la entrada a otro TextBox multilínea
        // de solo lectura. Los saltos de línea se conservan.
        private void btnCopiarEntrada_Click(object sender, EventArgs e)
        {
            txtCopia.Text = txtEntrada.Text;
        }

        // =============================================================
        // 3.2  CHECKBOX = decisiones INDEPENDIENTES
        // =============================================================
        // Checked es true (marcada) o false (desmarcada).
        // Varias CheckBox pueden estar marcadas a la vez.

        // CheckedChanged salta al marcar/desmarcar.
        // Asignamos directamente: marcada -> habilitado; desmarcada -> no.
        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            txtDato.Enabled = chkHabilitar.Checked;
        }

        // && significa "Y": solo bloquea si la casilla está marcada
        // Y ADEMÁS la tecla es un 0. Los paréntesis agrupan las dos teclas.
        private void txtDato_KeyDown(object sender, KeyEventArgs e)
        {
            if (chkBloquearCero.Checked &&
                (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0))
            {
                e.SuppressKeyPress = true;
            }
        }

        // EJERCICIO 3.2-2: solo lectura.
        // Diferencia que vas a ver:
        //   ReadOnly -> fondo gris claro, puedes seleccionar/copiar.
        //   Enabled = false -> todo gris, no puedes ni seleccionar.
        private void chkSoloLectura_CheckedChanged(object sender, EventArgs e)
        {
            txtDato.ReadOnly = chkSoloLectura.Checked;
        }

        // EJERCICIO 3.2-1 (prueba las 4 combinaciones):
        //   Permitir SÍ + Bloquear NO  -> se escribe y acepta el 0 ("102")
        //   Permitir SÍ + Bloquear SÍ  -> se escribe pero sin 0  ("12")
        //   Permitir NO + Bloquear NO  -> no se puede escribir
        //   Permitir NO + Bloquear SÍ  -> no se puede escribir
        // Al volver a permitir, "Bloquear cero" conserva su estado:
        // son independientes.
    }
}
