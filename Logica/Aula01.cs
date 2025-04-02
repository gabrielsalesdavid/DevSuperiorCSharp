using System;

namespace DevSuperior {

    public class Aula01 {

        public static void Main(String[] args) {

            bool c01 = 2 > 3 && 4 != 5;
            bool c02 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c01);
            Console.WriteLine(c02);
        }
    }
}