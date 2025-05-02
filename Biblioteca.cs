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

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void MostrarLibros()
        {
            foreach (var libro in libros)
            {
                Console.WriteLine(libro.ToString() + "\n");
            }
        }

        public Libro BuscarLibro(string titulo)
        {
            Libro libroEncontrado = null;

            foreach (var libro in libros)
            {
                if (libro.GetTitulo().Equals(titulo))
                {
                    libroEncontrado = libro;
                    break; // Salimos del bucle una vez encontrado
                }
            }

            if (libroEncontrado != null)
            {
                return libroEncontrado;
            }
            else
            {
                return null;
            }
        }

        public Lector BuscarLector(int dni)
        {
            Lector lectorEncontrado = null;

            foreach (var lector in lectores)
            {
                if (lector.GetDni().Equals(dni))
                {
                    lectorEncontrado = lector;
                    break; // Salimos del bucle una vez encontrado
                }
            }

            if (lectorEncontrado != null)
            {
                return lectorEncontrado;
            }
            else
            {
                return null;
            }
        }

        public Lector AltaLector(string nombre, int dni)
        {
            Lector lector = new Lector(nombre, dni, new List<Libro>());
            Console.WriteLine("LECTOR DADO DE ALTA.");
            lectores.Add(lector);
            return lector;
        }

        public void PrestarLibro(string titulo, int dni)
        {
            Libro libro = BuscarLibro(titulo);
            Lector lector = BuscarLector(dni);
            if (libro == null)
            {
                Console.WriteLine("LIBRO INEXISTENTE.");
                return;
            }
            if (lector == null)
            {
                Console.WriteLine("LECTOR INEXISTENTE");
                return;
            }

            if (lector.GetLibros().Count >= 3)
            {
                Console.WriteLine("TOPE DE PRESTAMO ALCANZADO.");
                return;
            } else
            {
                lector.GetLibros().Add(libro);
                libros.Remove(libro);
                Console.WriteLine("PRESTAMO EXITOSO.");
            }
        }
    }
}