/*
Un estacionamiento medido administra el ingreso y la salida de los vehículos que
utilizan su playa por orden de llegada.
 Crear la clase Ticket que contenga como atributos privados: patente
(string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
constructor que reciba pat y hs.
 Crear la clase GestionEstacionamiento que administre una lista
dinámica de tickets (List).
 Métodos en GestionEstacionamiento:
o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
agregarlo al final de la lista utilizando .Add().
o ProcesarSalida(): Si la lista no está vacía, simular la salida del
primer vehículo de la lista (mostrar sus datos en consola) y
removerlo de la colección mediante .RemoveAt(0). Si está vacía,
advertir que no hay vehículos esperando salida.
o MostrarVehiculosEstacionados(): Listar todos los vehículos
alojados en la playa y la cantidad total de unidades presentes
utilizando la propiedad .Count.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._10
{
    class Ticket
    {
        private string patente;
        private int horaEstadia;

        public string Patente
        {
            get
            {
                return patente;
            }
        }
        public int HoraEstadia
        {
            get
            {
                return horaEstadia;
            }
        }
        public Ticket(string pat, int hs)
        {
            patente = pat;
            horaEstadia = hs;
        }
    }
     class GestionEstacionamiento
    {
        private List<Ticket> tickets;
        public void RegistrarIngreso()
        {
            tickets = new List<Ticket>();

            Console.WriteLine("ingrese el número de patente: ");
            string pat = Console.ReadLine();

            Console.WriteLine("ingrese el horario de estadia: ");
            int hs = int.Parse(Console.ReadLine());

            Ticket t  = new Ticket(pat, hs);

            tickets.Add(t);

        }

        public void ProcesarSalida()
        {
            Ticket PrimerTicket = tickets[0];
            if(tickets.Count > 0)
            {
                Console.WriteLine($"Salida del vehiculo con la patente de {PrimerTicket.Patente} y la hora {PrimerTicket.HoraEstadia}");
                tickets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay vehiculos esperando en la salida");
            }
        }
        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("Listado de Vehiculos estacionados: ");
            foreach(Ticket t in tickets)
            {
                Console.WriteLine($"{t.Patente}");
            }
            Console.WriteLine($"El total de vehiculos estacionados es de {tickets.Count}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            GestionEstacionamiento ge = new GestionEstacionamiento();
            ge.RegistrarIngreso();
            ge.ProcesarSalida();
            ge.MostrarVehiculosEstacionados();
        }
    }
}
