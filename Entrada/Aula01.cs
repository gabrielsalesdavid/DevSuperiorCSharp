using System;

namespace DevSuperior {

    public class Aula01 {

        public static void Main(String[] args) {

            String frase, x, y, z, a, b, c, s;
            String[] vet;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            s = Console.ReadLine();

            vet = s.Split(' ');

            a = vet[0];
            b = vet[1];
            c = vet[2];

            Console.WriteLine();

            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine();
        }
    }
}