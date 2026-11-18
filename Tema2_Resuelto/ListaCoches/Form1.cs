// =====================================================================
//  ListaCoches  ·  Apartado 3.5 (listas de objetos)
// =====================================================================
//  Ahora los datos están en una List<Coche> (la "lista de verdad")
//  y el ListBox solo la ENSEÑA:
//      lstCoches.DataSource = coches;   -> enlaza la vista con los datos
//
//  Una List normal no avisa al ListBox cuando añades o quitas algo.
//  Por eso, tras cambiarla, "desenchufamos" (null) y "enchufamos" otra vez.
// =====================================================================
namespace ListaCoches
{
    public partial class Form1 : Form
    {
        // Campo: la lista existe mientras exista la ventana
        private List<Coche> coches = new List<Coche>();

        public Form1()
        {
            InitializeComponent();

            coches.Add(new Coche { Marca = "Seat", Modelo = "Ibiza", Color = "Rojo" });
            coches.Add(new Coche { Marca = "Renault", Modelo = "Clio", Color = "Blanco" });
            lstCoches.DataSource = coches;
            lstCoches.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string color = txtColor.Text.Trim();          // EJERCICIO 3.5-2
            if (marca.Length == 0 || modelo.Length == 0)
            {
                MessageBox.Show("Escribe marca y modelo.");
                return;
            }
            // Se añade a la LISTA DE DATOS, no a lstCoches.Items
            coches.Add(new Coche { Marca = marca, Modelo = modelo, Color = color });
            ActualizarCoches();
            // (Si comentas la línea de arriba con //, verás que la fila nueva
            //  no aparece: la lista cambia, pero la vista no se entera.)
            txtMarca.Clear();
            txtModelo.Clear();
            txtColor.Clear();
            txtMarca.Focus();
        }

        // Volver a enlazar la vista con los datos
        private void ActualizarCoches()
        {
            lstCoches.DataSource = null;
            lstCoches.DataSource = coches;
            // Al poner DataSource a null se pierde DisplayMember,
            // así que lo volvemos a aplicar según la casilla.
            lstCoches.DisplayMember = chkSoloMarca.Checked ? "Marca" : "";
            lstCoches.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // "is not Coche coche": si lo seleccionado NO es un Coche (o no hay
            // nada), entra en el if. Si SÍ lo es, lo guarda en la variable coche.
            if (lstCoches.SelectedItem is not Coche coche)
            {
                MessageBox.Show("Selecciona un coche.");
                return;
            }
            // Obtenemos el objeto completo: también datos que NO se ven en la fila
            MessageBox.Show("Marca: " + coche.Marca
                + Environment.NewLine + "Modelo: " + coche.Modelo
                + Environment.NewLine + "Color: " + coche.Color);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCoches.SelectedItem is not Coche coche)
            {
                MessageBox.Show("Selecciona un coche.");
                return;
            }
            // EJERCICIO 3.5-3: Remove quita ESE objeto concreto, no todos
            // los de la misma marca.
            coches.Remove(coche);
            ActualizarCoches();
        }

        // EJERCICIO 3.5-1: DisplayMember = "Marca" -> la fila solo enseña
        // la marca. Agrega dos "Seat" de distinto modelo y consulta ambos:
        // cada uno conserva su modelo (el objeto no ha cambiado, solo la vista).
        private void chkSoloMarca_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCoches();
        }
    }
}
