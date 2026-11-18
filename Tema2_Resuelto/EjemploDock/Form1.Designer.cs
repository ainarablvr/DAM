namespace EjemploDock
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
            txtEditor = new TextBox();
            pnlPie = new Panel();
            btnContarLineas = new Button();
            pnlCabecera = new Panel();
            lblTitulo = new Label();
            pnlPie.SuspendLayout();
            pnlCabecera.SuspendLayout();
            SuspendLayout();
            // 
            // txtEditor
            // 
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.Location = new Point(0, 55);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Vertical;
            txtEditor.Size = new Size(500, 255);
            txtEditor.TabIndex = 0;
            // 
            // pnlPie
            // 
            pnlPie.Controls.Add(btnContarLineas);
            pnlPie.BackColor = Color.Gainsboro;
            pnlPie.Dock = DockStyle.Bottom;
            pnlPie.Location = new Point(0, 310);
            pnlPie.Name = "pnlPie";
            pnlPie.Size = new Size(500, 40);
            pnlPie.TabIndex = 1;
            // 
            // btnContarLineas
            // 
            btnContarLineas.Location = new Point(10, 6);
            btnContarLineas.Name = "btnContarLineas";
            btnContarLineas.Size = new Size(120, 28);
            btnContarLineas.TabIndex = 0;
            btnContarLineas.Text = "Contar líneas";
            btnContarLineas.UseVisualStyleBackColor = true;
            btnContarLineas.Click += btnContarLineas_Click;
            // 
            // pnlCabecera
            // 
            pnlCabecera.Controls.Add(lblTitulo);
            pnlCabecera.BackColor = Color.LightSteelBlue;
            pnlCabecera.Dock = DockStyle.Top;
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(500, 55);
            pnlCabecera.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Observaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(txtEditor);
            Controls.Add(pnlPie);
            Controls.Add(pnlCabecera);
            Name = "Form1";
            Text = "Ejemplo Dock";
            pnlPie.ResumeLayout(false);
            pnlPie.PerformLayout();
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEditor;
        private Panel pnlPie;
        private Button btnContarLineas;
        private Panel pnlCabecera;
        private Label lblTitulo;
    }
}
