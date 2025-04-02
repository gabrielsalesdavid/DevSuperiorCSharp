using System;
using System.Globalization;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            string origin = "abcde ABC abc DEFG   ";
            string s01 = origin.ToUpper();
            string s02 = origin.ToLower();
            string s03 = origin.Trim();

            int n01 = origin.IndexOf("bc");
            int n02 = origin.LastIndexOf("bc");

            string s04 = origin.Substring(3);
            string s05 = origin.Substring(3, 5);
            string s06 = origin.Replace('a', 'x');
            string s07 = origin.Replace("abc", "xy");

            bool b01 = String.IsNullOrEmpty(origin);
            bool b02 = String.IsNullOrWhiteSpace(origin);


            Console.WriteLine("Origin: -" + origin + "-");
            Console.WriteLine("ToUpper: -" + s01 + "-");
            Console.WriteLine("ToLower: -" + s02 + "-");
            Console.WriteLine("Trim: -" + s03 + "-");
            Console.WriteLine("IndexOf: -" + n01 + "-");
            Console.WriteLine("LastIndexOf: -" + n02 + "-");
            Console.WriteLine("Substring: -" + s04 + "-");
            Console.WriteLine("Substring: -" + s05 + "-");
            Console.WriteLine("Replace: -" + s06 + "-");
            Console.WriteLine("Replace: -" + s07 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b01 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b02 + "-");
        }
    }
}