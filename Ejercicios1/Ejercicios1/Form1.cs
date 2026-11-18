namespace Ejercicios1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDespedir_Click(object sender, EventArgs e)
        {
            btnDespedir.Text = "Chao";
            txtSaludo.Text = "Venga chao " + txtNombre.Text;
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            btnProbar.Size = new Size(160, 40);
            btnProbar.Location = new Point(30, 30);
            btnProbar.Text = "Mostar Mensaje";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = true;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
