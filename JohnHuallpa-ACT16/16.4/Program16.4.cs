/*
4. Armar tres clases: Animal, Mamífero y Perro.
La clase Animal debe tener un atributo especie.
La clase Mamífero, que hereda de Animal, debe tener un atributo
tipoAlimentacion.
La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
Cada clase debe tener un constructor que reciba los datos correspondientes
y los imprima indicando a qué clase pertenecen. Los datos deben ser
asignados previamente
Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
constructores.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._4
{
    class Animal
    {
        protected string especie;

        public Animal(string esp)
        {
            especie = esp;
            Console.WriteLine("Constructor de la clase Animal");
            Console.WriteLine("Especie: " + especie);
        }
    }

    class Mamifero : Animal
    {
        protected string tipoAlimentacion;

        public Mamifero(string esp, string tipoAli) : base(esp)
        {
            tipoAlimentacion = tipoAli;
            Console.WriteLine("Constructor de la clase Mamífero");
            Console.WriteLine("Tipo de Alimentación: " + tipoAlimentacion);
        }
    }

    class Perro : Mamifero
    {
        private string nombre;

        public Perro(string esp, string tipoAli, string nom) : base(esp, tipoAli)
        {
            nombre = nom;
            Console.WriteLine("Constructor de la clase Perro");
            Console.WriteLine("Nombre: " + nombre);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando objeto de la clase Perro: ");

            Perro perro1 = new Perro("Canino", "Carnívoro", "Poni");

            Console.ReadKey();
        }
    }
}