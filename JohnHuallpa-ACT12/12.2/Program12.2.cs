/*
Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
● Definir una matriz irregular de 4 filas para representar los asientos.
● Métodos:
1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
intervención del operador).
2. Crear un método de "Venta de Entradas" que permita cargar la edad del
espectador en un asiento específico (fila y columna).
3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
en cada asiento.
4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
5. Informar cuál es el promedio de edad de los espectadores de todo el
complejo.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _12._2
{
    class Program
    {
        private int[][] Cine;

        public void Carga()
        {
            Cine = new int[4][];

            Cine[0] = new int[10];
            Cine[1] = new int[15];
            Cine[2] = new int[8];
            Cine[3] = new int[12];
        }

        public void VentaEntradas()
        {
            int cantidad;

            Console.Write("Ingrese cantidad de entradas: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                int sala;
                int asiento;
                int edad;
                Console.Write("Ingrese sala (1-4): ");
                sala = int.Parse(Console.ReadLine());
                Console.Write("Ingrese asiento: ");
                asiento = int.Parse(Console.ReadLine());
                Console.Write("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
                Cine[sala - 1][asiento] = edad;
            }
        }
        public void Imprimir()
        {
            for (int fila = 0; fila < Cine.Length; fila++)
            {
                Console.WriteLine("Sala " + (fila + 1));

                for (int columna = 0; columna < Cine[fila].Length; columna++)
                {
                    Console.Write(Cine[fila][columna] + " ");
                }

                Console.WriteLine();
            }
        }
        public void MenoresEdad()
        {
            for (int fila = 0; fila < Cine.Length; fila++)
            {
                int menores = 0;

                for (int columna = 0; columna < Cine[fila].Length; columna++)
                {
                    if (Cine[fila][columna] > 0 &&
                        Cine[fila][columna] < 18)
                    {
                        menores++;
                    }
                }
                Console.WriteLine("Menores en sala " + (fila + 1) + ": " + menores);
            }
        }

        public void Promedio()
        {
            int suma = 0;
            int cantidad = 0;

            for (int fila = 0; fila < Cine.Length; fila++)
            {
                for (int columna = 0; columna < Cine[fila].Length; columna++)
                {
                    if (Cine[fila][columna] > 0)
                    {
                        suma += Cine[fila][columna];
                        cantidad++;
                    }
                }
            }

            double promedio = (double)suma / cantidad;

            Console.WriteLine("Promedio de edades: " + promedio);
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Carga();
            p.VentaEntradas();
            p.Imprimir();
            p.MenoresEdad();
            p.Promedio();
            Console.ReadKey();
        }
    }
}