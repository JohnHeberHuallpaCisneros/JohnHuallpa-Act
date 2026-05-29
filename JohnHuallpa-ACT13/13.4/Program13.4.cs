/*
Plantear una clase Alumno que tenga los atributos privados: nombre y un
vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
alumno y sus 4 calificaciones.
Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
Alumno.
Agregar los siguientes métodos:
a) Un método que imprima el nombre de cada alumno y su promedio.
b) Un método que muestre el nombre del alumno con el promedio más
alto.
c) Un método que indique qué alumnos tienen al menos una nota
desaprobada (nota menor a 6)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _13._4
{
    class Alumno
    {
        private string nombre;
        private int[] notas;

        public Alumno()
        {
            notas = new int[4];

            Console.Write("Ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingrese la nota " + (i + 1) + ": ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public int SacarPromedio()
        {
            int suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }

            return suma / notas.Length;
        }

        public void Imprimir()
        {
            Console.WriteLine("Alumno: " + nombre +
                              " | Promedio: " + SacarPromedio());
        }

        public string GetNombre()
        {
            return nombre;
        }

        public bool TieneDesaprobado()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 6)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Curso
    {
        private Alumno Alumno1;
        private Alumno Alumno2;
        private Alumno Alumno3;

        public Curso()
        {
            Alumno1 = new Alumno();
            Alumno2 = new Alumno();
            Alumno3 = new Alumno();
        }

        public void MostrarAlumnos()
        {
            Console.WriteLine("\nPromedios:");

            Alumno1.Imprimir();
            Alumno2.Imprimir();
            Alumno3.Imprimir();
        }

        public void Destacado()
        {
            Alumno destacado = Alumno1;

            if (Alumno2.SacarPromedio() > destacado.SacarPromedio())
            {
                destacado = Alumno2;
            }

            if (Alumno3.SacarPromedio() > destacado.SacarPromedio())
            {
                destacado = Alumno3;
            }

            Console.WriteLine("\nAlumno con mejor promedio: "
                              + destacado.GetNombre());
        }

        public void AlumnosConNotaBaja()
        {
            Console.WriteLine("\nAlumnos con alguna nota desaprobada:");

            if (Alumno1.TieneDesaprobado())
            {
                Console.WriteLine(Alumno1.GetNombre());
            }

            if (Alumno2.TieneDesaprobado())
            {
                Console.WriteLine(Alumno2.GetNombre());
            }

            if (Alumno3.TieneDesaprobado())
            {
                Console.WriteLine(Alumno3.GetNombre());
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Curso c = new Curso();

            c.MostrarAlumnos();
            c.Destacado();
            c.AlumnosConNotaBaja();

        }
    }
}
