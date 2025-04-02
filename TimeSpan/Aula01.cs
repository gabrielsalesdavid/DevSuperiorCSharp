using System;
using System.Globalization;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            TimeSpan t01 = new TimeSpan();
            TimeSpan t02 = new TimeSpan(900000000L);
            TimeSpan t03 = new TimeSpan(2, 11, 21);
            TimeSpan t04 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t05 = new TimeSpan(1, 2, 11, 21, 321);

            TimeSpan t06 = TimeSpan.FromDays(1.5);
            TimeSpan t07 = TimeSpan.FromHours(1.5);
            TimeSpan t08 = TimeSpan.FromMinutes(1.5);
            TimeSpan t09 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t01);
            Console.WriteLine(t02);
            Console.WriteLine(t03);
            Console.WriteLine(t04);
            Console.WriteLine(t05);
            Console.WriteLine(t06);
            Console.WriteLine(t07);
            Console.WriteLine(t08);
            Console.WriteLine(t09);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
        }
    }
}