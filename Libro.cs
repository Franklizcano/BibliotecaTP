using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTP
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public string toString()
        {
            return "Titulo: " + titulo + "\n" +
                   "Autor: " + autor + "\n" +
                   "Editorial: " + editorial;
        }
    }
}
