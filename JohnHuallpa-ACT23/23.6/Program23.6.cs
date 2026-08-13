/*
Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
para organizar la consulta de ejemplares por parte de los lectores.
 Crear la clase Libro que contenga como atributos privados: titulo
(string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
un constructor que reciba tit y anio.
 Crear la clase BibliotecaCentral que administre una lista de objetos
List.
 Métodos en BibliotecaCentral:
1. CargarCatalogo(): Solicitar por teclado títulos y años de
publicación para agregar libros a la lista mediante .Add(). La carga
finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
junto a la cantidad total de obras registradas mediante la propiedad
.Count.
3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
imprimir en consola únicamente aquellos libros cuyo año de
publicación sea menor a dicho valor.
4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
los métodos de búsqueda y remoción de listas, eliminarlo de la
colección si se encuentra presente.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._6
{
    class Libro
    {
        private string titulo;
        private int anioPublicacion;

        public string Titulo 
        {
            get 
            {
                return titulo; 
            } 
        }
        public int AnioPublicacion 
        { 
            get
            { 
                return anioPublicacion; 
            }
        }

        public Libro(string tit, int anio)
        {
            titulo = tit;
            anioPublicacion = anio;
        }
    }

    class BibliotecaCentral
    {
        private List<Libro> libros;

        public BibliotecaCentral()
        {
            libros = new List<Libro>();
        }

        public void CargarCatalogo()
        {
            string tit;
            do
            {
                Console.Write("Título (FIN para terminar): ");
                tit = Console.ReadLine();
                if (tit != "FIN")
                {
                    Console.Write("Año de publicación: ");
                    int anio = int.Parse(Console.ReadLine());
                    libros.Add(new Libro(tit, anio));
                }
            } while (tit != "FIN");
        }

        public void ListarCatalogo()
        {
            foreach (Libro l in libros)
            {
                Console.WriteLine(l.Titulo + " (" + l.AnioPublicacion + ")");
            }
            
            Console.WriteLine("Total de obras: " + libros.Count);
        }

        public void FiltrarPorAnio()
        {
            Console.Write("Año límite: ");
            int anio = int.Parse(Console.ReadLine());
            foreach (Libro l in libros)
            {
                if (l.AnioPublicacion < anio)
                {
                    Console.WriteLine(l.Titulo + " (" + l.AnioPublicacion + ")");
                }
            }
        }

        public void RemoverLibro()
        {
            Console.Write("Título a remover: ");
            string tit = Console.ReadLine();
            Libro encontrado = null;

            foreach (Libro l in libros)
            {
                if(l.Titulo == tit)
                {
                    encontrado = l;
                }
            }

            if(encontrado != null)
            {
                libros.Remove(encontrado);
                Console.WriteLine("Libro removido.");
            }
            else
            {
                Console.WriteLine("No se encontró el libro.");
            }
        }
        static void Main(string[] args)
        {
            BibliotecaCentral b = new BibliotecaCentral();
            b.CargarCatalogo();
            b.ListarCatalogo();
            b.FiltrarPorAnio();
            b.RemoverLibro();
            b.ListarCatalogo();
        }
    }
}
