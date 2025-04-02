using System.Globalization;

namespace DevSuperior {
    class Product {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Product() {
        }
        public Product(string nome, double preco, int quantidade) {

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Product(string nome, double preco) {

            Nome = nome;
            Preco = preco;
            Quantidade = 10;
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
