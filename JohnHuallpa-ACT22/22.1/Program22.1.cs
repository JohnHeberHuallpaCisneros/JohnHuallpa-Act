/*
Actividad 1: Control de horarios en un gimnasio
Problema:
Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
DateTime).
 Implementar un constructor que permita cargar los datos desde consola y otro
que cargue valores por defecto (sobrecarga de constructores).
 Incluir un método para calcular la duración de la clase usando TimeSpan.
 Crear un vector de 3 clases de gimnasio y mostrar:
1. La clase que tenga la mayor duración.
2. El nombre y el horario de inicio de la clase más temprana.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _22._1
{
    class ClaseGimnasio
    {
        private string nombreclase;
        private DateTime horaInicio;
        private DateTime horaFin;
        public ClaseGimnasio()
        {
            Console.WriteLine("Ingrese el nombre de la clase:");
            nombreclase = Console.ReadLine();

            Console.WriteLine("Ingrese el horario de inicio (HH:mm):");
            horaInicio = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el horario de fin (HH:MM):");
            horaFin = DateTime.Parse(Console.ReadLine());
        }
        public ClaseGimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {
            this.nombreclase = nombreClase;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }
        public string NombreClase => nombreclase;
        public DateTime Inicio => horaInicio;
        public TimeSpan Duracion()
        {
            return horaFin - horaInicio;

        }

        public void Mostrar()
        {
            Console.WriteLine($"| Nombre de la clase: {nombreclase} || Hora de Inicio: {horaInicio: HH:mm} | Hora de Fin: {horaFin: HH:mm} || Duración: {Duracion().TotalMinutes} min");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];
            clases[0] = new ClaseGimnasio("Brazos", new DateTime(2026, 12, 10, 6, 6, 6), new DateTime(2026, 12, 14, 12, 25, 0));
            clases[1] = new ClaseGimnasio("Cardio", new DateTime(2028, 12, 11, 6, 6, 6), new DateTime(2028, 12, 15, 12, 25, 0));
            clases[2] = new ClaseGimnasio("Piernas", new DateTime(2027, 12, 12, 6, 6, 6), new DateTime(2027, 12, 16, 12, 25, 0));

            Console.WriteLine("Listado de clases: ");

            foreach(ClaseGimnasio i in clases)
            {
                i.Mostrar();
            }

            ClaseGimnasio claselarga = clases[0];
            foreach (ClaseGimnasio i in clases)
            {
                if (i.Duracion() > claselarga.Duracion())
                {
                    claselarga = i;
                }
            }
            ClaseGimnasio temprano = clases[0];
            foreach (ClaseGimnasio i in clases)
            {
                if(i.Inicio < temprano.Inicio)
                {
                    temprano = i;
                }
            }
            Console.WriteLine("Información: ");
            Console.WriteLine($"Clase con mayor duracion: {claselarga.NombreClase} con la duración de {claselarga.Duracion().TotalMinutes}");
            Console.WriteLine($"Clase más temprana: {temprano.NombreClase} iniciando a las {temprano.Inicio:HH:mm}");
            Console.ReadKey();

        }
    }
    
}
