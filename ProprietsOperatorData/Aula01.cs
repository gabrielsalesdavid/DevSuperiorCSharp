using System;
using System.Globalization;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            DateTime d01 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d02 = d01.AddHours(2);
            DateTime d03 = d01.AddMinutes(3);
            DateTime d04 = new DateTime(2000, 10, 15);
            DateTime d05 = new DateTime(2000, 10, 18);

            TimeSpan t = d05.Subtract(d04);

            string dtm01 = d01.ToLongDateString();
            string dtm02 = d01.ToLongTimeString();
            string dtm03 = d01.ToShortDateString();
            string dtm04 = d01.ToShortTimeString();

            string dtm05 = d01.ToString();
            string dtm06 = d01.ToString("yyyy/MM/dd HH:mm:ss");
            string dtm07 = d01.ToString("yyyy/MM/dd HH:mm:ss.fff");

            Console.WriteLine(d01.ToString());
            Console.WriteLine("1) Date: " + d01.Date);
            Console.WriteLine("2) Day: " + d01.Day);
            Console.WriteLine("3) DayOfWeek: " + d01.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d01.DayOfYear);
            Console.WriteLine("5) Hour: " + d01.Hour);
            Console.WriteLine("6) Kind: " + d01.Kind);
            Console.WriteLine("7) Millisecond: " + d01.Millisecond);
            Console.WriteLine("8) Minute: " + d01.Minute);
            Console.WriteLine("9) Month: " + d01.Month);
            Console.WriteLine("10) Second: " + d01.Second);
            Console.WriteLine("11) Ticks: " + d01.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d01.TimeOfDay);
            Console.WriteLine("13) Year: " + d01.Year);

            Console.WriteLine(dtm01);
            Console.WriteLine(dtm02);
            Console.WriteLine(dtm03);
            Console.WriteLine(dtm04);
            Console.WriteLine(dtm05);
            Console.WriteLine(dtm06);
            Console.WriteLine(dtm07);
            Console.WriteLine(d02);
            Console.WriteLine(d03);

            Console.WriteLine(t);
        }
    }
}