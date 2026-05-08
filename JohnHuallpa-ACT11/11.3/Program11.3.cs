/*
Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
empresa.
Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
irregular para cargar los días que han faltado cada empleado (cargar el número de día que
faltó)
Cada fila de la matriz representa los días de cada empleado.
a. Mostrar los empleados con la cantidad de inasistencias.
b. Cuál empleado faltó menos días.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3
{
    class Program
    {
        private string[] Empleados;
        private int[][] DiasAusentes;
        public void Carga()
        {
            Empleados = new string[3];
            DiasAusentes = new int[3][];

            for (int f = 0; f < Empleados.Length; f++)
            {
                Console.WriteLine("Ingresa el nombre del empleado: ");
                Empleados[f] = Console.ReadLine();

                Console.WriteLine("Cantidad de dias ausentes del empleado " + (f + 1) + ":");
                int Columnas = int.Parse(Console.ReadLine());
                DiasAusentes[f] = new int[Columnas];
            }
        }
        public void Imprimir()
        {
             for(int f = 0; f < Empleados.Length; f++)
            {
                Console.WriteLine("El empleado " + Empleados[f] + " faltó " + DiasAusentes[f].Length + " dias");
            }   
        }
        
        public void ECMI()
        {
            int MenosFaltas = DiasAusentes[0].Length;
            string EmpleadoTop = Empleados[0];

            for(int f = 0; f < Empleados.Length; f++)
            {
                if (DiasAusentes[f].Length < MenosFaltas)
                {
                    EmpleadoTop = Empleados[f];
                    MenosFaltas = DiasAusentes[f].Length;
                }
            }
            Console.WriteLine("El empleado que falto menos dias fue: " + EmpleadoTop);

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Carga();
            p.Imprimir();
            p.ECMI();
        }
    }
}
