using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace PracticaTema2_AinaraBelver
{
    public partial class Registrar_Libro : Form
    {
        private List<Libro> libros = new List<Libro>();
        private readonly Form1 principal;
        public Registrar_Libro(Form1 origen)
        {
            InitializeComponent();
            this.principal = origen;
            FormClosed += Registrar_Libro_FormClosed;

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool duplicado = false;
            string codigo = txt_Codigo.Text.Trim();
            string titulo = txt_Titulo.Text.Trim();
            string autor = txt_Autor.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo) ||
                string.IsNullOrWhiteSpace(titulo) ||
                string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Error, hay campos vacios");
            }
            else
            {
                foreach (Libro buscar in libros)
                {
                    if (buscar.codigo == codigo)
                    {
                        duplicado = true;
                    }


                }
                if (duplicado)
                {
                    MessageBox.Show("No puede tener la misma matricula");
                }
                Libro libro = new Libro(codigo, titulo, autor);
                libros.Add(libro);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Libro_FormClosed(object? sender, FormClosedEventArgs e)
        {
            principal.Show();
            principal.Activate();
        }
    }
}
