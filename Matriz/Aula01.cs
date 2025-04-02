using System;
using System.Globalization;
using System.Collections.Generic;

namespace DevSuperior {
    class Aula01 {
        static void Main(string[] args) {

            double[,] mat = new double[4, 4];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
        }
    }
}