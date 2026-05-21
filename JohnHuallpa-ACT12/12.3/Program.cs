/*
3. Academia de Gastronomía: Recetario Dinámico
Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).

● Definir un vector para los nombres de los alumnos.
● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
presentado.

● Métodos:
1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
de cada alumno.
2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado"
(promedio >= 70) o "Reprobado".
5. Determinar quién obtuvo el puntaje individual más alto en un solo plato.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _12._3
{
    class Program
    {
        private string[] Alumnos;
        private int[][] Puntajes;

        public void Carga()
        {
            Alumnos = new string[3];
            Puntajes = new int[3][];

            Puntajes[0] = new int[2];
            Puntajes[1] = new int[4];
            Puntajes[2] = new int[3];

            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.Write("Ingrese nombre del alumno: ");
                Alumnos[i] = Console.ReadLine();
            }
        }
        public void CargarPuntajes()
        {
            for (int fila = 0; fila < Puntajes.Length; fila++)
            {
                Console.WriteLine("Alumno: " + Alumnos[fila]);
                for (int columna = 0; columna < Puntajes[fila].Length; columna++)
                {
                    int nota;
                    Console.Write("Ingrese puntaje del plato: ");
                    nota = int.Parse(Console.ReadLine());

                    while (nota < 0 || nota > 100)
                    {
                        Console.Write("Error. Ingrese puntaje entre 0 y 100: ");
                        nota = int.Parse(Console.ReadLine());
                    }
                    Puntajes[fila][columna] = nota;
                }
            }
        
        }
        public void Imprimir()
        {
            for (int fila = 0; fila < Puntajes.Length; fila++)
            {
                Console.WriteLine("Alumno: " + Alumnos[fila]);

                for (int columna = 0; columna < Puntajes[fila].Length; columna++)
                {
                    Console.Write(Puntajes[fila][columna] + " ");
                }

                Console.WriteLine();
            }
        }
        public void Promedios()
        {
            for (int fila = 0; fila < Puntajes.Length; fila++)
            {
                int suma = 0;
                for (int columna = 0; columna < Puntajes[fila].Length; columna++)
                {
                    suma += Puntajes[fila][columna];
                }
                double promedio = (double)suma / Puntajes[fila].Length;
                if (promedio >= 70)
                {
                    Console.WriteLine(Alumnos[fila] +
                                      " Aprobado con promedio " + promedio);
                }
                else
                {
                    Console.WriteLine(Alumnos[fila] +
                                      " Reprobado con promedio " + promedio);
                }
            }
        }
        public void MayorPuntaje()
        {
            int mayor = Puntajes[0][0];
            string alumno = Alumnos[0];

            for (int fila = 0; fila < Puntajes.Length; fila++)
            {
                for (int columna = 0; columna < Puntajes[fila].Length; columna++)
                {
                    if (Puntajes[fila][columna] > mayor)
                    {
                        mayor = Puntajes[fila][columna];
                        alumno = Alumnos[fila];
                    }
                }
            }
            Console.WriteLine("Mayor puntaje: " + mayor);
            Console.WriteLine("Alumno: " + alumno);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Carga();
            p.CargarPuntajes();
            p.Imprimir();
            p.Promedios();
            p.MayorPuntaje();
        }
    }
}