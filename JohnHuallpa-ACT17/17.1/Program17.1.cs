/*
1. Personal de un Gimnasio (Herencia Simple y Propiedades)
Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
método para imprimir estos datos básicos.
Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
para imprimir todos los datos del profesor (incluyendo los heredados).
En el programa principal (Main):
 Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
llamar a su método de impresión.
 Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
que puede acceder tanto a sus métodos propios como a los de la clase base.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._4
{
    class PersonaGimnasio
    {
        private string nombre;
        private string dni;

        public string Nombre
        {
            set
            { 
                nombre = value; 
            }
            get
            { 
                return nombre;
            }
        }

        public string Dni
        {
            set
            { dni = value;
            }
            get
            { 
                return dni;
            }
        }

        public void ImprimirDatosBasicos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("DNI: " + dni);
        }
    }

    class Profesor : PersonaGimnasio
    {
        private string especialidad;

        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }

        public void ImprimirDatosProfesor()
        {
            ImprimirDatosBasicos();
            Console.WriteLine("Especialidad: " + especialidad);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PersonaGimnasio p = new PersonaGimnasio();
            p.Nombre = "Laura Gómez";
            p.Dni = "35.123.456";
            Console.WriteLine("Datos de Persona");
            p.ImprimirDatosBasicos();

            Profesor prof = new Profesor();
            prof.Nombre = "Carlos Ruiz";
            prof.Dni = "28.765.432";
            prof.Especialidad = "Musculación";
            Console.WriteLine("Datos de Profesor");
            prof.ImprimirDatosProfesor();

            Console.ReadKey();
        }
    }
}
