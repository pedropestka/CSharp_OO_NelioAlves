using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto("TV", 500.00, 10);

            Console.WriteLine("Dados do produto: " + p);

            // -------------NOME----------------
            // alterando o _nome através do set
            p.Nome = "TV 4K";

            // obtendo o _nome através do get
            Console.WriteLine(p.Nome);

            // mesma operação, agora com condição do método set
            p.Nome = "T";

            // obtendo o _nome através do get
            Console.WriteLine(p.Nome);

            // -------------PREÇO----------------

            //p.Preco = 550.00; é impossível alterar o valor pelo programa
            Console.WriteLine(p.Preco); // mas posso obte-lo;

            // -------------QUANTIDADE------------
            //p.Quantidade = 550.00; é impossível alterar o valor pelo programa
            Console.WriteLine(p.Quantidade); // mas posso obte-lo;


            // apenas pelos métodos AdicionarProduto e RemoverProduto podem alterar a quantidade
            int qte = 12;
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            qte = 7;
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadLine();
        }
    }
}