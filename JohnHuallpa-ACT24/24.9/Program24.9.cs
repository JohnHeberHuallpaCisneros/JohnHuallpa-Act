/*
Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
realizar el seguimiento académico de sus materias.
 Crear la clase Estudiante que contenga como atributos privados:
nombreCompleto (string) y calificacion (double). Definir sus propiedades
de solo lectura y un constructor que reciba nom y cal.
 Crear la clase GestionAcademica que administre una lista de objetos
List.
 Métodos en GestionAcademica:
o CargarEstudiantes(): Solicitar por teclado nombres y
calificaciones para agregar estudiantes a la lista mediante .Add(). La
carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
nombre.
o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
junto a la cantidad total de inscriptos mediante la propiedad .Count.
o FiltrarAprobados(): Recorrer la lista e imprimir en consola
únicamente aquellos estudiantes cuya calificación sea mayor o igual
a 6.0.
o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
utilizando los métodos de búsqueda y remoción de listas, eliminarlo
de la colección si se encuentra presente.
*/
using System;
using System.Collections.Generic;

namespace _24._9
{
    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;

        public string NombreCompleto
        {
            set
            {
                nombreCompleto = value;
            }
            get
            {
                return nombreCompleto;
            }
        }
        public double Calificacion
        {
            set
            {
                calificacion = value;
            }
            get
            {
                return calificacion;
            }
        }
        public Estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
    }
    class GestionAcademica
    {
        List<Estudiante> estudiantes;

        public void CargarEstudiante()
        {
            estudiantes = new List<Estudiante>(); 
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                 string nom = Console.ReadLine();
                if(nom == "FIN")
                {
                    break;
                }
                Console.WriteLine("Ingrese su calificación: ");
                 double cal = double.Parse(Console.ReadLine());

                Estudiante e = new Estudiante(nom, cal);
                estudiantes.Add(e);
            }
        }
        public void ListarEstudiantes()
        {
            Console.WriteLine("Lista de estudiantes inscritos: ");
            if(estudiantes.Count > 0)
            {
                foreach(Estudiante e in estudiantes)
                {
                    Console.WriteLine($"{e.NombreCompleto}");
                }
                Console.WriteLine($"el total de inscritos son: {estudiantes.Count}");
            }
            else
            {
                Console.WriteLine("no hay estudiantes.");
            }
        }
        public void FiltrarAprobados()
        {
            Console.WriteLine("Listado de alumnos aprobados: ");
            foreach(Estudiante e in estudiantes)
            {
                if(e.Calificacion >= 6.0)
                {
                    Console.WriteLine($"{e.NombreCompleto}");
                }
            }
        }
        public void DarDeBaja()
        {
            Console.WriteLine("Ingrese el estudiante a dar de baja: ");
            string aBajar = Console.ReadLine();
            Estudiante bajado = estudiantes.Find(e => e.NombreCompleto == aBajar);
            if(bajado != null)
            {
                estudiantes.Remove(bajado);
                Console.WriteLine("Estudiante dado de baja");
            }
            else
            {
                Console.WriteLine("No se encontro al estudiante.");
            }
        }
        static void Main(string[] args)
        {
            GestionAcademica ga = new GestionAcademica();
            ga.CargarEstudiante();
            ga.ListarEstudiantes();
            ga.FiltrarAprobados();
            ga.DarDeBaja();
            Console.WriteLine("Lista actualizada");
            ga.ListarEstudiantes();
            Console.ReadKey();
        }
    }
}
