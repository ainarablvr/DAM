// =====================================================================
//  ImagenesEventos  ·  4.1 PictureBox · 4.2 Resize · 4.3 Arrastrar y soltar
//                      (+ ejercicio 5.1-1 de Anchor)
// =====================================================================
//  PictureBox.SizeMode:
//    Zoom         -> se ajusta SIN deformar (mantiene la proporción)
//    StretchImage -> rellena todo el hueco, pero puede DEFORMAR
//  (EJERCICIO 4.1-1: cambia SizeMode en el diseñador y compara;
//   al final déjalo en Zoom.)
//
//  EJERCICIO 5.1-1: picImagen tiene Anchor en los 4 lados (crece con la
//  ventana) y btnCargar/lblTamano tienen Bottom, Left (se quedan abajo).
// =====================================================================
using System.IO;   // Path, File... (archivos)

namespace ImagenesEventos
{
    public partial class Form1 : Form
    {
        // EJERCICIO 4.1-2: el archivo esperado ahora es paisaje.jpg
        // Debe estar en tu carpeta Imágenes (cuidado con "paisaje.jpg.jpg").
        private const string NombreFoto = "paisaje.jpg";

        public Form1()
        {
            InitializeComponent();

            // 4.2  Conexión del evento Resize POR CÓDIGO con +=.
            // (Por eso en el rayo del diseñador Resize está VACÍO:
            //  si lo conectas en los dos sitios, se ejecutaría 2 veces.)
            Resize += Form1_Resize;
            MostrarTamano();

            // 4.3  Arrastrar y soltar
            picImagen.AllowDrop = true;                  // acepta arrastres
            picImagen.DragEnter += picImagen_DragOver;   // al entrar arrastrando
            picImagen.DragOver += picImagen_DragOver;    // mientras se arrastra encima
            picImagen.DragDrop += picImagen_DragDrop;    // al soltar

            // Al cerrar, liberamos la imagen de memoria.
            // (s, e) => ...  es un método "en una línea" (lambda)
            FormClosed += (s, e) => picImagen.Image?.Dispose();
        }

        // =============================================================
        // 4.1  Cargar imagen desde un archivo
        // =============================================================
        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Carpeta "Imágenes" del usuario
            string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            // Path.Combine une carpeta + nombre poniendo la "\" correcta
            string ruta = Path.Combine(carpeta, NombreFoto);
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encuentra " + NombreFoto + " en Imágenes.");
                return;
            }
            // 4.3 Paso 4: reutilizamos el mismo método que el arrastre
            CargarImagen(ruta);
        }

        // =============================================================
        // 4.2  Resize: salta cada vez que cambia el tamaño de la ventana
        // =============================================================
        private void MostrarTamano()
        {
            // EJERCICIO 4.2-2: ancha si mide más de 700 de ancho
            string tipo = ClientSize.Width > 700 ? "Ventana ancha" : "Ventana estrecha";

            // ClientSize = interior de la ventana.
            // EJERCICIO 4.2-1: también el tamaño de picImagen.
            lblTamano.Text = "Interior: " + ClientSize.Width + " x " + ClientSize.Height
                + " | Imagen: " + picImagen.Width + " x " + picImagen.Height
                + " | " + tipo;
        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            MostrarTamano();
        }

        // =============================================================
        // 4.3  Arrastrar y soltar
        // =============================================================
        // Devuelve la ruta SOLO si se arrastra exactamente UN archivo.
        // (string? = puede devolver null)
        private string? ObtenerArchivo(IDataObject? datos)
        {
            if (datos?.GetData(DataFormats.FileDrop) is string[] rutas
                && rutas.Length == 1)
                return rutas[0];
            return null;   // nada, o varios archivos (EJERCICIO 4.3-2)
        }

        // Decide si se acepta (Copy) o no (None): cambia el cursor del ratón.
        private void picImagen_DragOver(object? sender, DragEventArgs e)
        {
            bool archivo = ObtenerArchivo(e.Data) is not null;
            bool permiteCopia = (e.AllowedEffect & DragDropEffects.Copy) != 0;
            e.Effect = archivo && permiteCopia
                ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void picImagen_DragDrop(object? sender, DragEventArgs e)
        {
            string? ruta = ObtenerArchivo(e.Data);
            if (ruta is not null) CargarImagen(ruta);
        }

        // try  = "intenta esto"
        // catch = "si falla, haz esto otro en vez de cerrar el programa"
        private void CargarImagen(string ruta)
        {
            try
            {
                using Image original = Image.FromFile(ruta);  // abre el archivo
                Image copia = new Bitmap(original);           // copia en memoria
                Image? anterior = picImagen.Image;
                picImagen.Image = copia;    // solo se cambia si todo fue bien
                anterior?.Dispose();        // liberamos la imagen vieja
            }
            catch (Exception ex) when (ex is IOException
                || ex is UnauthorizedAccessException
                || ex is ArgumentException || ex is OutOfMemoryException)
            {
                // EJERCICIO 4.3-3: el aviso incluye el nombre del archivo.
                // Si arrastras un .txt sale este aviso y la imagen anterior
                // SIGUE ahí (EJERCICIO 4.3-1).
                MessageBox.Show("No se puede abrir " + Path.GetFileName(ruta)
                    + " como imagen. Comprueba el archivo y sus permisos.");
            }
        }
    }
}
