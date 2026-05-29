/*
3. Competencia de Atletismo
Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera).
Definir un constructor para ingresar ambos datos.
Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
Definir los siguientes métodos en la clase Carrera:
Un constructor que cargue los datos de los 3 atletas de la carrera.
Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
Un método que calcule e imprima el tiempo promedio de la carrera.
Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
Un método que muestre a los atletas que superaron el promedio.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._3
{
    class Atleta
    {
        private string Nombre;
        private int TiempoSegundos;
        
        public Atleta()
        {
            Console.WriteLine("ingrese el nombre del atleta: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tiempo en segundos del atleta: ");
            TiempoSegundos = int.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("Atleta: " + Nombre + " Tiempo en segundos: " + TiempoSegundos);
            Console.WriteLine();
        }
        public int Tiempo()
        {
            return TiempoSegundos;
        }
        public string NombreAtleta()
        {
            return Nombre;
        }
    }
    class Luego
    {
        private Atleta Atleta1;
        private Atleta Atleta2;
        private Atleta Atleta3;

        public Luego()
        {
            Atleta1 = new Atleta();
            Atleta2 = new Atleta();
            Atleta3 = new Atleta();
        }
        public void ImprimirAtletas()
        {
            Atleta1.Imprimir();
            Atleta2.Imprimir();
            Atleta3.Imprimir();
        }
        public int TiempoPromedio()
        {
            int Calculo = (Atleta1.Tiempo() + Atleta2.Tiempo() + Atleta3.Tiempo()) / 3;
            int Total = Calculo;
            Console.WriteLine("¡El tiempo promedio de la carrera es de: " + Total + " segundos!");
            return Total;
        }

        public void Ganador()
        {
            int Mejor_T = Atleta1.Tiempo();
            String NombreGanador = Atleta1.NombreAtleta();

            if(Atleta2.Tiempo() < Mejor_T)
            {
                Mejor_T = Atleta2.Tiempo();
                NombreGanador = Atleta2.NombreAtleta();
            }
            if(Atleta3.Tiempo() < Mejor_T)
            {
                Mejor_T = Atleta3.Tiempo();
                NombreGanador = Atleta3.NombreAtleta();
            }
            Console.WriteLine("El Atleta con menor tiempo es: " + NombreGanador);
        }

        public void SuperanPromedio()
        {
            int promedio = TiempoPromedio();
            if(Atleta1.Tiempo() < promedio)
            {
                Console.WriteLine("El atleta que superó el promedio es: " + Atleta1.NombreAtleta());
            }
            if (Atleta2.Tiempo() < promedio)
            {
                Console.WriteLine("El atleta que superó el promedio es: " + Atleta2.NombreAtleta());
            }
            if (Atleta3.Tiempo() < promedio)
            {
                Console.WriteLine("El atleta que superó el promedio es: " + Atleta3.NombreAtleta());
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Luego l = new Luego();
            l.ImprimirAtletas();
            l.Ganador();
            l.SuperanPromedio();
        }
    }
}
