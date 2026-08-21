/*
Una farmacia controla el nivel de stock de sus medicamentos para evitar el
desabastecimiento de insumos esenciales.
 Crear la clase Medicamento que contenga los atributos privados: nombre
(string) y stock (int). Definir sus propiedades correspondientes. Su
constructor debe recibir nom y stk.

 Crear la clase ControlFarmacia que administre una lista de objetos List.
 Métodos en ControlFarmacia:
o Un constructor que cargue por teclado una lista inicial de 4
medicamentos ingresando sus nombres y stock.

o ListarStock(): Mostrar la lista de medicamentos en pantalla.

o RemoverAgotados(): Recorrer la lista y remover por completo de
la colección a todos aquellos medicamentos cuyo stock sea igual a 0.

o MostrarMedicamentosDisponibles(): Imprimir la lista
actualizada y la cantidad de productos

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._8
{
    class Medicamento
    {
        private string nombre;
        private int stock;

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
        public int Stock
        {
            set
            {
                stock = value;    
            }
            get
            {
                return stock;
            }
        }
        public Medicamento(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }
    }
     class ControlFarmacia
    {
        private List<Medicamento> medicamentos;

        public ControlFarmacia()
        {
            medicamentos = new List<Medicamento>();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del medicamento: ");
                string nom = Console.ReadLine();
                Console.WriteLine("Ingrese el stock del medicamento: ");
                int stk = int.Parse(Console.ReadLine());
                Medicamento m = new Medicamento(nom, stk);
                medicamentos.Add(m);
            }
        }
        public void ListarStock()
        {
            Console.WriteLine("Listado de medicamentos: ");

            if (medicamentos.Count > 0)
            {
                for(int i = 0; i < medicamentos.Count; i++)
                {
                    Medicamento m = medicamentos[i];
                    Console.WriteLine($"Medicamento: {m.Nombre}");
                }
            }
        }

        public void RemoverAgotados()
        {
            for(int i = 0;i < medicamentos.Count; i++)
            {
                if (medicamentos[i].Stock <= 0)
                {
                    medicamentos.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine($"{medicamentos[i].Nombre} aun posee stock");
                }
            }
        }

        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("Lista actualizada de medicamentos en stock");
            if (medicamentos.Count > 0)
            {
                for (int i = 0; i < medicamentos.Count; i++)
                {
                    Medicamento m = medicamentos[i];
                    Console.WriteLine($"Medicamento: {m.Nombre} Stock {m.Stock}");
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            ControlFarmacia cf = new ControlFarmacia();
            cf.ListarStock();
            cf.RemoverAgotados();
            cf.MostrarMedicamentosDisponibles();
        }
    }
}
