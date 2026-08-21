/*
Un restaurante automatizado procesa la comanda de una mesa para controlar la
preparación y el cobro de los platos pedidos.
 Crear la clase Plato que contenga como atributos privados: nombrePlato
(string) y precio (double). Definir sus propiedades correspondientes y un
constructor que reciba nom y pre.
 Crear la clase GestionComandas que administre una lista de objetos List.
 Métodos en GestionComandas:
o AgregarPlato():Solicitar por teclado los datos de un plato y
agregarlo a la lista utilizando .Add().
o MostrarComanda(): Listar todos los platos agregados hasta el
momento junto a la cantidad total de ítems pedidos utilizando la
propiedad .Count.
o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
total a cobrar sumando los precios de la lista.
o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
se encuentra en la lista, removerlo mediante .Remove() para
actualizar la comanda.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._7
{
    class Plato
    {
        private string nombrePlato;
        private double precio;
        public string NombrePlato
        {
            set
            {
                nombrePlato = value;
            }
            get
            {
                return nombrePlato;
            }
        }
        public double Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }
        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }
    }
     class GestionComandas
    {
        private List<Plato> lista;

        public GestionComandas()
        {
            lista = new List<Plato>();
        }

        public void AgregarPlato()
        {
            Console.WriteLine("Ingrese el nombre del plato: ");
            string nom = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del plato: ");
            double pre = double.Parse(Console.ReadLine());

            Plato p = new Plato(nom, pre);

            lista.Add(p);
        }

        public void MostrarComanda()
        {
            if(lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Plato p = lista[i];
                    Console.WriteLine($"Nombre del plato: {p.NombrePlato} con el precio de ${p.Precio}");
                    Console.WriteLine($"Cantidad de items pedidos: {lista.Count}");
                }
            }

        }

        public void CalcularTotalMesa()
        {
            double montoTotal = 0;
            foreach(Plato p in lista)
            {
                montoTotal = montoTotal + p.Precio;
            }
            Console.WriteLine($" Monto a pagar: {montoTotal}");
        }

        public void CancelarPlato()
        {
            Console.WriteLine("Ingrese el plato a cancelar: ");
            string platoparaeliminar = Console.ReadLine();

            Plato encontrado = null;

            foreach(Plato p in lista)
                if(p.NombrePlato == platoparaeliminar)
                {
                    encontrado = p;
                }
                else
                {
                    Console.WriteLine("plato no encontrado.");
                }
            lista.Remove(encontrado);
            Console.WriteLine("Comanda Actualizada: ");
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            GestionComandas GC = new GestionComandas();
            GC.AgregarPlato();
            GC.MostrarComanda();
            GC.CalcularTotalMesa();
            GC.CancelarPlato();
            GC.MostrarComanda();
        }
    }
}
