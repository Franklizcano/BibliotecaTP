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

        public Lector(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDni()
        {
            return dni;
        }

        public string toString()
        {
            return "Nombre: " + nombre + "\n" +
                   "DNI: " + dni;
        }
    }
}
