using System;
using System.Globalization;

namespace DevSuperior {

    public class Auala01 {

        public static void Main(String[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine();

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine();

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine();

            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}