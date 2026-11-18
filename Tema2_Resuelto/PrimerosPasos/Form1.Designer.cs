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
            btnProbar = new Button();
            btnDespedir = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnSaludar = new Button();
            btnLimpiar = new Button();
            lblSaludo = new Label();
            btnCambiar = new Button();
            btnRestaurar = new Button();
            btnOcultarNombre = new Button();
            btnMostrarNombre = new Button();
            btnMinimizar = new Button();
            lblEspejo = new Label();
            lblEstado = new Label();
            btnPonerLuis = new Button();
            btnVaciarNombre = new Button();
            lblEdad = new Label();
            txtEdad = new TextBox();
            btnEdad = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnProbar
            // 
            btnProbar.Location = new Point(30, 30);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(160, 40);
            btnProbar.TabIndex = 0;
            btnProbar.Text = "Mostrar mensaje";
            btnProbar.UseVisualStyleBackColor = true;
            btnProbar.Click += btnProbar_Click;
            // 
            // btnDespedir
            // 
            btnDespedir.Location = new Point(210, 30);
            btnDespedir.Name = "btnDespedir";
            btnDespedir.Size = new Size(120, 40);
            btnDespedir.TabIndex = 1;
            btnDespedir.Text = "Despedir";
            btnDespedir.UseVisualStyleBackColor = true;
            btnDespedir.Click += btnDespedir_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombre.Location = new Point(30, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Escribe tu nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.MouseEnter += txtNombre_MouseEnter;
            txtNombre.MouseLeave += txtNombre_MouseLeave;
            txtNombre.KeyDown += txtNombre_KeyDown;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(30, 140);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(120, 35);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(160, 140);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(300, 150);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.TabIndex = 6;
            lblSaludo.Text = "";
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(30, 190);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(120, 30);
            btnCambiar.TabIndex = 7;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(160, 190);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(120, 30);
            btnRestaurar.TabIndex = 8;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnOcultarNombre
            // 
            btnOcultarNombre.Location = new Point(290, 190);
            btnOcultarNombre.Name = "btnOcultarNombre";
            btnOcultarNombre.Size = new Size(120, 30);
            btnOcultarNombre.TabIndex = 9;
            btnOcultarNombre.Text = "Ocultar nombre";
            btnOcultarNombre.UseVisualStyleBackColor = true;
            btnOcultarNombre.Click += btnOcultarNombre_Click;
            // 
            // btnMostrarNombre
            // 
            btnMostrarNombre.Location = new Point(420, 190);
            btnMostrarNombre.Name = "btnMostrarNombre";
            btnMostrarNombre.Size = new Size(120, 30);
            btnMostrarNombre.TabIndex = 10;
            btnMostrarNombre.Text = "Mostrar nombre";
            btnMostrarNombre.UseVisualStyleBackColor = true;
            btnMostrarNombre.Click += btnMostrarNombre_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(550, 190);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(120, 30);
            btnMinimizar.TabIndex = 11;
            btnMinimizar.Text = "Minimizar";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblEspejo
            // 
            lblEspejo.AutoSize = true;
            lblEspejo.Location = new Point(30, 240);
            lblEspejo.Name = "lblEspejo";
            lblEspejo.TabIndex = 12;
            lblEspejo.Text = "";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(30, 265);
            lblEstado.Name = "lblEstado";
            lblEstado.TabIndex = 13;
            lblEstado.Text = "";
            // 
            // btnPonerLuis
            // 
            btnPonerLuis.Location = new Point(30, 295);
            btnPonerLuis.Name = "btnPonerLuis";
            btnPonerLuis.Size = new Size(120, 30);
            btnPonerLuis.TabIndex = 14;
            btnPonerLuis.Text = "Poner Luis";
            btnPonerLuis.UseVisualStyleBackColor = true;
            btnPonerLuis.Click += btnPonerLuis_Click;
            // 
            // btnVaciarNombre
            // 
            btnVaciarNombre.Location = new Point(160, 295);
            btnVaciarNombre.Name = "btnVaciarNombre";
            btnVaciarNombre.Size = new Size(120, 30);
            btnVaciarNombre.TabIndex = 15;
            btnVaciarNombre.Text = "Vaciar nombre";
            btnVaciarNombre.UseVisualStyleBackColor = true;
            btnVaciarNombre.Click += btnVaciarNombre_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(30, 355);
            lblEdad.Name = "lblEdad";
            lblEdad.TabIndex = 16;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(80, 352);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 17;
            // 
            // btnEdad
            // 
            btnEdad.Location = new Point(195, 348);
            btnEdad.Name = "btnEdad";
            btnEdad.Size = new Size(130, 30);
            btnEdad.TabIndex = 18;
            btnEdad.Text = "Comprobar edad";
            btnEdad.UseVisualStyleBackColor = true;
            btnEdad.Click += btnEdad_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(340, 355);
            lblResultado.Name = "lblResultado";
            lblResultado.TabIndex = 19;
            lblResultado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 420);
            Controls.Add(btnProbar);
            Controls.Add(btnDespedir);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnSaludar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblSaludo);
            Controls.Add(btnCambiar);
            Controls.Add(btnRestaurar);
            Controls.Add(btnOcultarNombre);
            Controls.Add(btnMostrarNombre);
            Controls.Add(btnMinimizar);
            Controls.Add(lblEspejo);
            Controls.Add(lblEstado);
            Controls.Add(btnPonerLuis);
            Controls.Add(btnVaciarNombre);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(btnEdad);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Mi primera ventana";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProbar;
        private Button btnDespedir;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnSaludar;
        private Button btnLimpiar;
        private Label lblSaludo;
        private Button btnCambiar;
        private Button btnRestaurar;
        private Button btnOcultarNombre;
        private Button btnMostrarNombre;
        private Button btnMinimizar;
        private Label lblEspejo;
        private Label lblEstado;
        private Button btnPonerLuis;
        private Button btnVaciarNombre;
        private Label lblEdad;
        private TextBox txtEdad;
        private Button btnEdad;
        private Label lblResultado;
    }
}
