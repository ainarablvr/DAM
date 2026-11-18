namespace PracticaTema2_AinaraBelver
{
    partial class Registrar_Alumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegistrarAlumno = new Label();
            nMatricula = new Label();
            Nombre = new Label();
            Apellido = new Label();
            Grupo = new Label();
            Obligatorio = new Label();
            btn_Guardar = new Button();
            btn_Cancelar = new Button();
            linkLabel1 = new LinkLabel();
            txt_Matricula = new TextBox();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Grupo = new TextBox();
            SuspendLayout();
            // 
            // RegistrarAlumno
            // 
            RegistrarAlumno.AutoSize = true;
            RegistrarAlumno.Location = new Point(42, 31);
            RegistrarAlumno.Name = "RegistrarAlumno";
            RegistrarAlumno.Size = new Size(99, 15);
            RegistrarAlumno.TabIndex = 0;
            RegistrarAlumno.Text = "Registrar Alumno";
            // 
            // nMatricula
            // 
            nMatricula.AutoSize = true;
            nMatricula.Location = new Point(122, 149);
            nMatricula.Name = "nMatricula";
            nMatricula.Size = new Size(120, 15);
            nMatricula.TabIndex = 1;
            nMatricula.Text = "Número de matrícula";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(122, 193);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(122, 241);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(51, 15);
            Apellido.TabIndex = 3;
            Apellido.Text = "Apellido";
            // 
            // Grupo
            // 
            Grupo.AutoSize = true;
            Grupo.Location = new Point(122, 289);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(40, 15);
            Grupo.TabIndex = 4;
            Grupo.Text = "Grupo";
            // 
            // Obligatorio
            // 
            Obligatorio.AutoSize = true;
            Obligatorio.Location = new Point(42, 374);
            Obligatorio.Name = "Obligatorio";
            Obligatorio.Size = new Size(183, 15);
            Obligatorio.TabIndex = 5;
            Obligatorio.Text = "Todos los datos son obligatorios. ";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(542, 412);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(75, 23);
            btn_Guardar.TabIndex = 6;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(660, 412);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 7;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(376, 111);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 8;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(384, 141);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(351, 23);
            txt_Matricula.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(384, 185);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(351, 23);
            txt_Nombre.TabIndex = 10;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(384, 233);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(351, 23);
            txt_Apellido.TabIndex = 11;
            // 
            // txt_Grupo
            // 
            txt_Grupo.Location = new Point(384, 281);
            txt_Grupo.Name = "txt_Grupo";
            txt_Grupo.Size = new Size(351, 23);
            txt_Grupo.TabIndex = 12;
            // 
            // Registrar_Alumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Grupo);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Matricula);
            Controls.Add(linkLabel1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(Obligatorio);
            Controls.Add(Grupo);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(nMatricula);
            Controls.Add(RegistrarAlumno);
            Name = "Registrar_Alumno";
            Text = "Registrar_Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegistrarAlumno;
        private Label nMatricula;
        private Label Nombre;
        private Label Apellido;
        private Label Grupo;
        private Label Obligatorio;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private LinkLabel linkLabel1;
        private TextBox txt_Matricula;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Grupo;
    }
}