using System;
using System.Globalization;
using DevSuperior.Entities.Enums;

namespace DevSuperior.Entities {

    internal class Order {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {

            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}