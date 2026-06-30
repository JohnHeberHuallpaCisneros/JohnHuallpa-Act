/*
1. Plantear una clase parcial ReservaHotel.
En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
noches sea mayor a 0. Estos valores son cargados desde la consola.
En el segundo archivo, agregar un método que calcule el total a pagar según la
habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
noche).
Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1
{
    partial class ReservaHotel
    {
        private string NombreCliente;
        private int CantidadNoches;
        private string TipoHabitacion;
        
        public string Nombre
        {
            set
            {
                NombreCliente = value;
            }
            get
            {
                return NombreCliente;
            }
        }
        public int Noches
        {
            set
            {
               if(value > 0)
                {
                    CantidadNoches = value;
                }
                else
                {
                    Console.WriteLine("La cantidad de noches debe ser un número positivo, se le asignara el valor 1");
                    CantidadNoches = 1;
                }
            }
            get
            {
                return CantidadNoches;
            }
        }
        public string Tipo
        {
            set
            {
                if (value == "SIMPLE" || value == "DOBLE" || value == "SUITE")
                {
                    TipoHabitacion = value;
                }
                else
                {
                    Console.WriteLine("El tipo de habitación ingresado no es válido, se le asignara el valor 'SIMPLE'");
                    TipoHabitacion = "SIMPLE";
                }
            }
            get
            {
                return TipoHabitacion;
            }
        }
        public ReservaHotel()
        {
            Console.WriteLine(" Ingrese el nombre del cliente: ");
            Nombre = Console.ReadLine();
            Console.WriteLine(" La cantidad de noches: ");
            Noches = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el tipo de habitación: ");
            Tipo = Console.ReadLine();
        }
    }
}
