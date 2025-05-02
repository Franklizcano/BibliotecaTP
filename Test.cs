using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTP
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            List<Libro> libros = new List<Libro>();
            Libro libro1 = new Libro("El Principito", "Antoine de Saint-Exupéry", "Editorial XYZ");
            Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez", "Editorial ABC");
            Libro libro3 = new Libro("1984", "George Orwell", "Editorial DEF");
            Libro libro4 = new Libro("El tunel", "Ernesto Sabato", "Editorial GHI");
            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);
            biblioteca.AgregarLibro(libro4);
            Console.WriteLine("Libros en la biblioteca:\n");
            biblioteca.MostrarLibros();
            Console.WriteLine("Dando de alta a un nuevo lector:\n");
            Lector lector = biblioteca.AltaLector("Juan Pérez", 12345678);
            Console.WriteLine("\n" + lector.ToString());
            Console.WriteLine("\nPrestando el libro: El Principito a Juan Pérez:\n");
            biblioteca.PrestarLibro("El Principito", 12345678);
            Console.WriteLine("\nLibros actuales del lector:");
            lector.MostrarLibros();
            Console.WriteLine("Intentando prestar 3 libros más a Juan:");
            biblioteca.PrestarLibro("Cien años de soledad", 12345678);
            biblioteca.PrestarLibro("1984", 12345678);
            biblioteca.PrestarLibro("El tunel", 12345678);
            Console.WriteLine("\nLibros actuales del lector:");
            lector.MostrarLibros();
            Console.WriteLine("\nLibros actuales de la biblioteca:");
            biblioteca.MostrarLibros();
            Console.WriteLine("\nPrestando un libro que no existe:");
            biblioteca.PrestarLibro("Libro que no existe", 12345678);
            Console.WriteLine("\nPrestando a un lector que no existe:");
            biblioteca.PrestarLibro("El tunel", 87654321);
        }
    }
}
