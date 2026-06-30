using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            JuegoArcade juego = new JuegoArcade();
            juego.MostrarInfo();

            Console.WriteLine("Simulando 4 partidas");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Partida " + i + " - Puntaje: ");
                int puntaje = int.Parse(Console.ReadLine());
                juego.CompararPuntaje(puntaje);
            }

            Console.WriteLine("Récord final: " + juego.PuntajeMaximo);
            Console.ReadKey();
        }
    }
}
