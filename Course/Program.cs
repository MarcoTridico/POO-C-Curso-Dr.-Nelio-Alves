using Course;
using System.Globalization;

//Pequeno exercicio para colocar em pratica primeiras aulas do curso de Orientacao a Objetos do Professor Nelio Alves
internal class Program
{
    private static void Main(string[] args)
    {
        Estoque estoque = new Estoque();
        bool bandeira = true;
        int id = 1;

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
                    estoque.Cadastra(id);
                    id++;
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
                default: //trata qualquer entrada que nao for uma opcao valida do menu
                    Console.WriteLine("Entrada invalida, digite uma das opcoes do menu: ");
                    break;
            }

        } while (bandeira == true);
    }
}