/*
Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
(crearla sin la intervención del operador)
Realizar la carga por teclado e imprimir posteriormente. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    class Program
    {
        private int[][] MatrizDentada; 

        public void Carga()
        {
            MatrizDentada = new int[5][];

            MatrizDentada[0] = new int[1];
            MatrizDentada[1] = new int[2];
            MatrizDentada[2] = new int[3];
            MatrizDentada[3] = new int[4];
            MatrizDentada[4] = new int[5];

            for (int f = 0; f < MatrizDentada.Length; f++)
            {
                Console.WriteLine("Fila N° " + (f + 1));
                for(int c = 0; c < MatrizDentada[f].Length; c++)
                {
                    Console.WriteLine("Ingresa un valor para la columna " + (c + 1) + ":");
                    MatrizDentada[f][c] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Imprimir()
        {
            for (int f = 0; f < MatrizDentada.Length; f++)
            {
                Console.WriteLine("Valores de la fila N° " + (f + 1) + ":");
                for (int c = 0; c < MatrizDentada[f].Length; c++)
                {
                    Console.Write(MatrizDentada[f][c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Carga();
            p.Imprimir();
        }
    }
}
