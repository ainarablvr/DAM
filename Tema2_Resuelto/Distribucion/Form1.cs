// =====================================================================
//  Distribucion  ·  5.1 Anchor  y  5.2 orden con Tab
// =====================================================================
//  ANCHOR (se configura en el diseñador, no con código):
//  "a qué bordes de su contenedor se queda pegado el control".
//    pnlContenido      -> Top, Bottom, Left, Right  (crece en todo)
//    txtObservaciones  -> Top, Bottom, Left, Right  (crece dentro del panel)
//    lblObservaciones  -> Top, Left (lo normal, no se mueve)
//    btnAceptar/Cancelar -> Bottom, Right (siguen en la esquina inf. derecha)
//  MinimumSize = 500 x 350 -> la ventana no se puede hacer más pequeña
//  (EJERCICIO 5.1-3: redúcela al mínimo y comprueba que nada se pisa).
//
//  EJERCICIO 5.1-2 (temporal): pon a un botón Top, Right y a una casilla
//  Top, Left, Right. Redimensiona y mira la diferencia: el botón se mueve
//  con el borde derecho; la casilla se ensancha. Luego déjalo como estaba.
//
//  TAB (5.2): TabIndex = orden al pulsar Tab (empieza en 0 en CADA
//  contenedor). Aquí: txtObservaciones -> Aceptar -> Cancelar.
//  Mayús+Tab va hacia atrás. Las Label no reciben el foco.
//  EJERCICIO 5.2-2: cambia TabIndex de Aceptar a 2 y Cancelar a 1 para
//  que Cancelar vaya antes. Pruébalo y restaura (1 y 2).
// =====================================================================
namespace Distribucion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Comprueba que la casilla sigue funcionando tras redimensionar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtObservaciones.Text);
        }

        // Close() cierra esta ventana. Como es la principal, acaba el programa.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
