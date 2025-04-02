using System;
using System.Globalization;

namespace DevSuperior {
    class Auala01 {
        static void Main(string[] args) {

            int s01 = Calculator.Sum(2, 3 );
            int s02 = Calculator.Sum(2, 4, 3 );

            Console.WriteLine(s01);
            Console.WriteLine(s02);
        }
    }
}