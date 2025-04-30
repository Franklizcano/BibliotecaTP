using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTP
{
    internal class Lector
    {
        private string nombre;
        private int dni;
        private List<Libro> libros;

        public Lector(string nombre, int dni, List<Libro> libros)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.libros = libros;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDni()
        {
            return dni;
        }

        public List<Libro> getLibros()
        {
            return libros;
        }

        public void mostrarLibros()
        {
            foreach (var libro in getLibros())
            {
                Console.WriteLine(libro.ToString()+"\n");
            }
        }

        public string ToString()
        {
            var librosInfo = libros != null && libros.Any()
                ? string.Join("\n", libros.Select(libro => libro.ToString()))
                : "No tiene libros.";

            return "Nombre: " + nombre + "\n" +
                   "DNI: " + dni + "\n" +
                   "Libros: " + librosInfo;
        }
    }
}
