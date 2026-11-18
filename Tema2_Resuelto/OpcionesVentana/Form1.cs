// =====================================================================
//  OpcionesVentana  ·  Apartado 3.3 (RadioButton y contenedores)
// =====================================================================
//  RadioButton = elegir UNA opción de un grupo. Al marcar una, se
//  desmarcan las demás DEL MISMO CONTENEDOR.
//
//  Por eso hay 2 GroupBox: uno responde "¿qué tamaño?" y otro
//  "¿qué estado?". Si todos estuvieran sueltos en el formulario,
//  al elegir "Maximizada" se desmarcaría la resolución.
//
//  Truco: si mueves el GroupBox en el diseñador y los RadioButton se
//  mueven con él, están DENTRO. También lo ves en
//  Ver > Otras ventanas > Esquema del documento.
// =====================================================================
namespace OpcionesVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            // 1º volvemos a Normal (si está maximizada no se puede cambiar el tamaño)
            WindowState = FormWindowState.Normal;

            // 2º aplicamos el tamaño. ClientSize = zona interior, sin el marco.
            if (rb640.Checked) ClientSize = new Size(640, 480);
            else if (rb800.Checked) ClientSize = new Size(800, 600);
            else if (rb900.Checked) ClientSize = new Size(900, 650);   // EJERCICIO 3.3-1
            else ClientSize = new Size(1024, 768);

            // 3º aplicamos el estado.
            // condición ? valorSiSí : valorSiNo   (un if/else en una línea)
            WindowState = rbMaximizada.Checked
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        // EJERCICIO 3.3-2: pnlPrueba es un Panel con 2 RadioButton.
        // Comprueba que A y B se excluyen entre sí, pero NO afectan a los
        // GroupBox (cada contenedor es un grupo distinto).
        // El libro pide BORRARLO al terminar: selecciónalo en el diseñador
        // y pulsa Supr.
    }
}
