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
            menuStrip1.SuspendLayout();
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
            mnuSalir.Size = new Size(180, 22);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuArchivo;
        private ToolStripMenuItem mnuRegistrar;
        private ToolStripMenuItem mnuRegistrarLibro;
        private ToolStripMenuItem mnuSalir;
    }
}
