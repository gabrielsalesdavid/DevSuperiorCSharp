using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DevSuperior {
    class Aula01 {

        static double Pi = 3.14;

        static void Main(string[] args) {

            double raio, circ, volume;

            Console.Write("Entre o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            circ = Circunferencia(raio);
            volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double raio) {

            return 2.0 * Pi * raio;
        }

        static double Volume(double raio) {

            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}