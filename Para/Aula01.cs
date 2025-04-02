using System;

namespace DevSuperior {

    public class Aula01 {

        public static void Main(String[] args) {

            Console.WriteLine("Quantos números inteiros você digitará? ");
            int quantity = int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i = 1; i <= quantity; i++) {

                Console.WriteLine("Valor #{0}: ", i);
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
        }
    }
}