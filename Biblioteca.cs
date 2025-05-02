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
        private List<Libro> librosEnBiblioteca;
        private List<Lector> lectoresRegistrados;

        public Biblioteca()
        {
            librosEnBiblioteca = new List<Libro>();
            lectoresRegistrados = new List<Lector>();
        }

        public void AgregarLibro(Libro libro)
        {
            librosEnBiblioteca.Add(libro);
        }

        public void MostrarLibros()
        {
            foreach (var libro in librosEnBiblioteca)
            {
                Console.WriteLine(libro.ToString() + "\n");
            }
        }

        public Libro BuscarLibro(string titulo)
        {
            Libro libroEncontrado = null;

            foreach (var libro in librosEnBiblioteca)
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

            foreach (var lector in lectoresRegistrados)
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
            lectoresRegistrados.Add(lector);
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
                librosEnBiblioteca.Remove(libro);
                Console.WriteLine("PRESTAMO EXITOSO.");
            }
        }
    }
}