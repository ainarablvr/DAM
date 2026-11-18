using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema2_AinaraBelver
{
    public class Libro
    {
        public string codigo { get; set; } = "";
        public string titulo { get; set; } = "";
        public string autor { get; set; } = "";

        public Libro(string codigo, string titulo, string autor)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
        }

        public override string ToString()
        {
            return "Codigo " + codigo + "Titulo: " + titulo + "Autor: " + autor;
        }
    }
}
