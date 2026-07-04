/*
Actividad 2: Posicionamiento de elementos en consola
Problema:
Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
● Implementar propiedades y un constructor que cargue valores.
● Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
nombre en pantalla y Console.CursorVisible para ocultar el cursor.
● Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
consola.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _22._2
{
    class ElementoPantalla
    {
        public string Nombre { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public ElementoPantalla(string nombre, int posX, int posY)
        {
            this.Nombre = nombre;
            this.PosX = posX;
            this.PosY = posY;
        }

        public void Mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Nombre);
        }
    }

    class ProgramaPantalla
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ElementoPantalla[] elementos = new ElementoPantalla[4];
            elementos[0] = new ElementoPantalla("Botón Inicio", 5, 2);
            elementos[1] = new ElementoPantalla("Botón Opciones", 5, 4);
            elementos[2] = new ElementoPantalla("Botón Salir", 5, 6);
            elementos[3] = new ElementoPantalla("Marca de agua", 40, 10);

            foreach (ElementoPantalla i in elementos)
            {
                i.Mostrar();
            }

            Console.SetCursorPosition(0, 13);
            Console.CursorVisible = false;
        }
    }
}
