using System;
using System.Globalization;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            string day;

            switch(x) {

                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesay";
                    break;
                case 4:
                    day = "Wendnesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);
        }
    }
}