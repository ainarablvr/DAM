namespace ControlesBasicos
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
            lblEntrada = new Label();
            txtEntrada = new TextBox();
            lblResultado = new Label();
            txtResultado = new TextBox();
            lblCopiable = new Label();
            txtResultadoCopiable = new TextBox();
            btnLimpiar = new Button();
            lblCopia = new Label();
            txtCopia = new TextBox();
            btnCopiarEntrada = new Button();
            lblDato = new Label();
            txtDato = new TextBox();
            chkHabilitar = new CheckBox();
            chkBloquearCero = new CheckBox();
            chkSoloLectura = new CheckBox();
            SuspendLayout();
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Location = new Point(20, 15);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.TabIndex = 0;
            lblEntrada.Text = "Entrada (varias líneas)";
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(20, 35);
            txtEntrada.Multiline = true;
            txtEntrada.Name = "txtEntrada";
            txtEntrada.ScrollBars = ScrollBars.Vertical;
            txtEntrada.Size = new Size(300, 90);
            txtEntrada.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(20, 135);
            lblResultado.Name = "lblResultado";
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado (Enabled = false)";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(20, 155);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(140, 23);
            txtResultado.TabIndex = 3;
            txtResultado.Text = "125";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCopiable
            // 
            lblCopiable.AutoSize = true;
            lblCopiable.Location = new Point(180, 135);
            lblCopiable.Name = "lblCopiable";
            lblCopiable.TabIndex = 4;
            lblCopiable.Text = "Resultado (ReadOnly = true)";
            // 
            // txtResultadoCopiable
            // 
            txtResultadoCopiable.Location = new Point(180, 155);
            txtResultadoCopiable.Name = "txtResultadoCopiable";
            txtResultadoCopiable.ReadOnly = true;
            txtResultadoCopiable.Size = new Size(140, 23);
            txtResultadoCopiable.TabIndex = 5;
            txtResultadoCopiable.TextAlign = HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(20, 190);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 30);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar entrada";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCopia
            // 
            lblCopia.AutoSize = true;
            lblCopia.Location = new Point(360, 15);
            lblCopia.Name = "lblCopia";
            lblCopia.TabIndex = 7;
            lblCopia.Text = "Copia de la entrada (solo lectura)";
            // 
            // txtCopia
            // 
            txtCopia.Location = new Point(360, 35);
            txtCopia.Multiline = true;
            txtCopia.Name = "txtCopia";
            txtCopia.ReadOnly = true;
            txtCopia.ScrollBars = ScrollBars.Vertical;
            txtCopia.Size = new Size(300, 90);
            txtCopia.TabIndex = 8;
            // 
            // btnCopiarEntrada
            // 
            btnCopiarEntrada.Location = new Point(360, 135);
            btnCopiarEntrada.Name = "btnCopiarEntrada";
            btnCopiarEntrada.Size = new Size(140, 30);
            btnCopiarEntrada.TabIndex = 9;
            btnCopiarEntrada.Text = "Copiar entrada";
            btnCopiarEntrada.UseVisualStyleBackColor = true;
            btnCopiarEntrada.Click += btnCopiarEntrada_Click;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(20, 255);
            lblDato.Name = "lblDato";
            lblDato.TabIndex = 10;
            lblDato.Text = "Dato";
            // 
            // txtDato
            // 
            txtDato.Location = new Point(20, 275);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(200, 23);
            txtDato.TabIndex = 11;
            txtDato.KeyDown += txtDato_KeyDown;
            // 
            // chkHabilitar
            // 
            chkHabilitar.AutoSize = true;
            chkHabilitar.CheckState = CheckState.Checked;
            chkHabilitar.Checked = true;
            chkHabilitar.Location = new Point(250, 255);
            chkHabilitar.Name = "chkHabilitar";
            chkHabilitar.TabIndex = 12;
            chkHabilitar.Text = "Permitir escritura";
            chkHabilitar.UseVisualStyleBackColor = true;
            chkHabilitar.CheckedChanged += chkHabilitar_CheckedChanged;
            // 
            // chkBloquearCero
            // 
            chkBloquearCero.AutoSize = true;
            chkBloquearCero.Location = new Point(250, 280);
            chkBloquearCero.Name = "chkBloquearCero";
            chkBloquearCero.TabIndex = 13;
            chkBloquearCero.Text = "Bloquear cero";
            chkBloquearCero.UseVisualStyleBackColor = true;
            // 
            // chkSoloLectura
            // 
            chkSoloLectura.AutoSize = true;
            chkSoloLectura.Location = new Point(250, 305);
            chkSoloLectura.Name = "chkSoloLectura";
            chkSoloLectura.TabIndex = 14;
            chkSoloLectura.Text = "Solo lectura";
            chkSoloLectura.UseVisualStyleBackColor = true;
            chkSoloLectura.CheckedChanged += chkSoloLectura_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 390);
            Controls.Add(lblEntrada);
            Controls.Add(txtEntrada);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(lblCopiable);
            Controls.Add(txtResultadoCopiable);
            Controls.Add(btnLimpiar);
            Controls.Add(lblCopia);
            Controls.Add(txtCopia);
            Controls.Add(btnCopiarEntrada);
            Controls.Add(lblDato);
            Controls.Add(txtDato);
            Controls.Add(chkHabilitar);
            Controls.Add(chkBloquearCero);
            Controls.Add(chkSoloLectura);
            Name = "Form1";
            Text = "Controles básicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEntrada;
        private TextBox txtEntrada;
        private Label lblResultado;
        private TextBox txtResultado;
        private Label lblCopiable;
        private TextBox txtResultadoCopiable;
        private Button btnLimpiar;
        private Label lblCopia;
        private TextBox txtCopia;
        private Button btnCopiarEntrada;
        private Label lblDato;
        private TextBox txtDato;
        private CheckBox chkHabilitar;
        private CheckBox chkBloquearCero;
        private CheckBox chkSoloLectura;
    }
}
