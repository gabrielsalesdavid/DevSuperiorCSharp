using System;
using System.Globalization;

namespace DevSuperior.Entities.Enums {
    enum OrderStatus : int {

        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}