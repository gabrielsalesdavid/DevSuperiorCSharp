using System;
using System.Globalization;

namespace DevSuperior {
    class Aula01 {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10.0;

            double? z = null;
            double? w = 10;
            double a = z ?? 5;
            double b = w ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {

                Console.WriteLine(x.Value);
            } else {

                Console.WriteLine("X is Null");
            }

            if (y.HasValue) {

                Console.WriteLine(y.Value);
            } else {

                Console.WriteLine("Y is Null");
            }

            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);
        }
    }
}