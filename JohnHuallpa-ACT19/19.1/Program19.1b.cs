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
        public int CalcularTotal()
        {
            int precioPorNoche = 0;

            if (Tipo == "SIMPLE")
            {
                precioPorNoche = 5000;
            }
            else if (Tipo == "DOBLE")
            {
                precioPorNoche = 8000;
            }
            else if (Tipo == "SUITE")
            {
                precioPorNoche = 12000;
            }

            return precioPorNoche * Noches;
        }
        public void MostrarReserva()
        {
            Console.WriteLine("Cliente: " + NombreCliente);
            Console.WriteLine("Noches: " + CantidadNoches);
            Console.WriteLine("Tipo de habitación: " + TipoHabitacion);
            Console.WriteLine($"Total a pagar: ${CalcularTotal()}");
        }
    }
}
