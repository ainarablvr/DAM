using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PracticaTema2_AinaraBelver
{
    public partial class Registrar_Alumno : Form
    {
        private readonly Form1 principal;

        public Registrar_Alumno(Form1 origen)
        {
            InitializeComponent();
            this.principal = origen;
            FormClosed += Registrar_Alumno_FormClosed;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool duplicado = false;
            string matricula = txt_Matricula.Text.Trim();
            string nombre = txt_Nombre.Text.Trim();
            string apellido = txt_Apellido.Text.Trim();
            string grupo = txt_Grupo.Text.Trim();
            if (string.IsNullOrWhiteSpace(matricula) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(grupo))
            {
                MessageBox.Show("Error, hay campos vacios");
            }
            else
            {
                foreach(Alumno buscar in principal.alumnos)
                {
                    if(buscar.matricula == matricula)
                    {
                        duplicado = true;
                    }
                    
                    
                }
                if (duplicado)
                {
                    MessageBox.Show("No puede tener la misma matricula");
                }
                else
                {
                    Alumno alumno = new Alumno(matricula, nombre, apellido, grupo);
                    principal.alumnos.Add(alumno);
                    MessageBox.Show("Alumno registrado");
                    Close();
                }
                

            }
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Alumno_FormClosed(object? sender, FormClosedEventArgs e)
        {
            principal.Show();
            principal.Activate();
        }
    }
}
