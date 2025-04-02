using System;
using System.Globalization;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            DateTime dtm = DateTime.Now;
            DateTime dtm01 = new DateTime(2018, 11, 25);
            DateTime dtm02 = new DateTime(2018,11, 25, 20, 45,3, 500);
            DateTime dtm03 = DateTime.Today;
            DateTime dtm04 = DateTime.UtcNow;

            DateTime dtm05 = DateTime.Parse("2000-08-15");
            DateTime dtm06 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dtm07 = DateTime.Parse("15/08/2000");
            DateTime dtm08 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime dtm09 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dtm10 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(dtm);
            Console.WriteLine(dtm.ToString());
            Console.WriteLine(dtm.Ticks);
            Console.WriteLine(dtm01.ToString());
            Console.WriteLine(dtm02.ToString());
            Console.WriteLine(dtm03.ToString());
            Console.WriteLine(dtm04.ToString());
            Console.WriteLine(dtm05.ToString());
            Console.WriteLine(dtm06.ToString());
            Console.WriteLine(dtm07.ToString());
            Console.WriteLine(dtm08.ToString());
            Console.WriteLine(dtm09.ToString());
            Console.WriteLine(dtm10.ToString());
        }
    }
}