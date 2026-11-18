namespace ListaCoches
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
            lstCoches = new ListBox();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            lblColor = new Label();
            txtColor = new TextBox();
            btnAgregar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            chkSoloMarca = new CheckBox();
            SuspendLayout();
            // 
            // lstCoches
            // 
            lstCoches.ItemHeight = 15;
            lstCoches.Location = new Point(20, 20);
            lstCoches.Name = "lstCoches";
            lstCoches.Size = new Size(250, 169);
            lstCoches.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(290, 23);
            lblMarca.Name = "lblMarca";
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(350, 20);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(180, 23);
            txtMarca.TabIndex = 2;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(290, 58);
            lblModelo.Name = "lblModelo";
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(350, 55);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(180, 23);
            txtModelo.TabIndex = 4;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(290, 93);
            lblColor.Name = "lblColor";
            lblColor.TabIndex = 5;
            lblColor.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(350, 90);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(180, 23);
            txtColor.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(290, 130);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(370, 130);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(80, 30);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(455, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 30);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // chkSoloMarca
            // 
            chkSoloMarca.AutoSize = true;
            chkSoloMarca.Location = new Point(20, 205);
            chkSoloMarca.Name = "chkSoloMarca";
            chkSoloMarca.TabIndex = 10;
            chkSoloMarca.Text = "Mostrar solo la marca (DisplayMember)";
            chkSoloMarca.UseVisualStyleBackColor = true;
            chkSoloMarca.CheckedChanged += chkSoloMarca_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 260);
            Controls.Add(lstCoches);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(lblModelo);
            Controls.Add(txtModelo);
            Controls.Add(lblColor);
            Controls.Add(txtColor);
            Controls.Add(btnAgregar);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(chkSoloMarca);
            Name = "Form1";
            Text = "Lista de coches";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCoches;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Label lblColor;
        private TextBox txtColor;
        private Button btnAgregar;
        private Button btnConsultar;
        private Button btnEliminar;
        private CheckBox chkSoloMarca;
    }
}
