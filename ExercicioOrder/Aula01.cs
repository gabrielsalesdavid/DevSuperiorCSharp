using System;
using System.Globalization;
using ExeOrder.entities;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            Comment comment01 = new Comment("Have a nice trip!");
            Comment comment02 = new Comment("Wow taht's awesome!");

            Post post01 = new Post(DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

            post01.AddComment(comment01);
            post01.AddComment(comment02);

            Comment comment03 = new Comment("Have a nice trip!");
            Comment comment04 = new Comment("Wow taht's awesome!");

            Post post02 = new Post(DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys", "See you tomorrow", 5);

            post02.AddComment(comment03);
            post02.AddComment(comment04);

            Console.WriteLine(post01);
            Console.WriteLine(post02);
        }
    }
}