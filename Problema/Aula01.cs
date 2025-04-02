using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace DevSuperior {

    class Aula01 {

        static void Main(string[] args) {

            int quantity;

            Product p = new Product();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Digite o múmero de produtos a ser adicionado ao estoque: ");
            Console.Write("Quantidade: ");
            quantity = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantity);

            Console.WriteLine();
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Digite o múmero de produtos a ser removido do estoque: ");
            Console.Write("Quantidade: ");
            quantity = int.Parse(Console.ReadLine());
            p.RemoveProdutos(quantity);

            Console.WriteLine();
            Console.WriteLine(p);
        }
    }
}