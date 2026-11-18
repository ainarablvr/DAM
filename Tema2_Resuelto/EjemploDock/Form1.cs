// =====================================================================
//  EjemploDock  ·  Apartado 5.2 (Dock) + ejercicio 5.2-1
// =====================================================================
//  DOCK pega un control a un borde o le hace ocupar el hueco que queda:
//    pnlCabecera -> Dock = Top    (franja arriba, altura 55)
//    pnlPie      -> Dock = Bottom (franja abajo, altura 40)  EJERCICIO 5.2-1
//    txtEditor   -> Dock = Fill   (todo lo que sobra)
//
//  Anchor = conservar márgenes.  Dock = ocupar una zona.
//
//  Si el Fill tapa la cabecera: en Esquema del documento selecciona
//  txtEditor > botón derecho > "Traer al frente". El que tiene Fill debe
//  estar delante para repartirse el espacio bien.
// =====================================================================
namespace EjemploDock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón de la franja inferior (EJERCICIO 5.2-1). Una acción sencilla:
        // Lines es un array con cada línea del TextBox multilínea.
        private void btnContarLineas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Líneas escritas: " + txtEditor.Lines.Length);
        }
    }
}
