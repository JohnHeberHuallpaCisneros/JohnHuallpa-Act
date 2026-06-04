
/*
3. Geolocalización de Reservas Naturales 
Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de especies protegidas en cuadrículas de territorio.
Confeccionar la clase ReservaNatural que tenga como atributos privados el NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la cantidad de animales avistados en cada sector). El constructor de la clase debe cargar por teclado el nombre y rellenar el mapa de avistamientos.
Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3 objetos de la clase ReservaNatural.
La clase CentroEcologico debe implementar los siguientes métodos:
Un constructor que solicite la carga secuencial de las 3 reservas.
Un método que enliste cada reserva junto a la cantidad total de avistamientos que registró en toda su superficie (la suma de toda su matriz rectangular).
Un método que determine e informe cuál fue la coordenada o sector específico ([fila, columna]) que registró la mayor concentración de avistamientos de toda la red de reservas, indicando a qué reserva pertenece.
*/
using System;

namespace _15._3
{
    class ReservaNatural
    {
        private string NombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            avistamientos = new int[3, 3];

            Console.Write("Ingrese el nombre de la reserva: ");
            NombreReserva = Console.ReadLine();

            Console.WriteLine("Ingrese los avistamientos de cada sector:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Sector [{i},{j}]: ");
                    avistamientos[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string GetNombreReserva()
        {
            return NombreReserva;
        }

        public int[,] GetAvistamientos()
        {
            return avistamientos;
        }
    }

    class CentroEcologico
    {
        private ReservaNatural[] reservas;

        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nCargando reserva {i + 1}");
                reservas[i] = new ReservaNatural();
            }
        }

        public void TotalAvistamientos()
        {
            Console.WriteLine("Total de avistamientos por reserva: ");

            foreach (var reserva in reservas)
            {
                int[,] mapa = reserva.GetAvistamientos();
                int suma = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        suma += mapa[i, j];
                    }
                }

                Console.WriteLine($"{reserva.GetNombreReserva()}: {suma} avistamientos");
            }
        }

        public void MayorConcentracion()
        {
            int mayor = -1;
            string nombreReserva = "";
            int filaMayor = 0;
            int columnaMayor = 0;

            foreach (var reserva in reservas)
            {
                int[,] mapa = reserva.GetAvistamientos();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (mapa[i, j] > mayor)
                        {
                            mayor = mapa[i, j];
                            nombreReserva = reserva.GetNombreReserva();
                            filaMayor = i;
                            columnaMayor = j;
                        }
                    }
                }
            }

            Console.WriteLine("Mayor concentración de avistamientos: ");
            Console.WriteLine($"Reserva: {nombreReserva}");
            Console.WriteLine($"Sector: [{filaMayor},{columnaMayor}]");
            Console.WriteLine($"Cantidad de avistamientos: {mayor}");

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            CentroEcologico c = new CentroEcologico();

            c.TotalAvistamientos();
            c.MayorConcentracion();
        }
    }
}