using System.Globalization;

namespace DevSuperior {
    struct Point {

        public double X;
        public double Y;

        public override string ToString() {

            return "("
                + X
                + ", "
                + Y
                + ")";
        }
    }
}