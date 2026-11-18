namespace PracticaTema2_AinaraBelver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuArchivo = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            mnuRegistrar = new ToolStripMenuItem();
            mnuRegistrarLibro = new ToolStripMenuItem();
            picLogo = new PictureBox();
            biblioNombre = new Label();
            grpNuevoPrestamo = new GroupBox();
            Alumno = new Label();
            comboBox1 = new ComboBox();
            Libros = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpNuevoPrestamo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuArchivo, mnuRegistrar, mnuRegistrarLibro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuPrincipal";
            // 
            // mnuArchivo
            // 
            mnuArchivo.DropDownItems.AddRange(new ToolStripItem[] { mnuSalir });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new Size(60, 20);
            mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(96, 22);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // mnuRegistrar
            // 
            mnuRegistrar.Name = "mnuRegistrar";
            mnuRegistrar.Size = new Size(111, 20);
            mnuRegistrar.Text = "Registrar Alumno";
            mnuRegistrar.Click += mnuRegistrar_Click;
            // 
            // mnuRegistrarLibro
            // 
            mnuRegistrarLibro.Name = "mnuRegistrarLibro";
            mnuRegistrarLibro.Size = new Size(95, 20);
            mnuRegistrarLibro.Text = "Registrar Libro";
            mnuRegistrarLibro.Click += mnuRegistrarLibro_Click;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(688, 27);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 50);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // biblioNombre
            // 
            biblioNombre.AutoSize = true;
            biblioNombre.Font = new Font("Segoe UI", 12F);
            biblioNombre.Location = new Point(12, 27);
            biblioNombre.Name = "biblioNombre";
            biblioNombre.Size = new Size(220, 21);
            biblioNombre.TabIndex = 2;
            biblioNombre.Text = "Biblioteca CIFP Nº1 de Cuenca";
            // 
            // grpNuevoPrestamo
            // 
            grpNuevoPrestamo.Controls.Add(button1);
            grpNuevoPrestamo.Controls.Add(comboBox2);
            grpNuevoPrestamo.Controls.Add(Libros);
            grpNuevoPrestamo.Controls.Add(comboBox1);
            grpNuevoPrestamo.Controls.Add(Alumno);
            grpNuevoPrestamo.Location = new Point(12, 83);
            grpNuevoPrestamo.Name = "grpNuevoPrestamo";
            grpNuevoPrestamo.Size = new Size(644, 184);
            grpNuevoPrestamo.TabIndex = 3;
            grpNuevoPrestamo.TabStop = false;
            grpNuevoPrestamo.Text = "Nuevo Prestamo";
            // 
            // Alumno
            // 
            Alumno.AutoSize = true;
            Alumno.Location = new Point(25, 25);
            Alumno.Name = "Alumno";
            Alumno.Size = new Size(50, 15);
            Alumno.TabIndex = 0;
            Alumno.Text = "Alumno";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(528, 23);
            comboBox1.TabIndex = 1;
            // 
            // Libros
            // 
            Libros.AutoSize = true;
            Libros.Location = new Point(25, 84);
            Libros.Name = "Libros";
            Libros.Size = new Size(114, 15);
            Libros.TabIndex = 2;
            Libros.Text = "Ejemplar disponible:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(25, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(528, 23);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(478, 146);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(grpNuevoPrestamo);
            Controls.Add(biblioNombre);
            Controls.Add(picLogo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpNuevoPrestamo.ResumeLayout(false);
            grpNuevoPrestamo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuArchivo;
        private ToolStripMenuItem mnuRegistrar;
        private ToolStripMenuItem mnuRegistrarLibro;
        private ToolStripMenuItem mnuSalir;
        private PictureBox picLogo;
        private Label biblioNombre;
        private GroupBox grpNuevoPrestamo;
        private Button button1;
        private ComboBox comboBox2;
        private Label Libros;
        private ComboBox comboBox1;
        private Label Alumno;
    }
}
