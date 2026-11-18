namespace PrimerosPasos
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
            button1 = new Button();
            texto = new TextBox();
            txtNombre = new Label();
            btnLimpiar = new Button();
            btnCambiar = new Button();
            btnRestaurar = new Button();
            espejo = new Label();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(669, 386);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Saludar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // texto
            // 
            texto.Location = new Point(346, 129);
            texto.Name = "texto";
            texto.Size = new Size(258, 23);
            texto.TabIndex = 1;
            texto.TextChanged += texto_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(202, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 15);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Introduce tu nombre";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(669, 342);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(588, 386);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(75, 23);
            btnCambiar.TabIndex = 4;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(588, 342);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(75, 23);
            btnRestaurar.TabIndex = 5;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // espejo
            // 
            espejo.AutoSize = true;
            espejo.Location = new Point(234, 54);
            espejo.Name = "espejo";
            espejo.Size = new Size(0, 15);
            espejo.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(411, 42);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Click += lblEstado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstado);
            Controls.Add(espejo);
            Controls.Add(btnRestaurar);
            Controls.Add(btnCambiar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtNombre);
            Controls.Add(texto);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox texto;
        private Label txtNombre;
        private Button btnLimpiar;
        private Button boton;
        private Button btnCambiar;
        private Button btnRestaurar;
        private Label espejo;
        private Label lblEstado;
    }
}
