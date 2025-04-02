using System;
using System.Globalization;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            TimeSpan t01 = new TimeSpan(1, 30, 10);
            TimeSpan t02 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t01.Add(t02);
            TimeSpan dif = t01.Subtract(t02);
            TimeSpan mult = t02.Multiply(2.0);
            TimeSpan div = t02.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}