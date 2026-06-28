/*
Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
realice su asignación.
Luego, definir dos clases derivadas de la clase base:
● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
soportada en atmósferas).
● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
clase SondaExploradora mediante el uso explícito de la palabra clave base.
En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
parámetros unificados por consola.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._3
{
    class SondaExploradora
    {
        private string modelo;
        private int autonomiaMinutos;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int AutonomiaMinutos
        {
            get { return autonomiaMinutos; }
            set { autonomiaMinutos = value; }
        }

        public SondaExploradora(string modelo, int autonomiaMinutos)
        {
            this.modelo = modelo;
            this.autonomiaMinutos = autonomiaMinutos;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Autonomía: " + autonomiaMinutos + " minutos");
        }
    }

    class SondaSubmarina : SondaExploradora
    {
        private int presionMaximaAtm;

        public SondaSubmarina(string modelo, int autonomia, int presion)
            : base(modelo, autonomia)
        {
            presionMaximaAtm = presion;
        }

        public void MostrarDatos2()
        {
            base.MostrarDatos();
            Console.WriteLine("Presión Máxima: " + presionMaximaAtm + " atm");
        }
    }

    class RoverTerrestre : SondaExploradora
    {
        private int cantidadRuedas;

        public RoverTerrestre(string modelo, int autonomia, int ruedas)
            : base(modelo, autonomia)
        {
            cantidadRuedas = ruedas;
        }

        public void MostrarDatos3()
        {
            base.MostrarDatos();
            Console.WriteLine("Cantidad de Ruedas: " + cantidadRuedas);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sonda Submarina:");
            Console.Write("Modelo: ");
            string m1 = Console.ReadLine();

            Console.Write("Autonomía: ");
            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Presión máx: ");
            int p = int.Parse(Console.ReadLine());

            SondaSubmarina sub = new SondaSubmarina(m1, a1, p);

            Console.WriteLine("Rover Terrestre:");
            Console.Write("Modelo: ");
            string m2 = Console.ReadLine();
            Console.Write("Autonomía: ");
            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Ruedas: ");
            int r = int.Parse(Console.ReadLine());

            RoverTerrestre rover = new RoverTerrestre(m2, a2, r);

            Console.WriteLine("Sonda Submarina");
            sub.MostrarDatos2();

            Console.WriteLine("Rover Terrestre");
            rover.MostrarDatos3();

            Console.ReadKey();
        }
    }
}
