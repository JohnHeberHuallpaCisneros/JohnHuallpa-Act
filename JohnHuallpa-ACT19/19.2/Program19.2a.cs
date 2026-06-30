using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2
{
        partial class Libro
        {
            private string titulo;
            private string autor;
            private int paginas;

            public string Titulo
            {
                get { return titulo; }
                set { titulo = value; }
            }

            public string Autor
            {
                get { return autor; }
                set { autor = value; }
            }

            public int Paginas
            {
                get { return paginas; }
                set
                {
                    if (value > 10)
                        paginas = value;
                    else
                    {
                        Console.WriteLine("El libro debe tener más de 10 páginas, Se asignan 11");
                        paginas = 11;
                    }
                }
            }

            public Libro()
            {
                Console.Write("Ingrese el título del libro: ");
                Titulo = Console.ReadLine();

                Console.Write("Ingrese el autor: ");
                Autor = Console.ReadLine();

                Console.Write("Ingrese la cantidad de páginas: ");
                Paginas = int.Parse(Console.ReadLine());
            }
        }
}
