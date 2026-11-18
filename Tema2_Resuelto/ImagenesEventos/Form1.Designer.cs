namespace ImagenesEventos
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
            picImagen = new PictureBox();
            btnCargar = new Button();
            lblTamano = new Label();
            SuspendLayout();
            // 
            // picImagen
            // 
            picImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picImagen.BorderStyle = BorderStyle.FixedSingle;
            picImagen.Location = new Point(20, 20);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(350, 220);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCargar.Location = new Point(20, 255);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(100, 30);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar foto";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblTamano
            // 
            lblTamano.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTamano.AutoSize = true;
            lblTamano.Location = new Point(130, 262);
            lblTamano.Name = "lblTamano";
            lblTamano.TabIndex = 2;
            lblTamano.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(picImagen);
            Controls.Add(btnCargar);
            Controls.Add(lblTamano);
            Name = "Form1";
            Text = "Imágenes y eventos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagen;
        private Button btnCargar;
        private Label lblTamano;
    }
}
