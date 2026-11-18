namespace Distribucion
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
            pnlContenido = new Panel();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(lblObservaciones);
            pnlContenido.Controls.Add(txtObservaciones);
            pnlContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenido.BorderStyle = BorderStyle.FixedSingle;
            pnlContenido.Location = new Point(12, 12);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(596, 330);
            pnlContenido.TabIndex = 0;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(10, 10);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.TabIndex = 0;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservaciones.Location = new Point(10, 30);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(574, 288);
            txtObservaciones.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.Location = new Point(432, 355);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(85, 30);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(523, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 30);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 400);
            Controls.Add(pnlContenido);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            MinimumSize = new Size(500, 350);
            Name = "Form1";
            Text = "Observaciones";
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlContenido;
        private Label lblObservaciones;
        private TextBox txtObservaciones;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
