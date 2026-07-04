/*
Actividad 5: Gestión de Carreras Deportivas
Consigna:
Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
Se pide:
1. Crear una clase Carrera con:
o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
definidos.
o Dos constructores (uno por defecto y otro con parámetros).
o Método para calcular la duración de la carrera usando TimeSpan.
2. Crear una clase Corredor con:
o Atributos: nombre, número de dorsal y tiempo total.
o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
horas y minutos).

3. Mostrar en consola (usando Console.SetCursorPosition()):
o La carrera con mayor duración.
o El corredor más rápido.
4. Utilizar this en los constructores o métodos donde corresponda.
5. Deben ser 4 carreras.
*/
using System;
using System.Collections.Generic;

namespace _22._5
{
    class Corredor
    {
        public string Nombre { get; set; }
        public int Dorsal { get; set; }
        public int TiempoTotal { get; set; }
        public Corredor(string nombre, int dorsal)
        {
            this.Nombre = nombre;
            this.Dorsal = dorsal;
        }

        public void RegistrarTiempo(int minutos)
        {
            this.TiempoTotal = minutos;
        }

        public void RegistrarTiempo(int horas, int minutos)
        {
            this.TiempoTotal = (horas * 60) + minutos;
        }
    }

    class Carrera
    {
        private string codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<Corredor> corredores;

        public Carrera()
        {
            this.codigo = "null";
            this.horaInicio = DateTime.Today;
            this.horaFin = DateTime.Today;
            this.corredores = new List<Corredor>();
        }

        public Carrera(string codigo, DateTime horaInicio, DateTime horaFin, List<Corredor> corredores)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.corredores = corredores;
        }

        public string Codigo => codigo;
        public List<Corredor> Corredores => corredores;

        public TimeSpan CalcularDuracion()
        {
            return horaFin - horaInicio;
        }
    }

    class ProgramaCarreras
    {
        static void Main()
        {
            Console.Clear();

            Corredor c1 = new Corredor("Tapia", 10);
            c1.RegistrarTiempo(28);

            Corredor c2 = new Corredor("Gaviota", 11);
            c2.RegistrarTiempo(0, 25);

            List<Corredor> corredoresCarrera1 = new List<Corredor> { c1, c2 };

            Corredor c3 = new Corredor("Zavala", 20);
            c3.RegistrarTiempo(1, 5);

            Corredor c4 = new Corredor("Rangel", 21);
            c4.RegistrarTiempo(58);

            List<Corredor> corredoresCarrera2 = new List<Corredor> { c3, c4 };

            Carrera carrera1 = new Carrera(
                "5K Festival",
                new DateTime(2026, 7, 3, 8, 0, 0),
                new DateTime(2026, 7, 3, 8, 40, 0),
                corredoresCarrera1
            );

            Carrera carrera2 = new Carrera(
                "10K La costa",
                new DateTime(2026, 7, 3, 9, 0, 0),
                new DateTime(2026, 7, 3, 10, 15, 0),
                corredoresCarrera2
            );

            Carrera Vacio = new Carrera();

            Carrera[] carreras = new Carrera[] { carrera1, carrera2 };

            Carrera MasLarga = carreras[0];
            foreach (Carrera c in carreras)
            {
                if (c.CalcularDuracion() > MasLarga.CalcularDuracion())
                {
                    MasLarga = c;
                }
            }

            Corredor MasRapido = carreras[0].Corredores[0];
            foreach (Carrera c in carreras)
            {
                foreach (Corredor cor in c.Corredores)
                {
                    if (cor.TiempoTotal < MasRapido.TiempoTotal)
                    {
                        MasRapido = cor;
                    }
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(2, 2);

            Console.WriteLine($"Carrera con mayor duración: {MasLarga.Codigo} ({MasLarga.CalcularDuracion().TotalMinutes} min)");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine($"Corredor más rápido: {MasRapido.Nombre} (Dorsal {MasRapido.Dorsal}) - {MasRapido.TiempoTotal} min");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine($"(Carrera por defecto de ejemplo: código \"{Vacio.Codigo}\")");
            Console.SetCursorPosition(0, 8);
            Console.CursorVisible = false;
        }
    }
}
