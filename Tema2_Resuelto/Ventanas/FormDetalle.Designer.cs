namespace Ventanas
{
    partial class FormDetalle
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
            lblSaludo = new Label();
            lblLongitud = new Label();
            lblNotas = new Label();
            txtNotas = new TextBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(20, 20);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Ventana secundaria";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(20, 50);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.TabIndex = 1;
            lblLongitud.Text = "";
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(20, 85);
            lblNotas.Name = "lblNotas";
            lblNotas.TabIndex = 2;
            lblNotas.Text = "Notas de esta ventana";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(20, 105);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(270, 23);
            txtNotas.TabIndex = 3;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(20, 145);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 200);
            Controls.Add(lblSaludo);
            Controls.Add(lblLongitud);
            Controls.Add(lblNotas);
            Controls.Add(txtNotas);
            Controls.Add(btnCerrar);
            Name = "FormDetalle";
            Text = "Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private Label lblLongitud;
        private Label lblNotas;
        private TextBox txtNotas;
        private Button btnCerrar;
    }
}
