using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    public class Estoque
    {
        List<Produto> produtos = new List<Produto>();

        public void Cadastra()
        {
            Console.Write("Digite o ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome: ");
            string nome = (Console.ReadLine());
            Console.Write("Digite o preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto produto1 = new Produto(id, nome, preco, quantidade);
            produtos.Add(produto1);
        }
        
        public void Altera()
        {
            Console.Write("Digite o Id do produto que deseja alterar: ");
            int idAlteracao = int.Parse(Console.ReadLine());
            Produto produtoBusca = produtos.Find(p => p.Id == idAlteracao);
            Console.WriteLine(produtoBusca);
            Console.Write("Digite o novo preco do produto: ");
            double precoAlterado = double.Parse(Console.ReadLine());
            produtoBusca.AlteraPreco(precoAlterado);
            Console.WriteLine(produtoBusca);
        }

        public void Deleta()
        {
            Console.Write("Digite o Id do produto que deseja apagar: ");
            int idDeleta = int.Parse(Console.ReadLine());
            Produto produtoBusca = produtos.Find(p => p.Id == idDeleta);
            Console.WriteLine(produtoBusca);
            Console.Write("Tem certeza que deseja apagar o produto selecionado? digite 's' para apagar ou qualquer outra tecla para desistir: ");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
            {
                produtos.Remove(produtoBusca);
                Console.WriteLine("Produto apagado com sucesso! ");
            }
            else
            {
                Console.WriteLine("Operacao abortada, retornando ao menu!");
            }
            

        }
        public void Consulta()
        {
            Console.WriteLine("");
            foreach( Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
            Console.WriteLine("");
        }


    }
}
