using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Desenvolva uma estrutura Funcionário, contendo nome e salário. Desenvolva um
projeto com o seguinte menu:
1. Gravar Nome e Salário do Funcionário.
2. Mostrar Nome e Salário do Funcionário.
3. Sair
Implemente as funções void Gravar(ref Funcionario F) e void Mostrar(Funcionario F) para
modularizar o projeto.
*/
namespace Aula_POO___003___ex_2
{
    internal class Program
    {
        struct Funcionario
        {
            public string nome;
            public double salario;
        }

        static void Main(string[] args)
        {
            // Declaração de variáveis
            int op = 0;
            Funcionario F1;
            F1.nome = "";
            F1.salario = 0;

            // Loop principal
            while (op != 3)
            {
                Console.Clear(); // Limpa a tela do console
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Gravar Nome e Salário do Funcionário.");
                Console.WriteLine("2. Mostrar Nome e Salário do Funcionário.");
                Console.WriteLine("3. Sair");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Qual opção você quer?");
                op = int.Parse(Console.ReadLine()); // Leitura da opção escolhida pelo usuário

                switch (op)
                {
                    case 1:
                        Gravar(ref F1);
                        break;
                    case 2:
                        Mostrar(F1);
                        break;
                    case 3:
                        Console.WriteLine("Procedimento finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.WriteLine("Pressione Enter para continuar");
                Console.ReadKey(); // Aguarda uma tecla ser pressionada antes de continuar o loop
            }
        }

        static void Gravar(ref Funcionario F)
        {
            Console.Write("Digite o nome do funcionario:");
            F.nome = Console.ReadLine();

            Console.Write("Digite o salario do funcionario:");
            F.salario = double.Parse(Console.ReadLine());
        }

        static void Mostrar(Funcionario F)
        {
            Console.WriteLine(F.nome + " - " + F.salario.ToString("0.00"));
        }

    }
}
