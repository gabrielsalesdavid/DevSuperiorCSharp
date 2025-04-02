using System;
using System.Globalization;

namespace DevSuperior {
    class Aula01 {

        static void Main(string[] args) {

            double p, areaX, areaY;

            Delegacao x, y;

            x = new Delegacao();
            y = new Delegacao();

            Console.WriteLine("Entre com as medias do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medias do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();
            areaY = y.Area();

            // saida de dados para o USER
            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // condições composta para lógica de programação
            if (areaX > areaY) {

                Console.WriteLine("Maior área: Y");
            } else {

                Console.WriteLine("Maior área: Y");
            }
        }
    }
}