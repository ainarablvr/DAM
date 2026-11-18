// =====================================================================
//  EJERCICIO 1.1-1  ·  VentanaPrueba
// =====================================================================
//  Lo único que pide: crear un proyecto nuevo y cambiar el título.
//  El título NO se cambia aquí con código: se cambia en el diseñador,
//  seleccionando el fondo del formulario > F4 > propiedad Text.
//  (Aquí ya está puesto "Ventana de prueba"; míralo en Form1.Designer.cs,
//   en la línea  Text = "Ventana de prueba";)
//
//  Pulsa F5: se abre una ventana vacía con ese título.
// =====================================================================
namespace VentanaPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // InitializeComponent() crea los controles que dibujaste en el
            // diseñador. Siempre debe ser lo primero del constructor.
            InitializeComponent();
        }
    }
}
