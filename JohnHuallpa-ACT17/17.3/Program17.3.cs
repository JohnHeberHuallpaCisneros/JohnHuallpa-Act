/*
3. Fábrica de Computadoras (Herencia y Constructores con base)
Crear una clase base llamada Computadora que contenga los atributos Marca y
MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
Luego, definir dos clases derivadas de la clase base:
 Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
 Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3
{
    class Computadora
    {
        protected string marca;
        protected int memoriaRAM;

        public Computadora(string mar, int ram)
        {
            marca = mar;
            memoriaRAM = ram;
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

        public int MemoriaRAM
        {
            set 
            {
                memoriaRAM = value; 
            }
            get
            { 
                return memoriaRAM;
            }
        }
    }

    class Notebook : Computadora
    {
        private int tamanoPantalla;

        public Notebook(string mar, int ram, int tamPant) : base(mar, ram)
        {
            tamanoPantalla = tamPant;
        }

        public int TamanoPantalla
        {
            set
            { 
                tamanoPantalla = value; 
            }
            get
            {
                return tamanoPantalla;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Memoria RAM: " + MemoriaRAM + " GB");
            Console.WriteLine("Tamaño Pantalla: " + tamanoPantalla + " pulgadas");
        }
    }

    class Escritorio : Computadora
    {
        private int potenciaFuente;

        public Escritorio(string mar, int ram, int potFuente) : base(mar, ram)
        {
            potenciaFuente = potFuente;
        }

        public int PotenciaFuente
        {
            set
            {
                potenciaFuente = value; 
            }
            get
            {
                return potenciaFuente;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Memoria RAM: " + MemoriaRAM + " GB");
            Console.WriteLine("Potencia Fuente: " + potenciaFuente + " Watts");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook nb = new Notebook("Dell", 16, 15);
            Escritorio esc = new Escritorio("HP", 32, 650);

            Console.WriteLine("Notebook");
            nb.MostrarDatos();

            Console.WriteLine("Escritorio");
            esc.MostrarDatos();

            Console.ReadKey();
        }
    }
}
