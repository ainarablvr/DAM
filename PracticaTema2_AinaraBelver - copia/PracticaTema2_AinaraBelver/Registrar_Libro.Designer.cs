namespace PracticaTema2_AinaraBelver
{
    partial class Registrar_Libro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Autor = new TextBox();
            txt_Titulo = new TextBox();
            txt_Codigo = new TextBox();
            linkLabel1 = new LinkLabel();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            Obligatorio = new Label();
            Autor = new Label();
            Titulo = new Label();
            nLibro = new Label();
            RegistrarLibro = new Label();
            SuspendLayout();
            // 
            // txt_Autor
            // 
            txt_Autor.Location = new Point(396, 225);
            txt_Autor.Name = "txt_Autor";
            txt_Autor.Size = new Size(351, 23);
            txt_Autor.TabIndex = 24;
            // 
            // txt_Titulo
            // 
            txt_Titulo.Location = new Point(396, 177);
            txt_Titulo.Name = "txt_Titulo";
            txt_Titulo.Size = new Size(351, 23);
            txt_Titulo.TabIndex = 23;
            // 
            // txt_Codigo
            // 
            txt_Codigo.Location = new Point(396, 133);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(351, 23);
            txt_Codigo.TabIndex = 22;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(388, 103);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 21;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(672, 404);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 20;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(554, 404);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(75, 23);
            btn_Guardar.TabIndex = 19;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // Obligatorio
            // 
            Obligatorio.AutoSize = true;
            Obligatorio.Location = new Point(54, 366);
            Obligatorio.Name = "Obligatorio";
            Obligatorio.Size = new Size(183, 15);
            Obligatorio.TabIndex = 18;
            Obligatorio.Text = "Todos los datos son obligatorios. ";
            // 
            // Autor
            // 
            Autor.AutoSize = true;
            Autor.Location = new Point(134, 233);
            Autor.Name = "Autor";
            Autor.Size = new Size(37, 15);
            Autor.TabIndex = 16;
            Autor.Text = "Autor";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(134, 185);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(38, 15);
            Titulo.TabIndex = 15;
            Titulo.Text = "Titulo";
            // 
            // nLibro
            // 
            nLibro.AutoSize = true;
            nLibro.Location = new Point(134, 141);
            nLibro.Name = "nLibro";
            nLibro.Size = new Size(114, 15);
            nLibro.TabIndex = 14;
            nLibro.Text = "Código del ejemplar";
            // 
            // RegistrarLibro
            // 
            RegistrarLibro.AutoSize = true;
            RegistrarLibro.Location = new Point(54, 23);
            RegistrarLibro.Name = "RegistrarLibro";
            RegistrarLibro.Size = new Size(83, 15);
            RegistrarLibro.TabIndex = 13;
            RegistrarLibro.Text = "Registrar Libro";
            // 
            // Registrar_Libro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Autor);
            Controls.Add(txt_Titulo);
            Controls.Add(txt_Codigo);
            Controls.Add(linkLabel1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(Obligatorio);
            Controls.Add(Autor);
            Controls.Add(Titulo);
            Controls.Add(nLibro);
            Controls.Add(RegistrarLibro);
            Name = "Registrar_Libro";
            Text = "Registrar_Libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Grupo;
        private TextBox txt_Autor;
        private TextBox txt_Titulo;
        private TextBox txt_Codigo;
        private LinkLabel linkLabel1;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Label Obligatorio;
        private Label Grupo;
        private Label Autor;
        private Label Titulo;
        private Label nLibro;
        private Label RegistrarLibro;
    }
}