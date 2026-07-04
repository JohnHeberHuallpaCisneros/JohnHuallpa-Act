/*
Actividad 3: Registro de entrenamientos
Problema:
Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
● Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
1. Uno que reciba horas y minutos y los convierta a minutos.
2. Otro que reciba directamente los minutos.
● Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
más corto. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._3
{
    class Entrenamiento
    {
        public string Deportista { get; set; }
        public int Duracion { get; set; }

        public Entrenamiento(string deportista)
        {
            this.Deportista = deportista;
        }

        public void RegistrarDuracion(int horas, int minutos)
        {
            Duracion = (horas * 60) + minutos;
        }

        public void RegistrarDuracion(int minutos)
        {
            Duracion = minutos;
        }
    }

    class ProgramaEntrenamiento
    {
        static void Main()
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            Entrenamiento e1 = new Entrenamiento("Lucía");
            e1.RegistrarDuracion(1, 15);

            Entrenamiento e2 = new Entrenamiento("Martín");
            e2.RegistrarDuracion(45);

            Entrenamiento e3 = new Entrenamiento("Sofía");
            e3.RegistrarDuracion(2, 0);

            Entrenamiento e4 = new Entrenamiento("Diego");
            e4.RegistrarDuracion(30);

            Entrenamiento e5 = new Entrenamiento("Valentina");
            e5.RegistrarDuracion(0, 50);

            entrenamientos.Add(e1);
            entrenamientos.Add(e2);
            entrenamientos.Add(e3);
            entrenamientos.Add(e4);
            entrenamientos.Add(e5);

            Console.WriteLine("=== Entrenamientos registrados ===");
            foreach (Entrenamiento e in entrenamientos)
            {
                Console.WriteLine($"{e.Deportista}: {e.Duracion} min");
            }

            Entrenamiento Largo = entrenamientos[0];
            Entrenamiento Corto = entrenamientos[0];

            foreach (Entrenamiento e in entrenamientos)
            {
                if (e.Duracion > Largo.Duracion)
                    Largo = e;

                if (e.Duracion < Corto.Duracion)
                    Corto = e;
            }

            Console.WriteLine($"Entrenamiento más largo: {Largo.Deportista} ({Largo.Duracion} min)");
            Console.WriteLine($"Entrenamiento más corto: {Corto.Deportista} ({Corto.Duracion} min)");
        }

    }
}
