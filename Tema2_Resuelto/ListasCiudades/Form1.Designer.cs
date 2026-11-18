namespace ListasCiudades
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
            lstCiudades = new ListBox();
            cmbTurno = new ComboBox();
            btnQuitarCiudad = new Button();
            txtCiudad = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnSinSeleccion = new Button();
            btnVaciarLista = new Button();
            lblSeleccion = new Label();
            SuspendLayout();
            // 
            // lstCiudades
            // 
            lstCiudades.ItemHeight = 15;
            lstCiudades.Location = new Point(20, 20);
            lstCiudades.Name = "lstCiudades";
            lstCiudades.Size = new Size(200, 139);
            lstCiudades.TabIndex = 0;
            lstCiudades.SelectedIndexChanged += Seleccion_Cambiada;
            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Location = new Point(250, 20);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(150, 23);
            cmbTurno.TabIndex = 1;
            cmbTurno.SelectedIndexChanged += Seleccion_Cambiada;
            // 
            // btnQuitarCiudad
            // 
            btnQuitarCiudad.Location = new Point(250, 60);
            btnQuitarCiudad.Name = "btnQuitarCiudad";
            btnQuitarCiudad.Size = new Size(150, 30);
            btnQuitarCiudad.TabIndex = 2;
            btnQuitarCiudad.Text = "Quitar solo ciudad";
            btnQuitarCiudad.UseVisualStyleBackColor = true;
            btnQuitarCiudad.Click += btnQuitarCiudad_Click;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(20, 175);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(200, 23);
            txtCiudad.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(20, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 30);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(115, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(210, 210);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 30);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSinSeleccion
            // 
            btnSinSeleccion.Location = new Point(305, 210);
            btnSinSeleccion.Name = "btnSinSeleccion";
            btnSinSeleccion.Size = new Size(120, 30);
            btnSinSeleccion.TabIndex = 7;
            btnSinSeleccion.Text = "Quitar selección";
            btnSinSeleccion.UseVisualStyleBackColor = true;
            btnSinSeleccion.Click += btnSinSeleccion_Click;
            // 
            // btnVaciarLista
            // 
            btnVaciarLista.Location = new Point(430, 210);
            btnVaciarLista.Name = "btnVaciarLista";
            btnVaciarLista.Size = new Size(100, 30);
            btnVaciarLista.TabIndex = 8;
            btnVaciarLista.Text = "Vaciar lista";
            btnVaciarLista.UseVisualStyleBackColor = true;
            btnVaciarLista.Click += btnVaciarLista_Click;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(20, 260);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.TabIndex = 9;
            lblSeleccion.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 300);
            Controls.Add(lstCiudades);
            Controls.Add(cmbTurno);
            Controls.Add(btnQuitarCiudad);
            Controls.Add(txtCiudad);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnSinSeleccion);
            Controls.Add(btnVaciarLista);
            Controls.Add(lblSeleccion);
            Name = "Form1";
            Text = "Ciudades y turnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCiudades;
        private ComboBox cmbTurno;
        private Button btnQuitarCiudad;
        private TextBox txtCiudad;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnSinSeleccion;
        private Button btnVaciarLista;
        private Label lblSeleccion;
    }
}
