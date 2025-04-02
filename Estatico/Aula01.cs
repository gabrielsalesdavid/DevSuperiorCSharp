using System;
using System.Globalization;
using Estatico;

namespace DecSuperior {

    class Aula01 {

        static void Main(string[] args) {

            double raio, circ, volume;

            Console.Write("Entre o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            circ = Calculadora.Circunferencia(raio);
            volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}