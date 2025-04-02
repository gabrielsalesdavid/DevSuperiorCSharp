using System;
using System.Globalization;

namespace DevSuperior {
    class Product {

        public string Nome;
        public double Preco;
        public int Quantity;

        public double ValorTotalEmEstoque() {

            return Preco * Quantity;
        }

        public int AdicionarProdutos(int quantity) {

            return Quantity += quantity;
        }

        public int RemoveProdutos(int quantity) {

            return Quantity -= quantity;
        }

        public override string ToString() {
            return "Dados do produto: "
                + Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}