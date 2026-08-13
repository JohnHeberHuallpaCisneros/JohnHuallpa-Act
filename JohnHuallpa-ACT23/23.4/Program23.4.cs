/*
Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
vinculados a una red hogareña.
 Crear la clase DispositivoInteligente que contenga como atributos
privados: nombreDispositivo (string) y consumoWatts (double). Definir
sus propiedades y un constructor que reciba nom y watts.
 Crear la clase colaboradora PanelDomotico que administre un objeto
List&lt;DispositivoInteligente&gt;.
 Métodos en PanelDomotico:
1. Un constructor que permita al usuario cargar dinámicamente
dispositivos por teclado. El sistema preguntará después de cada
carga si se desea agregar otro dispositivo.
2. MostrarDispositivos(): Listar todos los dispositivos
configurados junto a sus consumos.
3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
Watts totales que consume la casa sumando los valores de la lista.
4. DesconectarDispositivo(): Solicitar al usuario el nombre de
un dispositivo y, si existe en la lista, removerlo de forma dinámica
para simular su apagado remoto.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._4
{
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo 
        {
            get 
            { 
                return nombreDispositivo;
            } 
            set { 
                nombreDispositivo = value; 
            }
        }
        public double ConsumoWatts 
        { get 
            {
                return consumoWatts;
            } 
            set
            { consumoWatts = value;
            }
        }

        public DispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }
    }

    class PanelDomotico
    {
        private List<DispositivoInteligente> dispositivos;

        public PanelDomotico()
        {
            dispositivos = new List<DispositivoInteligente>();
            string continuar;
            do
            {
                Console.Write("Nombre del dispositivo: ");
                string nom = Console.ReadLine();
                Console.Write("Consumo en watts: ");
                double watts = double.Parse(Console.ReadLine());
                dispositivos.Add(new DispositivoInteligente(nom, watts));

                Console.Write("¿Agregar otro dispositivo? (S/N): ");
                continuar = Console.ReadLine();
            } while (continuar.ToUpper() == "S");
        }

        public void MostrarDispositivos()
        {
            foreach (DispositivoInteligente d in dispositivos)
            {
                Console.WriteLine(d.NombreDispositivo + " - " + d.ConsumoWatts + "W");
            }
        }

        public void CalcularConsumoTotal()
        {
            double total = 0;
            foreach (DispositivoInteligente d in dispositivos)
            {
                total += d.ConsumoWatts;
            }
            Console.WriteLine("Consumo total: " + total + "W");
        }

        public void DesconectarDispositivo()
        {
            Console.Write("Nombre del dispositivo a desconectar: ");
            string nom = Console.ReadLine();
            DispositivoInteligente encontrado = null;

            foreach (DispositivoInteligente d in dispositivos)
            {
                if (d.NombreDispositivo == nom)
                {
                    encontrado = d;
                }
            }

            if (encontrado != null)
            {
                dispositivos.Remove(encontrado);
                Console.WriteLine("Dispositivo desconectado.");
            }
            else
            {
                Console.WriteLine("No se encontró el dispositivo.");
            }
        }
        static void Main(string[] args)
        {
            PanelDomotico p = new PanelDomotico();
            p.MostrarDispositivos();
            p.CalcularConsumoTotal();
            p.DesconectarDispositivo();
            p.MostrarDispositivos();
        }
    }
}