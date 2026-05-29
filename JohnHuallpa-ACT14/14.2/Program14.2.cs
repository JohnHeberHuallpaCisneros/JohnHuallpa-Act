/*
2. Control de Vuelos
Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar
la carga por teclado de cada uno de los 4 pasajeros.
Agregar los siguientes métodos en la clase Vuelo:
Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2
{
    class Pasajeros
    {
        private string Nombre;
        private int DNI;
        private float EquipajeKilos;

        public Pasajeros()
        {
            Console.WriteLine("Ingrese el nombre del pasajero: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el DNI de ese pasajero: ");
            DNI = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso de su equipaje (kg): ");
            EquipajeKilos = float.Parse(Console.ReadLine());

            Console.WriteLine();
        }
        public string Getnombre()
        {
            return Nombre;
        }
        public int GetDNI()
        {
            return DNI;
        }
        public float GetEquipajeKilos()
        {
            return EquipajeKilos;
        }
        
        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre + " DNI: " + DNI + " Equipaje: " + EquipajeKilos + "kg");
        }
    }
    class Vuelo
    {
        private Pasajeros[] Pasajero_b;

        public Vuelo()
        {
            Pasajero_b = new Pasajeros[4];

            for(int i = 0; i < Pasajero_b.Length; i++)
            {
                Pasajero_b[i] = new Pasajeros();
            }
        }

        public void ImprimirListado()
        {
            Console.WriteLine("Listado de pasajeros: ");

            for (int i = 0; i < Pasajero_b.Length; i++)
            {
                Pasajero_b[i].Imprimir();
            }
        }
        public void PesoTotalEquipaje()
        {
            float Suma = 0;
            float Total = 0;

            for(int i = 0; i < Pasajero_b.Length; i++)
            {
                Suma = Suma + Pasajero_b[i].GetEquipajeKilos();
            }
            Total = Total + Suma;

            Console.WriteLine("El total de peso en equipaje es de: " + Total + "kg");
        }

        public void Excesodeequipaje()
        {
            for(int i = 0; i < Pasajero_b.Length; i++)
            {
                if (Pasajero_b[i].GetEquipajeKilos() > 23)
                {
                    Console.WriteLine("El pasajero: " + Pasajero_b[i].Getnombre() + " Con el DNI de: " + Pasajero_b[i].GetDNI() + " Se ha excedido de peso en equipaje");
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Vuelo v = new Vuelo();
            v.ImprimirListado();
            v.PesoTotalEquipaje();
            v.Excesodeequipaje();
        }
    }
}
