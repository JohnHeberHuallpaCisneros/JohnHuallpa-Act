/*
Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
drones de entrega en vuelo de regreso a la base.
 Crear la clase Dron que contenga los atributos privados: codigo (string) y
nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
Su constructor debe recibir cod y bat.
 Crear la clase CentroControl que administre una lista de objetos
List&lt;Dron&gt;.
 Métodos en CentroControl:

1. Un constructor que cargue por teclado una lista inicial de 4 drones
ingresando sus códigos y baterías.
2. ListarFlota(): Mostrar la lista de drones en pantalla.
3. RemoverDronesBajos(): Recorrer la lista y remover por
completo de la flota a todos aquellos drones cuyo nivel de batería
sea menor o igual al 15% (ya que requieren mantenimiento
automático urgente).
4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
cantidad de drones operativos utilizando la propiedad .Count.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._2
{
    class Dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo 
        { 
            get 
            { 
                return codigo;
            } 
            set
            { 
                codigo = value;
            } 
        }
        public int NivelBateria 
        { 
            get 
            { 
                return nivelBateria; 
            } 
            set 
            { 
                nivelBateria = value; 
            }
        }

        public Dron(string cod, int bat)
        {
            codigo = cod;
            nivelBateria = bat;
        }
    }

    class CentroControl
    {
        private List<Dron> drones;

        public CentroControl()
        {
            drones = new List<Dron>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Código del dron: ");
                string cod = Console.ReadLine();
                Console.Write("Nivel de batería: ");
                int bat = int.Parse(Console.ReadLine());
                drones.Add(new Dron(cod, bat));
            }
        }

        public void ListarFlota()
        {
            foreach (Dron d in drones)
            {
                Console.WriteLine(d.Codigo + " - Batería: " + d.NivelBateria + "%");
            }
        }

        public void RemoverDronesBajos()
        {
            drones.RemoveAll(d => d.NivelBateria <= 15);
        }

        public void MostrarDronesRestantes()
        {
            ListarFlota();
            Console.WriteLine("Drones operativos: " + drones.Count);
        }
        static void Main(string[] args)
        {
            CentroControl c = new CentroControl();
            c.ListarFlota();
            c.RemoverDronesBajos();
            c.MostrarDronesRestantes();
        }
    }
}
