/*
1. El Sistema de Peaje.
Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
La clase Vehiculo debe tener los siguientes atributos privados:
Patente (de tipo string).
Tipo (puede ser "Auto", "Camion" o "Moto").
Tarifa (un valor decimal que representa el costo de su pase).
El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
La clase CabinaPeaje debe tener como atributos privados:
El número o identificador de la cabina.
Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
1 - Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
2 - Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
3 - Un método que muestre la patente del vehículo que pagó la tarifa más cara 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _14._1
{
    class Vehiculo
    {
        private string Patente;
        private float Tarifa;
        private string Tipo;

        public Vehiculo()
        {
            Console.WriteLine("Ingrese la patente del vehiculo: ");
            Patente = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de vehiculo (Auto, Camion, Moto): ");
            Tipo = Console.ReadLine();

            Console.WriteLine("Ingresa la tarifa del vehiculo: ");
            Tarifa = float.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("Pantente del vehiculo:" + Patente);
            Console.WriteLine("Tipo del Vehiculo: " + Tipo);
            Console.WriteLine();
        }
        public float tarifa_v()
        {
            return Tarifa;
        }
        public string patente_v()
        {
            return Patente;
        }
    }
    class CabinaPeaje
    {
        private int id_cabina;
        private Vehiculo Vehiculo1;
        private Vehiculo Vehiculo2;
        private Vehiculo Vehiculo3;
        
        public CabinaPeaje()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el id de la cabina de peaje: ");
            id_cabina = int.Parse(Console.ReadLine());

            Vehiculo1 = new Vehiculo();
            Vehiculo2 = new Vehiculo();
            Vehiculo3 = new Vehiculo();
        }

        public void Imprimir_Patente_Tipo()
        {
            Console.WriteLine("Vehiculos en la cabina " + id_cabina + ": ");
            Vehiculo1.Imprimir();
            Vehiculo2.Imprimir();
            Vehiculo3.Imprimir();
        }
        public void Recaudacion_total()
        {
            float recaudacion = Vehiculo1.tarifa_v() + Vehiculo2.tarifa_v() + Vehiculo3.tarifa_v();
            Console.WriteLine("Recaudación total de los 3 vehiculos en base a las tarifas: " + recaudacion);
        }
        public void Vehiculo_mayor_tarifa()
        {
            Vehiculo mayortarifa = Vehiculo1;
            if(Vehiculo2.tarifa_v() > mayortarifa.tarifa_v())
            {
                mayortarifa = Vehiculo2;
            }
            if(Vehiculo3.tarifa_v() > mayortarifa.tarifa_v())
            {
                mayortarifa = Vehiculo3;
            }
            Console.WriteLine("La patente con mayor tarifa es: " + mayortarifa.patente_v());
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            CabinaPeaje c = new CabinaPeaje();
            c.Imprimir_Patente_Tipo();
            c.Recaudacion_total();
            c.Vehiculo_mayor_tarifa();
        }
    }
}
