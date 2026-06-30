using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2
{
    partial class Libro
    {
        public void Resumen()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Páginas: " + Paginas);

            if (Paginas < 100)
                Console.WriteLine("Libro CORTO");
            else
                Console.WriteLine("Libro LARGO");
        }
    }
}
