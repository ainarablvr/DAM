namespace Ejercicios1
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
            btnDespedir = new Button();
            btnProbar = new Button();
            txtSaludo = new Label();
            txtNombre = new TextBox();
            btnOcultar = new Button();
            btnMostrar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnDespedir
            // 
            btnDespedir.Location = new Point(623, 336);
            btnDespedir.Name = "btnDespedir";
            btnDespedir.Size = new Size(75, 23);
            btnDespedir.TabIndex = 0;
            btnDespedir.Text = "Despedir";
            btnDespedir.UseVisualStyleBackColor = true;
            btnDespedir.Click += btnDespedir_Click;
            // 
            // btnProbar
            // 
            btnProbar.Location = new Point(516, 336);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(75, 23);
            btnProbar.TabIndex = 1;
            btnProbar.Text = "Probar";
            btnProbar.UseVisualStyleBackColor = true;
            btnProbar.Click += btnProbar_Click;
            // 
            // txtSaludo
            // 
            txtSaludo.AutoSize = true;
            txtSaludo.Location = new Point(149, 131);
            txtSaludo.Name = "txtSaludo";
            txtSaludo.Size = new Size(38, 15);
            txtSaludo.TabIndex = 2;
            txtSaludo.Text = "Hola!!";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(244, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnOcultar
            // 
            btnOcultar.Location = new Point(516, 295);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(75, 23);
            btnOcultar.TabIndex = 4;
            btnOcultar.Text = "Ocultar";
            btnOcultar.UseVisualStyleBackColor = true;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(623, 295);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Controls.Add(btnOcultar);
            Controls.Add(txtNombre);
            Controls.Add(txtSaludo);
            Controls.Add(btnProbar);
            Controls.Add(btnDespedir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDespedir;
        private Button btnProbar;
        private Label txtSaludo;
        private TextBox txtNombre;
        private Button btnOcultar;
        private Button btnMostrar;
        private Label label1;
        private Label label2;
    }
}
