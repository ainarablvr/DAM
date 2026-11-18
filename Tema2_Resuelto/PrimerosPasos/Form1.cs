// =====================================================================
//  PrimerosPasos  ·  Apartados 1.2, 1.3, 1.4, 2.1, 2.2 y 2.3
// =====================================================================
//  IDEA CLAVE DEL TEMA:
//    - PROPIEDAD = cómo es algo        (Text, Enabled, Visible, BackColor...)
//    - EVENTO    = algo que ha pasado  (Click, TextChanged, KeyDown...)
//    - MÉTODO    = algo que se hace    (MessageBox.Show, Clear, Focus...)
//
//  Dibujar un botón NO le da acción. La acción es el método que se ejecuta
//  cuando ocurre su evento Click. La conexión "evento -> método" se ve en
//  el diseñador: selecciona el control > F4 > icono del RAYO.
// =====================================================================
namespace PrimerosPasos
{
    public partial class Form1 : Form
    {
        // ---------------------------------------------------------------
        // 2.1  CAMPO de la clase.
        // Está DENTRO de la clase pero FUERA de los métodos, por eso
        // "vive" mientras exista la ventana. Así MouseEnter guarda el color
        // y MouseLeave puede recuperarlo. Si lo declarase dentro de
        // MouseEnter, desaparecería al terminar ese método.
        // ---------------------------------------------------------------
        private Color colorAnterior;

        public Form1()
        {
            InitializeComponent();          // 1º se crean los controles

            // 1.4 Paso 6: icono de la ventana (esquina superior izquierda)
            Icon = SystemIcons.Information;
        }

        // =============================================================
        // 1.2  BOTONES: el primer Click
        // =============================================================
        // (Name) = btnProbar  -> nombre que se usa en el CÓDIGO
        // Text   = "Mostrar mensaje" -> lo que VE la persona
        // EJERCICIO 1.2-2: Text cambiado a "Mostrar mensaje", Size 160x40 y
        // Location 30,30 (en el diseñador). El clic sigue funcionando igual
        // porque el método depende del NOMBRE, no del texto visible.
        private void btnProbar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi primer botón");
        }

        // EJERCICIO 1.2-1: segundo botón con su propio mensaje
        private void btnDespedir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta pronto");
        }

        // =============================================================
        // 1.3 + 2.3  SALUDAR (leer, validar y mostrar)
        // =============================================================
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            // 2.3 VALIDAR: IsNullOrWhiteSpace es true si está vacío
            // o si solo tiene espacios.
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escribe tu nombre.");
                txtNombre.Focus();   // pone el cursor en la casilla
                return;              // SALE del método: no saluda
            }

            // Trim() quita los espacios del principio y del final.
            string nombre = txtNombre.Text.Trim();

            // EJERCICIO 2.3-2: rechazar nombres de menos de 2 letras.
            // Length = número de caracteres del texto.
            if (nombre.Length < 2)
            {
                MessageBox.Show("El nombre debe tener al menos 2 letras.");
                txtNombre.Focus();
                return;
            }

            // EJERCICIO 1.3-1: el saludo también se muestra en una etiqueta
            lblSaludo.Text = "Hola, " + nombre;
            MessageBox.Show("Hola, " + nombre);   // + une textos
        }

        // 1.3  LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();     // vacía la casilla
            lblSaludo.Text = "";   // EJERCICIO 1.3-2: borrar también el saludo
            txtNombre.Focus();     // el cursor vuelve a la casilla
        }

        // =============================================================
        // 1.4  CAMBIAR PROPIEDADES MIENTRAS EL PROGRAMA FUNCIONA
        // =============================================================
        // true = verdadero, false = falso.
        // WindowState sin nada delante = this.WindowState = la VENTANA.
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;                 // no se puede escribir
            lblNombre.Visible = false;                 // la etiqueta desaparece
            btnSaludar.Text = "Aceptar";               // cambia el rótulo
            txtNombre.BackColor = Color.LightYellow;   // color de fondo
            txtNombre.ForeColor = Color.DarkBlue;      // color de la letra
            WindowState = FormWindowState.Maximized;   // maximiza la ventana
        }

        // Restaurar = deshacer exactamente lo anterior
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            txtNombre.Enabled = true;
            lblNombre.Visible = true;
            btnSaludar.Text = "Saludar";
            txtNombre.BackColor = SystemColors.Window;      // colores "normales"
            txtNombre.ForeColor = SystemColors.WindowText;  // del sistema
            txtNombre.Focus();
        }

        // EJERCICIO 1.4-1: ocultar/mostrar la casilla.
        // Ocultar NO borra el texto: al mostrarla, "Ana" sigue ahí.
        private void btnOcultarNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
        }

        private void btnMostrarNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = true;
        }

        // EJERCICIO 1.4-2: minimizar. Vuelve desde la barra de tareas:
        // el nombre se conserva porque la ventana no se ha cerrado.
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // =============================================================
        // 2.1  EVENTOS: Load, TextChanged, MouseEnter, MouseLeave
        // =============================================================

        // Load = justo ANTES de que se vea la ventana por primera vez.
        // EJERCICIO 2.1-1: mi nombre y "Listo para escribir".
        private void Form1_Load(object sender, EventArgs e)
        {
            lblEstado.Text = "Listo para escribir";
            txtNombre.Text = "Ainara";
            // Al cambiar txtNombre.Text se dispara TextChanged ->
            // el espejo ya muestra "Ainara" sin pulsar ninguna tecla.
        }

        // TextChanged = cada vez que cambia el texto (escribiendo o por código)
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblEspejo.Text = txtNombre.Text;
        }

        private void btnPonerLuis_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Luis";   // también provoca TextChanged
        }

        // EJERCICIO 2.1-3: vaciar. NO tocamos lblEspejo: se vacía solo
        // porque Clear() cambia el texto y salta TextChanged.
        private void btnVaciarNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
        }

        // MouseEnter = el ratón ENTRA en la casilla (sin hacer clic)
        private void txtNombre_MouseEnter(object sender, EventArgs e)
        {
            colorAnterior = txtNombre.BackColor;     // guardo el color actual
            txtNombre.BackColor = Color.LightYellow;
            lblEstado.Text = "Puntero dentro";       // EJERCICIO 2.1-2
        }

        // MouseLeave = el ratón SALE de la casilla
        private void txtNombre_MouseLeave(object sender, EventArgs e)
        {
            txtNombre.BackColor = colorAnterior;     // recupero el guardado
            lblEstado.Text = "Puntero fuera";        // EJERCICIO 2.1-2
        }

        // =============================================================
        // 2.2  TECLADO
        // =============================================================
        // KeyDown  -> qué TECLA física se pulsa  (e.KeyCode)
        // KeyPress -> qué CARÁCTER se escribe    (e.KeyChar)
        // || significa "o".
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            // Bloquear el 0 (ejemplo) y el 1 (EJERCICIO 2.2-1),
            // tanto en la fila de arriba (D0, D1) como en el teclado numérico.
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0 ||
                e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                e.SuppressKeyPress = true;   // la tecla no llega a escribirse
            }
            // EJERCICIO 2.2-2: con Enter mostramos el nombre.
            // SuppressKeyPress evita el "pitido" de Windows.
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("Nombre: " + txtNombre.Text);
            }
            // EJERCICIO 2.2-3 (observación): si COPIAS "A0" y lo PEGAS con
            // Ctrl+V, el 0 SÍ entra. Pegar no es pulsar la tecla 0.
            // Por eso filtrar teclas NO sustituye a validar el texto final.
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // IsControl = teclas "especiales" como Retroceso (código 8)
            if (char.IsControl(e.KeyChar))
                lblEstado.Text = "Carácter de control: " + (int)e.KeyChar;
            else
                lblEstado.Text = "Carácter recibido: " + e.KeyChar;
        }

        // =============================================================
        // 2.3  CONVERTIR Y VALIDAR UNA EDAD
        // =============================================================
        // Un TextBox SIEMPRE contiene texto ("25" no es el número 25).
        // int.TryParse intenta convertir:
        //   - devuelve true/false según lo consiga
        //   - si lo consigue, deja el número en la variable que va tras "out"
        // ! = NO.  "if (!int.TryParse(...))" = "si NO se ha podido convertir"
        private void btnEdad_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Escribe una edad con números enteros.");
                txtEdad.Focus();
                return;
            }
            // EJERCICIO 2.3-1: solo de 0 a 120 (ambos incluidos)
            if (edad < 0 || edad > 120)
            {
                MessageBox.Show("La edad debe estar entre 0 y 120.");
                txtEdad.Focus();
                return;
            }
            lblResultado.Text = "Edad: " + edad;
        }
    }
}
