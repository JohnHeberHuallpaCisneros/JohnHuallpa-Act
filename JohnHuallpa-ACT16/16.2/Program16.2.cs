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
        public Producto()
        {
            nombre = "";
            precio = 0;
            stock = 0;
        }

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
            for(int i = 0; i < productos.Length; i++)
            {
                productos[i] = new Producto();

                Console.WriteLine("ingrese el nombre del producto");
                productos[i].Nombre = Console.ReadLine();
                Console.WriteLine("ingrese el precio del producto");
                productos[i].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el stock del producto");
                productos[i].Stock = int.Parse(Console.ReadLine());
            }
        }
        public void ImprimirOrdenar()
        {
            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = 0; j < productos.Length - 1; j++)
                {
                    if (productos[j].Precio > productos[j + 1].Precio)
                    {
                        Producto aux = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = aux;
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
