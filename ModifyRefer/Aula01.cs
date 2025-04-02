using System;
using System.Globalization;

namespace DevSuperior {
    class Auala01 {
        static void Main(string[] args) {

            int a = 10;

            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 20;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}