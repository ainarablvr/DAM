namespace PrimerosPasos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = texto.Text.Trim();
            MessageBox.Show("Hola, " + nombre);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            texto.Clear();
            texto.Focus(); //para mantener el cursor ahi
            WindowState = FormWindowState.Normal;
            lblEstado.Text = "Cambio 1";
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            texto.Enabled = false;
            txtNombre.Visible = false;
            button1.Text = "Aceptar";
            texto.BackColor = Color.Lavender;
            WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            texto.Enabled = true;
            txtNombre.Visible = true;
            texto.ForeColor = Color.HotPink;
            button1.Text = "Saludar";
            WindowState = FormWindowState.Normal;
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void texto_TextChanged(object sender, EventArgs e)
        {
            espejo.Text = texto.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            texto.Text = "Ana";
            this.Text = "Ventana preparada"; // Cambia el título de la ventana
        }
    }
}
