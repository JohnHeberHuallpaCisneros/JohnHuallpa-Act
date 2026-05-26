/*
1. Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
En el constructor cargar los atributos y luego en otro
método imprimir sus datos y por último uno que imprima un mensaje si debe
pagar impuestos (si el sueldo supera a 3000)
 */
using System;

namespace _13._1
{
    class Empleados
    {
        private string nombre;
        private int sueldo;
        public Empleados()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo de " + nombre + ": ");
            sueldo = int.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }
        public void Comprobación()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El usuario debe que pagar impuestos.");
            }
            else
            {
                Console.WriteLine("El usuario no debe que pagar impuestos.");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Empleados e = new Empleados();
            e.Imprimir();
            e.Comprobación();
        }
    }
}
