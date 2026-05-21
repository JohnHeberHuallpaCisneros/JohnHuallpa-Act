/*
 Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
cantidad diferente de paquetes por día dependiendo de su demanda.
● Definir un vector de tipo string para los nombres de las 3 sucursales.
● Definir una matriz irregular donde cada fila sea una sucursal y cada columna represente el peso (en kg) de cada paquete enviado.
● Métodos:
1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
paquetes se enviaron hoy para definir el tamaño de su fila.
2. Cargar el peso de cada paquete.
3. Imprimir el peso de todos los paquetes organizados por sucursal.
4. Calcular e informar el peso total despachado por cada sucursal.
5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
pertenece.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    class Program
    {
        private string[] Empresa;
        private int[][] Sucursales;

        public void Carga()
        {
            Empresa = new string[3];
            Sucursales = new int[3][];
            for (int f = 0; f < Empresa.Length; f++)
            {
                Console.WriteLine("Ingresa el nombre de la sucursal: ");
                Empresa[f] = Console.ReadLine();

                Console.WriteLine("Cantidad de paquetes enviados a la sucursal: ");
                int columnas = int.Parse(Console.ReadLine());
                Sucursales[f] = new int[columnas];
                for (int c = 0; c < Sucursales[f].Length; c++)
                {
                    Console.WriteLine("Ingresa el peso de cada paquete: ");
                    int peso = int.Parse(Console.ReadLine());
                    Sucursales[f][c] = peso;
                }
            }
        }
        public void MostrarPeso()
        {
            for (int f = 0; f < Empresa.Length; f++)
            {
                Console.WriteLine("Peso de los paquetes de la sucursal " + Empresa[f] + ": ");
                for (int c = 0; c < Sucursales[f].Length; c++)
                {
                    Console.WriteLine(Sucursales[f][c] + "kg");
                }
            }
        }
        public void PesoTotalxSucursal()
        {
            int total = 0;
            int suma = 0;
            for (int f = 0; f < Empresa.Length; f++)
            {
                for (int c = 0; c < Sucursales[f].Length; c++)
                {
                    suma = suma + Sucursales[f][c];
                }
                total = suma;
                suma = 0;
                Console.WriteLine("En la sucursal " + Empresa[f] + " el peso total de productos despachados es de: " + total + "kg");
            }
        }
        public void Packmáspesado()
        {
            int pesado = Sucursales[0][0];
            string sucursalconmayorpeso = Empresa[0];
            for (int f = 0; f < Empresa.Length; f++)
            {
                for (int c = 0; c < Sucursales[f].Length; c++)
                {
                    if (Sucursales[f][c] > pesado)
                    {
                        pesado = Sucursales[f][c];
                        sucursalconmayorpeso = Empresa[f];
                    }
                }
            }
            Console.WriteLine("El paquete con mayor peso es de: " + pesado + "kg, perteneciente a la empresa: " + sucursalconmayorpeso);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Carga();
            p.MostrarPeso();
            p.PesoTotalxSucursal();
            p.Packmáspesado();
        }
    }
}
