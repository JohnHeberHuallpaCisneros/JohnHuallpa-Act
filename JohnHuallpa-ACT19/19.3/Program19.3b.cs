using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._3
{
    partial class JuegoArcade
    {
        public void CompararPuntaje(int puntajeIngresado)
        {
            if (puntajeIngresado > PuntajeMaximo)
            {
                Console.WriteLine("Record roto");
                PuntajeMaximo = puntajeIngresado;
            }
            else
            {
                Console.WriteLine("No supera el récord.");
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Juego: " + NombreJuego);
            Console.WriteLine("Récord: " + PuntajeMaximo);
            Console.WriteLine("Dificultad: " + NivelDificultad);
        }
    }
}
