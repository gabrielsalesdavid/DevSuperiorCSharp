using System;
using System.Globalization;

namespace Worker.entities {
    class HourContract {

        public DateTime Date {  get; set; }
        public double ValuePerHour { get; set; }
        public int Hours {  get; set; }

        public HourContract() {
        }

        public HourContract (DateTime date, double valuePerHour, int hours) {

            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;
        }

        public double TotalValue() {

            return Hours * ValuePerHour;
        }
    }
}