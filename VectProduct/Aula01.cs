using System;
using System.Globalization;

namespace DevSuperior {
    class Aula01 {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Product[] prod = new Product[n];

            for (int i = 0; i < n; i++) {

                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                prod[i] = new Product{Name = name, Price = price};
            }

            double sum = 0.0;

            for(int i = 0; i < n; i++) {

                sum += prod[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("Preço medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}