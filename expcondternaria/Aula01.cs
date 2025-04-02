using System;
using System.Globalization;

namespace DevSuperior {

    class Auala01 {

        static void Main(string[] args) {

            //double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double discount = (price < 20.0) ? price * 0.1 : price * 0.05;

            //Console.WriteLine(discount);

            string name = Console.ReadLine();

            string report = (name.Equals(name) != name.Equals("Gabriel")) ? "Invalid" : "É você mesmo";

            Console.WriteLine(report);
        }
    }
}