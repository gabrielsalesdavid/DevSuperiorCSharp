using System.Globalization;

namespace DevSuperior {
    class Product {

        private string Nome;
        private double Preco;
        private int Quantidade;

        public Product() {
        }

        public Product(string nome, double preco) : this() {

            Nome = nome;
            Preco = preco;
        }
        public Product(string nome, double preco, int quantidade) : this(nome, preco) {

            this.Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {

            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {

            Quantidade -= quantidade;
        }

        public override string ToString() {

            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
