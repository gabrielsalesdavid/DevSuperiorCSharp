using System;

namespace DevSuperior {

    public class Aula01 {

        public static void Main(String[] args) {

            int a = 10;
            bool c01 = a < 10;
            bool c02 = a > 20;
            bool c03 = a > 5;
            bool c04 = a > 10;

            Console.WriteLine(c01);
            Console.WriteLine(c02);
            Console.WriteLine(c03);
            Console.WriteLine(c04);

            bool c05 = a >= 10;
            bool c06 = a <= 20;
            bool c07 = a == 10;
            bool c08 = a != 10;

            Console.WriteLine(c05);
            Console.WriteLine(c06);
            Console.WriteLine(c07);
            Console.WriteLine(c08);
        }
    }
}