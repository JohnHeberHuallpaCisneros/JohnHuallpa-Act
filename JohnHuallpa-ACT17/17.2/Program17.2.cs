/*
2. Catálogo de Películas (Encapsulación, Validación y Composición)
Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
asegurando mediante validaciones lógicas que:
 La duración en minutos sea estrictamente mayor a cero (0).
 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
un valor por defecto de 1).
La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
películas ordenadas de mayor a menor en base a su duración. Además, el método debe
informar el título de la película con mejor calificación y cuál es la película más corta del
catálogo.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2
{
    class Pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public string Titulo
        {
            set
            {
                titulo = value; 
            }
            get
            { 
                return titulo; 
            }
        }

        public int DuracionMinutos
        {
            set
            {
                if (value > 0)
                    duracionMinutos = value;
                else
                    Console.WriteLine("La duración debe ser mayor a 0");
            }
            get
            { 
                return duracionMinutos;
            }
        }

        public int Calificacion
        {
            set
            {
                if (value >= 1 && value <= 5)
                    calificacion = value;
                else
                    calificacion = 1;
            }
            get
            {
                return calificacion;
            }
        }
    }

    class Catalogo
    {
        private Pelicula[] peliculas = new Pelicula[3];

        public Catalogo()
        {
            peliculas[0] = new Pelicula();
            peliculas[1] = new Pelicula();
            peliculas[2] = new Pelicula();
        }

        public void CargarPeliculas()
        {
            peliculas[0].Titulo = "Inception"; peliculas[0].DuracionMinutos = 148; peliculas[0].Calificacion = 5;
            peliculas[1].Titulo = "The Batman"; peliculas[1].DuracionMinutos = 176; peliculas[1].Calificacion = 4;
            peliculas[2].Titulo = "Dune"; peliculas[2].DuracionMinutos = 155; peliculas[2].Calificacion = 5;
        }

        public void MostrarCatalogo()
        {
            Console.WriteLine("=== Catálogo ordenado por duración (mayor a menor) ===");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (peliculas[j].DuracionMinutos < peliculas[j + 1].DuracionMinutos)
                    {
                        Pelicula aux = peliculas[j];
                        peliculas[j] = peliculas[j + 1];
                        peliculas[j + 1] = aux;
                    }
                }
            }

            int mejorCalif = 0;
            string tituloMejor = "";
            int masCorta = 9999;
            string tituloCorta = "";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(peliculas[i].Titulo + " - " + peliculas[i].DuracionMinutos + " min - Calificación: " + peliculas[i].Calificacion);

                if (peliculas[i].Calificacion > mejorCalif)
                {
                    mejorCalif = peliculas[i].Calificacion;
                    tituloMejor = peliculas[i].Titulo;
                }
                if (peliculas[i].DuracionMinutos < masCorta)
                {
                    masCorta = peliculas[i].DuracionMinutos;
                    tituloCorta = peliculas[i].Titulo;
                }
            }

            Console.WriteLine("Película con mejor calificación: " + tituloMejor);
            Console.WriteLine("Película más corta: " + tituloCorta + " (" + masCorta + " min)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalogo cat = new Catalogo();
            cat.CargarPeliculas();
            cat.MostrarCatalogo();

            Console.ReadKey();
        }
    }
}
