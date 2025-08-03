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

        public void Consulta()
        {
            foreach( Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }


    }
}
