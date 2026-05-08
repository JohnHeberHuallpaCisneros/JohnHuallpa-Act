/*
Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
dato las temperaturas medias mensuales de dichos paises.
Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
mensuales.
Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
memoria.
a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
mismas.
c. Calcular la temperatura media trimestral de cada país.
d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
e. Imprimir el nombre del país con la temperatura media trimestral mayor. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
     class Program
    {
        private string[] Paises;
        private double[,] Climas;
        private double[] TemperaturaTrimestral;
        public void CargarM()
        {
            Climas = new double[4, 3];
            Paises = new string [4];

            for(int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del pais: ");
                Paises[i] = Console.ReadLine();

                    for(int c = 0; c < Climas.GetLength(1); c++)
                    {
                        Console.WriteLine("Ingresa las 3 temperaturas medias mensuales de ese pais: ");
                        String valor = Console.ReadLine();
                        Climas[i, c] = double.Parse(valor);
                    }
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Pais: ");

            for(int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine(Paises[i] + " ");
                Console.WriteLine("Sus 3 temperaturas mensuales son: ");
                for(int c = 0; c < Climas.GetLength(1); c++)
                {
                    Console.WriteLine(Climas[i, c]);
                }
            }
        }
        public void TTM()
        {
            TemperaturaTrimestral = new double[4];
            for(int f = 0; f < Climas.GetLength(0); f++)
            {
                double suma = 0;
                for(int c = 0; c < Climas.GetLength(1); c++)
                {
                    suma = suma + Climas[f, c];
                }
                TemperaturaTrimestral[f] = suma / Climas.GetLength(1);
            }
        }
        public void ImprimirPromedioT()
        {
            Console.WriteLine("Paises con su promedio trimestral: ");

            for(int f = 0; f < Climas.GetLength(0); f++)
            {
                Console.WriteLine(Paises[f] + ": " + TemperaturaTrimestral[f]);
            }
        }
        public void PromedioMayor()
        {
            double Pmayor = TemperaturaTrimestral[0];
            string PaisMayor = Paises[0];
            for(int c = 0; c < TemperaturaTrimestral.Length; c++)
            {
                if (TemperaturaTrimestral[c] > Pmayor)
                {
                    Pmayor = TemperaturaTrimestral[c];
                    PaisMayor = Paises[c];
                }
            }
            Console.WriteLine("El pais con mayor temperatura trimestral es: " + PaisMayor);

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CargarM();
            p.Imprimir();
            p.TTM();
            p.ImprimirPromedioT();
            p.PromedioMayor();

        }
    }
}
