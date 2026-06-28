/*
2.
Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
La clase CriaturaMarina debe tener como atributos privados: Especie (string),
ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
● La profundidad óptima sea estrictamente mayor a cero (0).
● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
nivel de salinidad para sobrevivir.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _18._2
{
    class CriaturaMarina
    {
        private string especie;
        private int profundidadoptima;
        private int nivelsalinidad;

        public string Especie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }

        public int Profundidadoptima
        {
            set
            {
                if(value >= 0)
                {
                    profundidadoptima = value;
                }
                else
                {
                    Console.WriteLine("El valor debe de ser mayor a 0. Se le asignará 1 al valor");
                    profundidadoptima = 0;
                    
                }
            }
            get
            {
                return profundidadoptima;
            }
        }
        public int Nivelsalinidad
        {
            set
            {
                if(value >= 1 || value <= 100)
                {
                    nivelsalinidad = value;
                }
                else
                {
                    Console.WriteLine("El valor debe de ser mayor a 0, se lo pondra directamente en 35.");
                    nivelsalinidad = 35;
                }
            }
            get
            {
                return nivelsalinidad;
            }
        }
    }
    class HabitatAcuatico
    {
        private CriaturaMarina[] criaturas = new CriaturaMarina[3]; 

        public void Carga()
        {
            criaturas[0] = new CriaturaMarina();
            criaturas[1] = new CriaturaMarina();
            criaturas[2] = new CriaturaMarina();
            for (int i = 0; i < criaturas.Length; i++)
            {
                Console.WriteLine("Ingrese la especie: ");
                criaturas[i].Especie = Console.ReadLine();
                Console.WriteLine("Ingresa su profundidad optima: ");
                criaturas[i].Profundidadoptima = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa su nivel de salinidad: ");
                criaturas[i].Nivelsalinidad = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenamientomuestra()
        {
            int mayorsalanidad = criaturas[0].Nivelsalinidad;
            string pezmayorsalinidad = criaturas[0].Especie;
            for(int i = 0; i < criaturas.Length; i++)
            {
                for (int j = 0; j < criaturas.Length - 1; j++)
                {
                    if (criaturas[j].Profundidadoptima > criaturas[j + 1].Profundidadoptima)
                    {
                        CriaturaMarina aux = criaturas[j];
                        criaturas[j] = criaturas[j + 1];
                        criaturas[j + 1] = aux;
                    }
                }
            }

            for(int i = 0; i < criaturas.Length; i++)
            {
                if (criaturas[i].Nivelsalinidad > mayorsalanidad)
                {
                    mayorsalanidad = criaturas[i].Nivelsalinidad;
                    pezmayorsalinidad = criaturas[i].Especie;
                }
            }
            Console.WriteLine($"La especie con mayor nivel de salinidad es: {pezmayorsalinidad}");

            Console.WriteLine("Criaturas ingresadas: ");
            for (int i = 0; i < criaturas.Length; i++)
            {
                Console.WriteLine($"|Nombre: {criaturas[i].Especie}|| Profundidad Optima: {criaturas[i].Profundidadoptima}mts|| Nivel de salinidad: {criaturas[i].Nivelsalinidad}|");
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            HabitatAcuatico ha = new HabitatAcuatico();
            ha.Carga();
            ha.Ordenamientomuestra();
        }
    }
}
