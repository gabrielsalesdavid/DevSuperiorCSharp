using System;
using System.Globalization;

namespace DevSuperior {

    class Auala01 {

        static void Main(string[] args) {

            DateTime d01 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d02 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d03 = new DateTime(2000, 8, 15, 13, 5, 58);

            DateTime d04 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d05 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d01: " + d01);
            Console.WriteLine("d01 Kind: " + d01.Kind);
            Console.WriteLine("d01: " + d01.ToLocalTime());
            Console.WriteLine("d01: " + d01.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d02: " + d02);
            Console.WriteLine("d02 Kind: " + d02.Kind);
            Console.WriteLine("d02: " + d02.ToLocalTime());
            Console.WriteLine("d02: " + d02.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d03: " + d03);
            Console.WriteLine("d03 Kind: " + d03.Kind);
            Console.WriteLine("d03: " + d03.ToLocalTime());
            Console.WriteLine("d03: " + d03.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d04);
            Console.WriteLine(d05);
            Console.WriteLine();
            Console.WriteLine("d04: " + d04);
            Console.WriteLine("d04 Kind: " + d04.Kind);
            Console.WriteLine("d04: " + d04.ToLocalTime());
            Console.WriteLine("d04: " + d04.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d05: " + d05);
            Console.WriteLine("d05 Kind: " + d05.Kind);
            Console.WriteLine("d05: " + d05.ToLocalTime());
            Console.WriteLine("d05: " + d05.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d05.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d05.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}