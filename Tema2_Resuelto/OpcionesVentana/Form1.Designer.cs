namespace OpcionesVentana
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
            grpResolucion = new GroupBox();
            rb640 = new RadioButton();
            rb800 = new RadioButton();
            rb1024 = new RadioButton();
            rb900 = new RadioButton();
            grpEstado = new GroupBox();
            rbNormal = new RadioButton();
            rbMaximizada = new RadioButton();
            btnAplicar = new Button();
            pnlPrueba = new Panel();
            rbPruebaA = new RadioButton();
            rbPruebaB = new RadioButton();
            grpResolucion.SuspendLayout();
            grpEstado.SuspendLayout();
            pnlPrueba.SuspendLayout();
            SuspendLayout();
            // 
            // grpResolucion
            // 
            grpResolucion.Controls.Add(rb640);
            grpResolucion.Controls.Add(rb800);
            grpResolucion.Controls.Add(rb1024);
            grpResolucion.Controls.Add(rb900);
            grpResolucion.Location = new Point(20, 20);
            grpResolucion.Name = "grpResolucion";
            grpResolucion.Size = new Size(200, 145);
            grpResolucion.TabIndex = 0;
            grpResolucion.Text = "Resolución";
            // 
            // rb640
            // 
            rb640.AutoSize = true;
            rb640.Checked = true;
            rb640.Location = new Point(15, 25);
            rb640.Name = "rb640";
            rb640.TabIndex = 0;
            rb640.TabStop = true;
            rb640.Text = "640 x 480";
            rb640.UseVisualStyleBackColor = true;
            // 
            // rb800
            // 
            rb800.AutoSize = true;
            rb800.Location = new Point(15, 50);
            rb800.Name = "rb800";
            rb800.TabIndex = 1;
            rb800.Text = "800 x 600";
            rb800.UseVisualStyleBackColor = true;
            // 
            // rb1024
            // 
            rb1024.AutoSize = true;
            rb1024.Location = new Point(15, 75);
            rb1024.Name = "rb1024";
            rb1024.TabIndex = 2;
            rb1024.Text = "1024 x 768";
            rb1024.UseVisualStyleBackColor = true;
            // 
            // rb900
            // 
            rb900.AutoSize = true;
            rb900.Location = new Point(15, 100);
            rb900.Name = "rb900";
            rb900.TabIndex = 3;
            rb900.Text = "900 x 650";
            rb900.UseVisualStyleBackColor = true;
            // 
            // grpEstado
            // 
            grpEstado.Controls.Add(rbNormal);
            grpEstado.Controls.Add(rbMaximizada);
            grpEstado.Location = new Point(240, 20);
            grpEstado.Name = "grpEstado";
            grpEstado.Size = new Size(200, 90);
            grpEstado.TabIndex = 1;
            grpEstado.Text = "Estado";
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Checked = true;
            rbNormal.Location = new Point(15, 25);
            rbNormal.Name = "rbNormal";
            rbNormal.TabIndex = 0;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbMaximizada
            // 
            rbMaximizada.AutoSize = true;
            rbMaximizada.Location = new Point(15, 50);
            rbMaximizada.Name = "rbMaximizada";
            rbMaximizada.TabIndex = 1;
            rbMaximizada.Text = "Maximizada";
            rbMaximizada.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(20, 185);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(120, 30);
            btnAplicar.TabIndex = 2;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // pnlPrueba
            // 
            pnlPrueba.Controls.Add(rbPruebaA);
            pnlPrueba.Controls.Add(rbPruebaB);
            pnlPrueba.BorderStyle = BorderStyle.FixedSingle;
            pnlPrueba.Location = new Point(240, 130);
            pnlPrueba.Name = "pnlPrueba";
            pnlPrueba.Size = new Size(200, 70);
            pnlPrueba.TabIndex = 3;
            // 
            // rbPruebaA
            // 
            rbPruebaA.AutoSize = true;
            rbPruebaA.Checked = true;
            rbPruebaA.Location = new Point(10, 10);
            rbPruebaA.Name = "rbPruebaA";
            rbPruebaA.TabIndex = 0;
            rbPruebaA.TabStop = true;
            rbPruebaA.Text = "Prueba A (Panel)";
            rbPruebaA.UseVisualStyleBackColor = true;
            // 
            // rbPruebaB
            // 
            rbPruebaB.AutoSize = true;
            rbPruebaB.Location = new Point(10, 35);
            rbPruebaB.Name = "rbPruebaB";
            rbPruebaB.TabIndex = 1;
            rbPruebaB.Text = "Prueba B (Panel)";
            rbPruebaB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 480);
            Controls.Add(grpResolucion);
            Controls.Add(grpEstado);
            Controls.Add(btnAplicar);
            Controls.Add(pnlPrueba);
            Name = "Form1";
            Text = "Opciones de ventana";
            grpResolucion.ResumeLayout(false);
            grpResolucion.PerformLayout();
            grpEstado.ResumeLayout(false);
            grpEstado.PerformLayout();
            pnlPrueba.ResumeLayout(false);
            pnlPrueba.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpResolucion;
        private RadioButton rb640;
        private RadioButton rb800;
        private RadioButton rb1024;
        private RadioButton rb900;
        private GroupBox grpEstado;
        private RadioButton rbNormal;
        private RadioButton rbMaximizada;
        private Button btnAplicar;
        private Panel pnlPrueba;
        private RadioButton rbPruebaA;
        private RadioButton rbPruebaB;
    }
}
