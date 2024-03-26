using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Classes___Parte_2
{
    internal class Program
    {
        static List<Atleta> listaAtletas = new List<Atleta>();

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Cadastrar Atletas");
                Console.WriteLine("2. Mostrar os dados de um atleta especificado pelo usuário através do seu nome");
                Console.WriteLine("3. Mostrar todos os atletas");
                Console.WriteLine("4. Pesquisar o nome dos atletas de uma determinada modalidade");
                Console.WriteLine("5. Verificar os atletas que possuem desconto maior que 30%");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAtletas();
                        break;
                    case 2:
                        MostrarDadosAtleta();
                        break;
                    case 3:
                        MostrarTodosAtletas();
                        break;
                    case 4:
                        PesquisarAtletasModalidade();
                        break;
                    case 5:
                        VerificarAtletasDescontoMaiorQue30();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CadastrarAtletas()
        {
            Console.Write("Quantos atletas deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Atleta atleta = new Atleta();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Quantas modalidades pratica? ");
                int qtdModalidades = int.Parse(Console.ReadLine());
                string[] modalidades = new string[qtdModalidades];
                for (int j = 0; j < qtdModalidades; j++)
                {
                    Console.Write($"Modalidade {j + 1}: ");
                    modalidades[j] = Console.ReadLine();
                }

                atleta.GravarDados(nome, idade, modalidades);
                listaAtletas.Add(atleta);
            }
        }

        static void MostrarDadosAtleta()
        {
            Console.Write("Digite o nome do atleta: ");
            string nome = Console.ReadLine();

            Atleta atletaEncontrado = listaAtletas.Find(atleta => atleta.RetornarNome().Equals(nome));
            if (atletaEncontrado != null)
            {
                atletaEncontrado.MostrarDados();
            }
            else
            {
                Console.WriteLine("Atleta não encontrado.");
            }
        }

        static void MostrarTodosAtletas()
        {
            foreach (var atleta in listaAtletas)
            {
                atleta.MostrarDados();
            }
        }

        static void PesquisarAtletasModalidade()
        {
            Console.Write("Digite a modalidade: ");
            string modalidade = Console.ReadLine();

            foreach (var atleta in listaAtletas)
            {
                if (Array.Exists(atleta.RetornarModalidades(), element => element.Equals(modalidade, StringComparison.InvariantCultureIgnoreCase)))
                {
                    Console.WriteLine(atleta.RetornarNome());
                }
            }
        }

        static void VerificarAtletasDescontoMaiorQue30()
        {
            foreach (var atleta in listaAtletas)
            {
                if (atleta.Bolsa > 30)
                {
                    atleta.MostrarDados();
                }
            }
        }
    }
}