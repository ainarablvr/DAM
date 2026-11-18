// =====================================================================
//  ListasCiudades  ·  Apartado 3.4 (ListBox y ComboBox)
// =====================================================================
//  ListBox  -> muestra varias filas a la vez.
//  ComboBox -> una línea con flecha. DropDownStyle = DropDownList
//              obliga a elegir de la lista (no deja escribir).
//
//  Items          -> las opciones que contiene
//  Items.Count    -> CUÁNTAS opciones hay
//  SelectedIndex  -> QUÉ POSICIÓN está elegida (la primera es 0;
//                    -1 = ninguna seleccionada)
//  SelectedItem   -> el elemento elegido
//  Count y SelectedIndex son cosas distintas: puede haber 2 ciudades
//  y ninguna seleccionada.
// =====================================================================
namespace ListasCiudades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cargamos las opciones por código con Items.Add
            lstCiudades.Items.Add("Cuenca");
            lstCiudades.Items.Add("Albacete");
            cmbTurno.Items.Add("Mañana");
            cmbTurno.Items.Add("Tarde");
            cmbTurno.Items.Add("Noche");     // EJERCICIO 3.4-3
            cmbTurno.SelectedIndex = 0;      // empieza en "Mañana"
            lstCiudades.SelectedIndex = -1;  // ninguna ciudad elegida

            MostrarSeleccion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.Trim();
            if (ciudad.Length == 0)          // validar: no aceptar vacío
            {
                MessageBox.Show("Escribe una ciudad.");
                txtCiudad.Focus();
                return;
            }
            lstCiudades.Items.Add(ciudad);
            txtCiudad.Clear();
            txtCiudad.Focus();
            MostrarSeleccion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // SIEMPRE comprobar que hay algo seleccionado antes de usarlo.
            // Si no, RemoveAt(-1) haría que el programa fallase.
            if (lstCiudades.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una ciudad.");
                return;
            }
            lstCiudades.Items.RemoveAt(lstCiudades.SelectedIndex);
            MostrarSeleccion();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (lstCiudades.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una ciudad.");
                return;
            }
            // El "!" le dice al compilador "tranquilo, aquí no es null"
            // (ya lo hemos comprobado arriba).
            MessageBox.Show(lstCiudades.SelectedItem!.ToString());
        }

        // UN SOLO método conectado al SelectedIndexChanged de los DOS
        // controles (lstCiudades y cmbTurno). Míralo en el rayo de cada uno.
        private void Seleccion_Cambiada(object sender, EventArgs e)
        {
            MostrarSeleccion();
        }

        // Método "auxiliar" propio: no es de ningún evento, lo llamamos
        // nosotros desde varios sitios para no repetir código.
        private void MostrarSeleccion()
        {
            // ?.  -> si SelectedItem es null, no intenta ToString()
            // ??  -> si el resultado es null, usa "ninguna"
            string ciudad = lstCiudades.SelectedItem?.ToString() ?? "ninguna";
            string turno = cmbTurno.SelectedItem?.ToString() ?? "ninguno";
            lblSeleccion.Text = "Ciudad: " + ciudad + "; turno: " + turno
                + "; ciudades disponibles: " + lstCiudades.Items.Count;
        }

        private void btnSinSeleccion_Click(object sender, EventArgs e)
        {
            lstCiudades.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;
            MostrarSeleccion();   // el total NO cambia: las ciudades siguen ahí
        }

        // EJERCICIO 3.4-2: vaciar la lista completa
        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            lstCiudades.Items.Clear();
            MostrarSeleccion();   // total = 0
        }

        // EJERCICIO 3.4-3: quitar SOLO la selección de la ciudad (el turno se queda)
        private void btnQuitarCiudad_Click(object sender, EventArgs e)
        {
            lstCiudades.SelectedIndex = -1;
            MostrarSeleccion();
        }

        // EJERCICIO 3.4-1 (prueba): agrega, selecciona, consulta, elimina.
        // Luego quita la selección e intenta consultar/eliminar:
        // debes ver avisos, NO un cierre del programa.
    }
}
