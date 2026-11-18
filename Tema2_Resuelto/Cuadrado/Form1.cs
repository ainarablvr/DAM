// =====================================================================
//  Cuadrado  ·  7.1 Ejercicio 1 (página 56)
// =====================================================================
//  Recorrido de los datos:
//    TextBox (texto)  --TryParse-->  int (número)  --cálculo-->
//    long (número)  --ToString()-->  TextBox (texto)
// =====================================================================
namespace Cuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Escribe un número entero válido.");
                txtNumero.Focus();
                return;
            }
            // (long) convierte ANTES de multiplicar. long admite números
            // mucho más grandes que int. Si multiplicásemos como int, un
            // número grande "se desbordaría" (daría un resultado erróneo).
            long cuadrado = (long)numero * numero;
            txtResultado.Text = cuadrado.ToString();   // número -> texto
        }

        // AMPLIACIÓN: Limpiar. Fíjate: txtResultado está Enabled = false
        // y aun así el CÓDIGO puede cambiarlo. Enabled solo limita a la persona.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtResultado.Clear();
            txtNumero.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Pruebas: 5 -> 25 · -5 -> 25 · 0 -> 0
        // Rechazados: vacío, "abc", "3,5" (no son enteros)
    }
}
