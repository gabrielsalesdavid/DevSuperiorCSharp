using System.Globalization;

namespace DevSuperior {
    class Product {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade{ get; private set; }

        public Product() {
        }

        public Product(string nome, double preco) : this() {

            _nome = nome;
            Preco = preco;
        }
        public Product(string nome, double preco, int quantidade) : this(nome, preco) {

            Quantidade = quantidade;
        }

        public string Nome {

            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {

                    _nome = Nome;
                }
            }
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

            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
