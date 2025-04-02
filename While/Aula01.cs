using System;
using System.Globalization;

namespace DevSuperior {

    public class Aula01 {

        public static void Main(String[] args) {

            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(x >= 0) {

                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero: ");

                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero negativo!");
        }
    }
}