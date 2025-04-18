using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaTP
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            libros = new List<Libro>();
            lectores = new List<Lector>();
        }

        public void agregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void mostrarLibros()
        {
            foreach (var libro in libros)
            {
                Console.WriteLine(libro.ToString());
            }
        }

        public Libro buscarLibro(string titulo)
        {
            Libro libroEncontrado = null;

            foreach (var libro in libros)
            {
                if (libro.getTitulo().Equals(titulo))
                {
                    libroEncontrado = libro;
                    break; // Salimos del bucle una vez encontrado
                }
            }

            if (libroEncontrado != null)
            {
                Console.WriteLine(libroEncontrado.toString());
            }
            else
            {
                Console.WriteLine("LIBRO INEXISTENTE.");
            }
            return libroEncontrado;
        }

        public Lector buscarLector(string nombre)
        {
            Lector lectorEncontrado = null;

            foreach (var lector in lectores)
            {
                if (lector.getNombre().Equals(nombre))
                {
                    lectorEncontrado = lector;
                    break; // Salimos del bucle una vez encontrado
                }
            }

            if (lectorEncontrado != null)
            {
                Console.WriteLine(lectorEncontrado.ToString());
            }
            else
            {
                Console.WriteLine("LECTOR INEXISTENTE.");
            }
            return lectorEncontrado;
        }
    }
}
