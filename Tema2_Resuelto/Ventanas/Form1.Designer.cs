namespace Ventanas
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnNoModal = new Button();
            btnModal = new Button();
            btnOcultar = new Button();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnNoModal
            // 
            btnNoModal.Location = new Point(20, 60);
            btnNoModal.Name = "btnNoModal";
            btnNoModal.Size = new Size(130, 30);
            btnNoModal.TabIndex = 2;
            btnNoModal.Text = "Abrir no modal";
            btnNoModal.UseVisualStyleBackColor = true;
            btnNoModal.Click += btnNoModal_Click;
            // 
            // btnModal
            // 
            btnModal.Location = new Point(160, 60);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(130, 30);
            btnModal.TabIndex = 3;
            btnModal.Text = "Abrir modal";
            btnModal.UseVisualStyleBackColor = true;
            btnModal.Click += btnModal_Click;
            // 
            // btnOcultar
            // 
            btnOcultar.Location = new Point(300, 60);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(130, 30);
            btnOcultar.TabIndex = 4;
            btnOcultar.Text = "Abrir y ocultar";
            btnOcultar.UseVisualStyleBackColor = true;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(20, 110);
            lblEstado.Name = "lblEstado";
            lblEstado.TabIndex = 5;
            lblEstado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 220);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnNoModal);
            Controls.Add(btnModal);
            Controls.Add(btnOcultar);
            Controls.Add(lblEstado);
            Name = "Form1";
            Text = "Ventana principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnNoModal;
        private Button btnModal;
        private Button btnOcultar;
        private Label lblEstado;
    }
}
