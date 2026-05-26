/*
Implementar la clase operaciones. Se deben cargar dos valores enteros en el
constructor, calcular su suma, resta, multiplicación y división, cada una en un
método, imprimir dichos resultados.
 */
using System;

namespace _13._2
{
    class Operaciones
    {
        private double valor1;
        private double valor2;

        public Operaciones()
        {
            Console.WriteLine("Ingrese el valor n°1: ");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor n°2: ");
            valor2 = float.Parse(Console.ReadLine());
        }
        public double suma()
        {
            double sumatotal = valor1 + valor2;

            return sumatotal;
        }
        public double resta()
        {
            double restatotal = valor1 - valor2;

            return restatotal;
        }
        public double multiplicacion()
        {
            double multitotal = valor1 * valor2;

            return multitotal;
        }
        public double division()
        {
            double divisiontotal = valor1 / valor2;

            Console.ReadKey();
            return divisiontotal;
        }
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.suma();
            op.resta();
            op.multiplicacion();
            op.division();
        }
    }
}
