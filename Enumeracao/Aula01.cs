using System;
using System.Globalization;
using DevSuperior.Entities;
using DevSuperior.Entities.Enums;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}