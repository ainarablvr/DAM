namespace PracticaTema2_AinaraBelver
{
    public partial class Form1 : Form
    {
        public List<Alumno> alumnos = new List<Alumno>();
        public List<Libro> libros = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuRegistrar_Click(object sender, EventArgs e)
        {
           Registrar_Alumno regAlu = new Registrar_Alumno(this);
            regAlu.Show();
            this.Hide();
        }

        private void mnuRegistrarLibro_Click(object sender, EventArgs e)
        {
            Registrar_Libro regLib = new Registrar_Libro(this);
            regLib.Show();
            this.Hide();
        }
    }
}
