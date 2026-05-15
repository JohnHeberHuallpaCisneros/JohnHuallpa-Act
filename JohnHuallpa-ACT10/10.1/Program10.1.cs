/*
Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
componentes por columna (es decir primero ingresar toda la primer
columna, luego la segunda columna y así sucesivamente)
Imprimir luego la matriz.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1
{
    class Program
    {
        private int[,] Matriz; 
        public void CargarMatriz()
        {
            Matriz = new int[2, 5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("ingrese un valor");
                    string valor;
                    valor = Console.ReadLine();
                    Matriz[j, i] = int.Parse(valor);
                }
            }
        }
        public void ImprimirMatriz()
        {
            Console.WriteLine("La matriz es: ");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(Matriz[i , j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CargarMatriz();
            p.ImprimirMatriz();
        }
    }
}
