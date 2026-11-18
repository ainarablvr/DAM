namespace Cuadrado
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblCuadrado = new Label();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(20, 23);
            lblNumero.Name = "lblNumero";
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(110, 20);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCuadrado
            // 
            lblCuadrado.AutoSize = true;
            lblCuadrado.Location = new Point(20, 63);
            lblCuadrado.Name = "lblCuadrado";
            lblCuadrado.TabIndex = 2;
            lblCuadrado.Text = "Cuadrado";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(110, 60);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 23);
            txtResultado.TabIndex = 3;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(20, 110);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(130, 110);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(240, 110);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 190);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(lblCuadrado);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Cuadrado de un entero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblCuadrado;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
