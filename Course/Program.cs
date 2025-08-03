using Course;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        Estoque estoque = new Estoque();
        bool bandeira = true;

        do
        {

            Console.WriteLine("------- Menu Produtos ------\n" +
                              "Digite 'cad' para cadastrar:\n" +
                              "Digite 'alt' para alterar:  \n" +
                              "Digite 'del' para apagar:   \n" +
                              "Digite 'con' para consultar:\n" +
                              "Digite 'sair' para fechar   \n" +
                              "----------------------------");
            Console.Write("Digite o comando: ");
            string escolhaMenu = Console.ReadLine();

            switch (escolhaMenu)
            {
                case "cad":
                    estoque.Cadastra();
                    break;
                case "alt":
                    estoque.Altera();
                    break;
                case "del":
                    estoque.Deleta();
                    break;
                case "con":
                    estoque.Consulta();
                    break;
                case "sair":
                    bandeira = false;
                    break;
            }

        } while (bandeira == true);
    }
}