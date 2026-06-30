using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._3
{
    partial class JuegoArcade
    {
        private string nombreJuego;
        private int puntajeMaximo;
        private int nivelDificultad;

        public string NombreJuego
        {
            get { return nombreJuego; }
            set { nombreJuego = value; }
        }

        public int PuntajeMaximo
        {
            get { return puntajeMaximo; }
            set { puntajeMaximo = value; }
        }

        public int NivelDificultad
        {
            get { return nivelDificultad; }
            set
            {
                if (value >= 1 && value <= 5)
                    nivelDificultad = value;
                else
                {
                    Console.WriteLine("Nivel inválido. Se asigna 1.");
                    nivelDificultad = 1;
                }
            }
        }

        public JuegoArcade()
        {
            Console.Write("Nombre del juego: ");
            NombreJuego = Console.ReadLine();

            Console.Write("Puntaje máximo actual: ");
            PuntajeMaximo = int.Parse(Console.ReadLine());

            Console.Write("Nivel de dificultad (1-5): ");
            NivelDificultad = int.Parse(Console.ReadLine());
        }
    }
}
