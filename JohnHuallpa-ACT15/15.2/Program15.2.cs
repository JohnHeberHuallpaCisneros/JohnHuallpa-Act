/*
 Logística de Puerto Espacial
Una estación de acoplamiento registra el peso de los contenedores transportados en las bodegas de carga de las naves espaciales que llegan al puerto.
Crear la clase NaveEspacial que contenga únicamente el atributo privado NombreNave y su constructor para cargarlo.
Crear la clase colaboradora PuertoControl que contenga:
Un vector de 3 objetos de la clase NaveEspacial.
Una matriz irregular de tipo double llamado pesoContenedores, donde cada fila representa a una nave, el tamaño de la fila es la cantidad de bodegas que posee esa nave, y los valores almacenados son los pesos (en toneladas) de los contenedores que transporta cada bodega.
En PuertoControl, definir los siguientes métodos:
Un constructor que cargue los nombres de las 3 naves, pregunte para cada una cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz irregular) y cargue el peso del contenedor asignado a cada bodega.
Un método que muestre en pantalla el detalle de los pesos cargados por cada nave espacial.
Un método que identifique e informe qué nave transporta el contenedor individual más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz irregular).
Un método que indique el nombre de la nave que transporta menor peso acumulado total (la suma de todos sus contenedores).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._2
{
    class NaveEspacial
    {
        private string NombreNave;

        public NaveEspacial()
        {
            Console.Write("Ingrese el nombre de la nave: ");
            NombreNave = Console.ReadLine();
        }

        public string GetNombreNave()
        {
            return NombreNave;
        }
    }

    class PuertoControl
    {
        private NaveEspacial[] naves;
        private double[][] pesoContenedores;

        public PuertoControl()
        {
            naves = new NaveEspacial[3];
            pesoContenedores = new double[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nCarga de la nave {i + 1}");
                naves[i] = new NaveEspacial();

                Console.Write("¿Cuántas bodegas activas posee la nave?: ");
                int bodegas = int.Parse(Console.ReadLine());

                pesoContenedores[i] = new double[bodegas];

                for (int j = 0; j < bodegas; j++)
                {
                    Console.Write($"Peso del contenedor de la bodega {j + 1} (toneladas): ");
                    pesoContenedores[i][j] = double.Parse(Console.ReadLine());
                }
            }
        }

        public void MostrarPesos()
        {
            Console.WriteLine("Detalle de Peso:");

            for (int i = 0; i < naves.Length; i++)
            {
                Console.WriteLine($"Nave: {naves[i].GetNombreNave()}");

                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    Console.WriteLine($"Bodega {j + 1}: {pesoContenedores[i][j]} toneladas");
                }
            }
        }

        public void ContenedorMasPesado()
        {
            double mayor = pesoContenedores[0][0];
            string naveMayor = naves[0].GetNombreNave();

            for (int i = 0; i < pesoContenedores.Length; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    if (pesoContenedores[i][j] > mayor)
                    {
                        mayor = pesoContenedores[i][j];
                        naveMayor = naves[i].GetNombreNave();
                    }
                }
            }

            Console.WriteLine($"La nave que transporta el contenedor más pesado es {naveMayor} con {mayor} toneladas.");
        }

        public void NaveMenorPesoTotal()
        {
            double menorSuma = double.MaxValue;
            string naveMenor = "";

            for (int i = 0; i < pesoContenedores.Length; i++)
            {
                double suma = 0;

                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    suma += pesoContenedores[i][j];
                }

                if (suma < menorSuma)
                {
                    menorSuma = suma;
                    naveMenor = naves[i].GetNombreNave();
                }
            }

            Console.WriteLine($"La nave con menor peso acumulado es {naveMenor} con {menorSuma} toneladas.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PuertoControl p = new PuertoControl();

            p.MostrarPesos();
            p.ContenedorMasPesado();
            p.NaveMenorPesoTotal();
        }
    }
}
