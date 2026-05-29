/*
4. Inventario de Sucursales 
Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual.
El constructor de la clase debe cargar estos atributos por teclado.
Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo.
El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
Implementar en la clase Sucursal los siguientes métodos:
Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
Un método que busque y muestre el nombre del artículo más caro del local.
Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._4
{
    class Articulo
    {
        private string NombreArticulo;
        private int Precio;
        private int StockActual;

        public Articulo()
        {
            Console.WriteLine("Ingresa el nombre del articulo: ");
            NombreArticulo = Console.ReadLine();
            Console.WriteLine("Ingresa el precio: ");
            Precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa su stock actual: ");
            StockActual = int.Parse(Console.ReadLine());
        }
        public void ImprimirArticulos()
        {
            Console.WriteLine("Articulo: " + NombreArticulo + " valor total de inventario: " + (Precio * StockActual));
            Console.WriteLine();
        }
        public int valor()
        {
            return Precio;
        }
        public string GetNombre()
        {
            return NombreArticulo;
        }
        public int stock()
        {
            return StockActual;
        }
    }
    class Sucursal
    {
        private Articulo[] Productos;
        private string NombreSucursal;
        private int NumeroSucursal;

        public Sucursal()
        {
            Productos = new Articulo[3];
            Console.WriteLine("Ingresa el nombre de la sucursal: ");
            NombreSucursal = Console.ReadLine();
            Console.WriteLine("Ingresa el numero de la sucursal: ");
            NumeroSucursal = int.Parse(Console.ReadLine());

            for(int i = 0; i < Productos.Length; i++)
            {
                Productos[i] = new Articulo();
            }

        }

        public void Impresion()
        {
            Console.WriteLine("Esta es la sucursal " + NombreSucursal + " N° " + NumeroSucursal);
            Console.WriteLine("Esta es la lista de articulos: ");
            for(int i = 0; i < Productos.Length; i++)
            {
                Productos[i].ImprimirArticulos();
            }
        }

        public void ArticuloMayorValor()
        {
            int mayorvalor = Productos[0].valor();
            string nombremayorvalor = Productos[0].GetNombre();
            for(int i = 0; i < Productos.Length; i++)
            {
                if (Productos[i].valor() > mayorvalor)
                {
                    mayorvalor = Productos[i].valor();
                    nombremayorvalor = Productos[i].GetNombre();
                }
            }
            Console.WriteLine("El articulo con mayor valor es: " + nombremayorvalor);
        }

        public void AdvertenciaReposicion()
        {
            for(int i = 0; i < Productos.Length; i++)
            {
                if (Productos[i].stock() <= 5)
                {
                    Console.WriteLine("El articulo " + Productos[i].GetNombre() + " requiere reposicion urgente");
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Sucursal s = new Sucursal();
            s.Impresion();
            s.ArticuloMayorValor();
            s.AdvertenciaReposicion();
        }
    }
}
