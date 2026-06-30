using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Libro libro1 = new Libro();
            libro1.Resumen();

            Libro libro2 = new Libro();
            libro2.Resumen();

            Console.WriteLine("Libro más extenso");
            if (libro1.Paginas > libro2.Paginas)
                Console.WriteLine("El más extenso es: " + libro1.Titulo);
            else if (libro2.Paginas > libro1.Paginas)
                Console.WriteLine("El más extenso es: " + libro2.Titulo);
            else
                Console.WriteLine("Ambos tienen la misma cantidad de páginas.");

            Console.ReadKey();
        }
    }
}
