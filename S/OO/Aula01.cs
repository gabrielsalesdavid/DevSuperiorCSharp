using System;
using System.Formats.Asn1;
using System.Globalization;

namespace DevSuperior {
    public class Aula01 {

          static void Main(string[] args) {

            double xA, xB, xC, yA, yB, yC;
            double p, areaX, areaY;

            // entrada de dados pelo USER
            Console.WriteLine("Entre com as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // entrada de dados pelo USER
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculos para area de x e y
            p = (xA + xB + xC) / 2.0;
            areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));


            // saida de dados para o USER
            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // condições composta para lógica de programação
            if(areaX > areaY) {

                Console.WriteLine("Maior área: Y");
            } else {

                Console.WriteLine("Maior área: Y");
            }
          }
    }
}