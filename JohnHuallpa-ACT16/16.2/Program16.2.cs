/*
2. Plantear una clase Producto y otra clase Inventario.
La clase Producto debe tener como atributos privados el nombre, precio y
stock. Definir propiedades para acceder a estos atributos, asegurando que el
stock no pueda ser negativo y el precio sea mayor a cero.
La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
método para mostrar todos los productos ordenados de menor a mayor en
base al precio, además, mostrar el producto más caro y más barato del
inventario.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _16._2
{
    class Producto
    {
        private string nombre;
        private double precio;
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

        public double Precio
        {
            set
            {
                if (value > 0)
                    precio = value;

                else
                    Console.WriteLine("El precio debe de ser mayor a 0");
            }
            get
            {
                return precio;
            }
        }

        public int Stock
        {
            set
            {
                if (value >= 0)
                    stock = value;

                else
                    Console.WriteLine("El stock no puede estar en negativo");
            }
            get
            {
                return stock;
            }
        }
    }
    class Inventario
    {
        private Producto[] productos = new Producto[3];

        public Inventario()
        {
            productos[0] = new Producto();
            productos[0].Nombre = "Leche";
            productos[0].Precio = 5;
            productos[0].Stock = 10;

            productos[1] = new Producto();
            productos[1].Nombre = "Cereal";
            productos[1].Precio = 2;
            productos[1].Stock = 1;

            productos[2] = new Producto();
            productos[2].Nombre = "cuchara";
            productos[2].Precio = 6;
            productos[2].Stock = 12;
        }
        public void ImprimirOrdenar()
        {
            for(int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = 0; j < productos.Length; j++)
                {
                    if (productos[i].Precio > productos[i + 1].Precio)
                    {
                        double aux = productos[i].Precio;
                        productos[i].Precio = productos[j].Precio;
                        productos[j].Precio = aux;
                    }
                }
            }
            Console.WriteLine("Productos ordenados de menor a mayor en precios: ");

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"{productos[i].Nombre} con el precio de: ${productos[i].Precio} ");
            }

            Console.WriteLine($"El producto más barato es: {productos[0].Nombre}");
            Console.WriteLine($"El producto más caro es: {productos[2].Nombre}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Inventario i = new Inventario();
            i.ImprimirOrdenar();
        }
    }
}
