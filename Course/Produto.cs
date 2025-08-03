using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }
        public Produto (int id, string nome, double preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double CalculaSubTotal()
        {
            double subtotal = Quantidade * Preco;
            return subtotal;
        }
        public double AlteraPreco(double preco)
        {
            return Preco = preco;
        }
        public override string ToString()
        {
            return "ID: " + Id + " Produto: " + Nome + "\t Preco: " + Preco.ToString("C") + "\t Quantidade: " + Quantidade + " \tTotal: R" + CalculaSubTotal().ToString("C");
        }
    }
}
