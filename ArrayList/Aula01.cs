using System;
using System.Globalization;
using System.Collections.Generic;
using System.Numerics;

namespace DevSuperior {
    class Aula01 {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach(string obj in list) {

                Console.WriteLine(obj + " ");
            }

            Console.WriteLine("List count: ", list.Count);

            string s01 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s01);

            string s02 = list.Find(Test);
            Console.WriteLine("First 'A': " + s02);

            string s03 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s03);

            int pos01 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + pos01);

            int pos02 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + pos02);

            List<string> list02 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("First 'A': " + list02);

            foreach (string obj in list02) {

                Console.WriteLine(obj + " ");
            }

            list.Remove("Alex");

            foreach (string obj in list02) {

                Console.WriteLine(obj + " ");
            }

            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list02) {

                Console.WriteLine(obj + " ");
            }

            list.RemoveAt(2);

            foreach (string obj in list02) {

                Console.WriteLine(obj + " ");
            }

            list.RemoveRange(2, 2);

            foreach (string obj in list02) {

                Console.WriteLine(obj + " ");
            }
        }

        static bool Test(string s) {

            return s[0] == 'A';
        }
    }
}