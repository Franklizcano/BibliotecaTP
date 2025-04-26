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

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public string ToString()
        {
            return "Titulo: " + this.titulo + "\n" +
                   "Autor: " + this.autor + "\n" +
                   "Editorial: " + this.editorial;
        }
    }
}
