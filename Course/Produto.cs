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
        private static int _contadorId = 0;
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto (string nome, double preco, int quantidade)
        {
            Id = ++_contadorId;
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
