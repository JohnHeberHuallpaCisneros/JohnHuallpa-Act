/*
4. Línea de Ensamblaje Robótico
En una planta de fabricación automatizada, cada robot industrial realiza tareas de
ensamblaje complejas divididas en operaciones secundarias de duración variable.
● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
1. ModeloRobot.
2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
fila representa una de las 4 fases principales del proceso (Estructura,
Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
completar las distintas subtareas de esa fase (por ejemplo, en la fase de
Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
1).
3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
una de ellas.

● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
RobotEnsamblador. Implementar en PlantaIndustrial:
1. Un constructor que cargue la información de los 3 robots instalados en la
planta.
2. Un método que muestre un reporte detallado con los tiempos de operación
de cada robot fase por fase.
3. Un método que calcule el promedio general de tiempo por tarea de cada
robot y declare al &quot;Robot más Eficiente&quot; (aquel que registre el promedio de
tiempo por operación más bajo de la planta).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._4
{
    class RobotEnsamblador
    {
        private string ModeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

            Console.Write("Ingrese el modelo del robot: ");
            ModeloRobot = Console.ReadLine();

            tiemposOperacion = new float[4][];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Cantidad de subtareas en la fase {fases[i]}: ");
                int cantidad = int.Parse(Console.ReadLine());

                tiemposOperacion[i] = new float[cantidad];

                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write($"Tiempo de la subtarea {j + 1} (segundos): ");
                    tiemposOperacion[i][j] = float.Parse(Console.ReadLine());
                }
            }
        }

        public string GetModeloRobot()
        {
            return ModeloRobot;
        }

        public float[][] GetTiemposOperacion()
        {
            return tiemposOperacion;
        }
    }

    class PlantaIndustrial
    {
        private RobotEnsamblador[] robots;

        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nCargando robot {i + 1}");
                robots[i] = new RobotEnsamblador();
            }
        }

        public void ReporteTiempos()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

            Console.WriteLine("Reporte de tiempos: ");

            foreach (var robot in robots)
            {
                Console.WriteLine($"\nRobot: {robot.GetModeloRobot()}");

                float[][] tiempos = robot.GetTiemposOperacion();

                for (int i = 0; i < tiempos.Length; i++)
                {
                    Console.WriteLine($"Fase: {fases[i]}");

                    for (int j = 0; j < tiempos[i].Length; j++)
                    {
                        Console.WriteLine($"  Subtarea {j + 1}: {tiempos[i][j]} segundos");
                    }
                }
            }
        }

        public void RobotMasEficiente()
        {
            string mejorRobot = "";
            float mejorPromedio = float.MaxValue;

            foreach (var robot in robots)
            {
                float[][] tiempos = robot.GetTiemposOperacion();

                float suma = 0;
                int cantidadTareas = 0;

                for (int i = 0; i < tiempos.Length; i++)
                {
                    for (int j = 0; j < tiempos[i].Length; j++)
                    {
                        suma += tiempos[i][j];
                        cantidadTareas++;
                    }
                }

                float promedio = suma / cantidadTareas;

                Console.WriteLine($"Promedio de {robot.GetModeloRobot()}: {promedio:F2} segundos");

                if (promedio < mejorPromedio)
                {
                    mejorPromedio = promedio;
                    mejorRobot = robot.GetModeloRobot();
                }
            }

            Console.WriteLine("Robot más eficiente: ");
            Console.WriteLine(
                $"{mejorRobot} con un promedio de {mejorPromedio:F2} segundos por operación.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PlantaIndustrial p = new PlantaIndustrial();

            p.ReporteTiempos();
            p.RobotMasEficiente();
        }
    }
}
