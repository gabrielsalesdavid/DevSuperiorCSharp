using System;

namespace DevSuperior {

    public class Aula01 {

        public static void Main(string[] args) {

            int n01 = 3 + 4 * 2;
            int n02 = (3 + 4) * 2;
            int n03 = 17 % 3;
            double n04 = 10 / 8D;

            double a, b, c, delta, delta01, x;
            a = 1.0;
            b = -3.0;
            c = -4.0;

            delta = b * b - 4.0 * a * c;
            delta01 = Math.Pow(b, 2.0) - 4.0 * a * c;

            x = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n01);
            Console.WriteLine(n02);
            Console.WriteLine(n03);
            Console.WriteLine(n04);
            Console.WriteLine(delta);
            Console.WriteLine(delta01);
            Console.WriteLine(x);
        }
    }
}