/*
Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
imprimir estos datos básicos.
Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
En el programa principal (Main):
● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
muestra de información.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _18._1
{
    class DispositivoEnergia
    {
        private string codigoidentificador;
        private double generacionkwh;

        public string CodigoIdentificador
        {
            set
            {
                codigoidentificador = value;
            }
            get
            {
                return codigoidentificador;
            }
        }
        public double Generacionkwh
        {
            set
            {
                if(value >= 0)
                {
                    generacionkwh = value;
                }
                else
                {
                    generacionkwh = 0;
                }
            }
            get
            {
                return generacionkwh;
            }
        }
        public void Impresion()
        {
            Console.WriteLine("Dispositivos de energia: ");
            Console.WriteLine($"|ID: {codigoidentificador}| |Generacion: {generacionkwh}kwh|");

        }
    }
    class PanelSolar : DispositivoEnergia
    {
        private double areametros;

        public double Areametros
        {
            set
            {
                    if (value > 0)
                    {
                        areametros = value;
                    }
                    else
                    {
                        areametros = 0;
                    }
            }
            get
            {
                return areametros;
            }
        }
        public void ImpresionPanel()
        {
            base.Impresion();
            Console.WriteLine($"Área: {areametros} m2");
        }
        static void Main(string[] args)
        {
            Console.WriteLine();

            DispositivoEnergia d = new DispositivoEnergia();
            Console.WriteLine("Ingrese el ID del dispositivo: ");
            d.CodigoIdentificador = Console.ReadLine();
            Console.WriteLine("Ingrese la GeneracionKwh: ");
            d.Generacionkwh = double.Parse(Console.ReadLine());
            d.Impresion();

            PanelSolar s = new PanelSolar();
            Console.WriteLine("Ingrese el ID del panel solar: ");
            s.CodigoIdentificador = Console.ReadLine();
            Console.WriteLine("Ingrese la GeneracionKwh: ");
            s.Generacionkwh = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su area en metros cuadrados: ");
            s.Areametros = double.Parse(Console.ReadLine());
            s.ImpresionPanel();
            Console.ReadKey();

        }
    }
}
