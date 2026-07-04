/*
Problema:
Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
● Usar la palabra clave this en el constructor para diferenciar los parámetros de
los atributos.
● Crear un método para calcular la duración del vuelo (TimeSpan).
● Cargar un vector con 4 vuelos y mostrar:
1. El código y duración del vuelo más largo.
2. El código del vuelo que salga más temprano.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._4
{
     class Vuelo
    {
        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public string Codigo => codigo;
        public DateTime HoraSalida => horaSalida;

        public TimeSpan CalcularDuracion()
        {
            return horaLlegada - horaSalida;
        }
    }

    class ProgramaVuelos
    {
        static void Main()
        {
            Vuelo[] vuelos = new Vuelo[4];

            vuelos[0] = new Vuelo("1225", new DateTime(2026, 7, 3, 6, 30, 0), new DateTime(2026, 7, 3, 9, 10, 0));
            vuelos[1] = new Vuelo("0605", new DateTime(2026, 7, 3, 14, 0, 0), new DateTime(2026, 7, 3, 15, 20, 0));
            vuelos[2] = new Vuelo("2202", new DateTime(2026, 7, 3, 5, 15, 0), new DateTime(2026, 7, 3, 11, 45, 0));
            vuelos[3] = new Vuelo("0401", new DateTime(2026, 7, 3, 22, 0, 0), new DateTime(2026, 7, 4, 8, 30, 0));

            Console.WriteLine("Vuelos cargados");
            foreach (Vuelo v in vuelos)
            {
                Console.WriteLine($"{v.Codigo} | Salida: {v.HoraSalida:HH:mm} | Duración: {v.CalcularDuracion()}");
            }

            Vuelo MasLargo = vuelos[0];
            foreach (Vuelo v in vuelos)
            {
                if (v.CalcularDuracion() > MasLargo.CalcularDuracion())
                {
                    MasLargo = v;
                }
            }

            Vuelo MasTemprano = vuelos[0];
            foreach (Vuelo v in vuelos)
            {
                if (v.HoraSalida < MasTemprano.HoraSalida)
                {
                    MasTemprano = v;
                }
            }

            Console.WriteLine("Resultados");
            Console.WriteLine($"Vuelo más largo: {MasLargo.Codigo} - Duración: {MasLargo.CalcularDuracion()}");
            Console.WriteLine($"Vuelo que sale más temprano: {MasTemprano.Codigo} (Sale a las {MasTemprano.HoraSalida:HH:mm})");
        }
    }
}
