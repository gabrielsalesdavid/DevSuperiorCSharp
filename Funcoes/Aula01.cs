using System;

namespace DevSuperior {

    public class Aula01 {

        public static void Main(String[] args) {

            int n01, n02, n03;

            Console.WriteLine("Digite três números:");

            n01 = int.Parse(Console.ReadLine());
            n02 = int.Parse(Console.ReadLine());
            n03 = int.Parse(Console.ReadLine());

            double resultado = Maior(n01, n02, n03);

            if(n01 > n02 && n01 > n03) {

                Console.WriteLine("Maior = " + n01);
            } else if(n02 > n03) {

                Console.WriteLine("Maior = " + n02);
            } else {

                Console.WriteLine("Maior = " + n03);
            }

            Console.WriteLine("Função maior = " + resultado);
        }

        public static int Maior(int a, int b, int c) {

            if(a > b && a > c) {
                return a;
            } else if(b > c) {
                return b;
            } else {
                return c;
            }
        }
    }
}