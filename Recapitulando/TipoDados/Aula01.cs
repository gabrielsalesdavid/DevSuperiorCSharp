using System;

namespace DevSuperior {
    public class Aula01 {
        public static void Main(String[] args) {

            SByte x = 100;
            byte n01 = 126;
            int n02 = 1000;
            int n03 = 2147483647;
            long n04 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letar = '\u0041';
            float n05 = 4.5f;
            double n06 = 4.5;
            String nome = "Maria Green";
            Object obj01 = "Alex Brown";
            Object obj02 = 4.5f;

            Console.WriteLine(x);
            Console.WriteLine(n01);
            Console.WriteLine(n02);
            Console.WriteLine(n03);
            Console.WriteLine(n04);
            Console.WriteLine(n05);
            Console.WriteLine(n06);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letar);
            Console.WriteLine(nome);
            Console.WriteLine(obj01);
            Console.WriteLine(obj02);
        }
    }
}