/*
1. Monitoreo Clínico de Pacientes
En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo cardíaco de los pacientes.
Plantear una clase llamada Paciente que tenga como atributos privados:
Nombre (de tipo string).
Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los registros de pulsaciones tomados durante 3 días diferentes,
en 4 momentos clave de cada día: mañana, mediodía, tarde y noche).
El constructor de Paciente debe pedir su nombre y solicitar la carga por teclado de las 12 lecturas cardíacas.
Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3 objetos de la clase Paciente.
Su constructor debe inicializar el vector y solicitar la carga de los 3 pacientes.
Implementar los siguientes métodos dentro de SalaMonitoreo:
Un método que imprima la grilla de lecturas cardíacas completa de cada paciente organizada por día y momento.
Un método que calcule e imprima el promedio de pulsaciones de cada paciente a lo largo de todo su monitoreo.
Un método que verifique si algún paciente registró un evento de taquicardia severa (cualquier lectura individual
que sea estrictamente mayor a 120 pulsaciones), mostrando por consola su nombre y la lectura detectada.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    class Paciente
    {
        private string Nombre;
        private int[,] ritmoCardiaco;
        public Paciente()
        {
            ritmoCardiaco = new int[3, 4];
            Console.WriteLine("Ingrese el nombre del paciente:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese las lecturas cardíacas (3 dias, 4 momentos del dia):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Día {i + 1}, Momento {j + 1}: ");
                    ritmoCardiaco[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public int[,] GetRitmoCardiaco()
        {
            return ritmoCardiaco;
        }
    }
    class SalaMonitoreo
    {
        private Paciente[] Pacientes;
        public SalaMonitoreo()
        {
            Pacientes = new Paciente[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Cargando paciente {i + 1}:");
                Pacientes[i] = new Paciente();
            }
        } public void ImprimirGrilla()
        {
            foreach (var paciente in Pacientes)
            {
                Console.WriteLine($"Paciente: {paciente.GetNombre()}");
                int[,] ritmo = paciente.GetRitmoCardiaco();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(ritmo[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void calcularPromedio()
        {
            foreach (var paciente in Pacientes)
            {
                int[,] ritmo = paciente.GetRitmoCardiaco();
                int suma = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        suma += ritmo[i, j];
                    }
                }
                double promedio = suma / 12.0;
                Console.WriteLine($"Promedio de pulsaciones de {paciente.GetNombre()}: {promedio}");
            }
        }
        public void VerificarTaquicardia()
        {
            foreach (var paciente in Pacientes)
            {
                int[,] ritmo = paciente.GetRitmoCardiaco();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (ritmo[i, j] > 120)
                        {
                            Console.WriteLine($"Paciente {paciente.GetNombre()} registró taquicardia severa: {ritmo[i, j]} pulsaciones");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {     SalaMonitoreo sala = new SalaMonitoreo();
            sala.ImprimirGrilla();
            sala.calcularPromedio();
            sala.VerificarTaquicardia();
        }
    }
}
