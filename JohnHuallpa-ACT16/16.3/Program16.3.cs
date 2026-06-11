/*
3. Crear una clase base Vehículo que contenga atributos marca y
velocidadMaxima.
Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
una debe tener un constructor que reciba los valores de los atributos base
mediante la palabra clave base, y un atributo propio (cantidadPuertas en
Auto, cilindrada en Moto).
Crear un objeto de cada clase y mostrar todos sus datos por consola.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._3
{
    class Vehiculo
    {
        protected string marca;
        protected int velocidadMaxima;

        public Vehiculo(string mar, int velMax)
        {
            marca = mar;
            velocidadMaxima = velMax;
        }
        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        public int VelocidadMaxima
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }
    }
     class Auto : Vehiculo
    {
        private int cantidadPuertas;

        public Auto(string mar, int velMax, int cantPuertas) : base(mar, velMax)
        {
            cantidadPuertas = cantPuertas;
        }

        public int CantidadPuertas
        {
            set
            {
                cantidadPuertas = value;
            }
            get
            {
                return cantidadPuertas;
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Velocidad máxima: {VelocidadMaxima}km/h");
            Console.WriteLine($"Cantidad de puertas: {CantidadPuertas}");
        }
    }
      class Moto: Vehiculo
    {
        private int cilindrado;

        public Moto(string mar, int velMax, int cil) : base(mar, velMax)
        {
            cilindrado = cil;
        }
        public int Cilindrado
        {
            set
            {
                cilindrado = value;
            }
            get
            {
                return cilindrado;
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Velocidad máxima: {VelocidadMaxima}km/h");
            Console.WriteLine($"Cilindrada: {Cilindrado} cc");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Auto a1 = new Auto("Toyota", 180, 4);
            Moto m1 = new Moto("Yamaha", 220, 250);

            Console.WriteLine("Mostar datos del auto: ");
            a1.MostrarDatos();

            Console.WriteLine("Mostar datos de la moto: ");
            m1.MostrarDatos();
        }
    }
}
