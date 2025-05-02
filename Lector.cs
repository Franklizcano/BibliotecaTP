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
        private List<Libro> librosPrestados;

        public Lector(string nombre, int dni, List<Libro> libros)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.librosPrestados = libros;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetDni()
        {
            return dni;
        }

        public List<Libro> GetLibros()
        {
            return librosPrestados;
        }

        public void MostrarLibros()
        {
            foreach (var libro in this.GetLibros())
            {
                Console.WriteLine(libro.ToString()+"\n");
            }
        }

        public string ToString()
        {
            var librosInfo = librosPrestados != null && librosPrestados.Any()
                ? string.Join("\n", librosPrestados.Select(libro => libro.ToString()))
                : "No tiene libros.";

            return "Nombre: " + nombre + "\n" +
                   "DNI: " + dni + "\n" +
                   "Libros: " + librosInfo;
        }
    }
}
