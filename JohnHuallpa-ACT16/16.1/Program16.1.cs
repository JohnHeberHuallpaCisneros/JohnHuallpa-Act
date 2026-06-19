/*
1. Confeccionar una clase Persona que tenga como atributos el nombre y la
edad (definir las propiedades para poder acceder a dichos atributos). Definir
un método para imprimirlos. Plantear una segunda clase Empleado que
herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
método para imprimir su sueldo. Definir un objeto de la clase Persona y
llamar a sus métodos y propiedades. También crear un objeto de la clase
Empleado y llamar a sus métodos y propiedades.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._1
{
    public class Persona
    {
        protected string nombre;
        protected int edad;

        public string Nombre
        {

            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre} edad: {edad}");
        }
    }
    public class Empleado : Persona
    {
        protected int sueldo;
        public int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        public void ImprimirSueldo()
        {
            {
                Console.WriteLine($"Sueldo del empleado ${sueldo}");
            }
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Console.WriteLine("Ingrese el nombre de la persona: ");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de esa persona");
            p.Edad = int.Parse( Console.ReadLine() );

            Console.WriteLine("Datos de la persona: ");
            p.Imprimir();
            Console.WriteLine();

            Empleado e = new Empleado();
            Console.WriteLine("Ingrese el nombre del empleado: ");
            e.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de ese empleado: ");
            e.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo del empleado: ");
            e.Sueldo = int.Parse( Console.ReadLine());

            Console.WriteLine("Datos de los empleados: ");
            e.Imprimir();
            e.ImprimirSueldo();
        }
    }
}
