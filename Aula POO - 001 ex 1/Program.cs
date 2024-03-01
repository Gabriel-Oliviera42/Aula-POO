using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1. Desenvolva um projeto com o seguinte menu:
1. Nome do Produto
2. Valor do Produto
3. Forma de Pagamento
4. Mostrar Dados da Compra

Na 1ª. Opção o usuário poderá fornecer o nome do produto.
Na 2ª. Opção o usuário poderá fornecer o valor do produto.
Na 3ª. Opção o usuário poderá escolher através do seguinte sub menu as opções:
1. A vista no dinheiro (dar desconto de 10% e mostrar o valor)
2. PIX (ler o número pix)
3. Parcelado (ler o número de parcelas e fornecer o valor de cada parcela)
*/
namespace Aula_POO___001_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string produto = null;
            double valor = 0;
            string pagamento = null;
            int op = 0;
            int alt;

            // Loop principal
            while (op != 5)
            {
                Console.Clear(); // Limpa a tela do console
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Nome do Produto");
                Console.WriteLine("2. Valor do Produto");
                Console.WriteLine("3. Forma de Pagamento");
                Console.WriteLine("4. Mostrar Dados da Compra");
                Console.WriteLine("5. Finalizar Procedimento");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Qual opção você quer?");
                op = int.Parse(Console.ReadLine()); // Leitura da opção escolhida pelo usuário

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do produto:");
                        produto = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor:");
                        valor = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Digite a forma de pagamento:");
                        Console.WriteLine("1. A vista no dinheiro");
                        Console.WriteLine("2. PIX");
                        Console.WriteLine("3. Parcelado");
                        Console.WriteLine("--------------------------------");
                        alt = int.Parse(Console.ReadLine());

                        // Switch dentro da opção 3 para a forma de pagamento
                        switch (alt)
                        {
                            case 1:
                                Console.WriteLine("A vista no dinheiro. Valor com desconto de 10%: " + (valor - (valor * 0.1)));
                                pagamento = "A vista";
                                break;
                            case 2:
                                Console.WriteLine("Digite o número PIX:");
                                string pix = Console.ReadLine();
                                pagamento = "PIX";
                                break;
                            case 3:
                                Console.WriteLine("Digite o número de parcelas:");
                                int parcelas = int.Parse(Console.ReadLine());
                                double valorParcela = valor / parcelas;
                                Console.WriteLine("Valor de cada parcela: " + valorParcela);
                                pagamento = "Parcelado";
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                        break;
                    case 4:
                        // Exibe os dados da compra
                        // Fiz sem depender do usuario precisar colocar todas as informações, já que vai aparecer em branco nesse caso
                        Console.WriteLine("Nome do Produto: " + produto);
                        Console.WriteLine("Valor do Produto: " + valor);
                        Console.WriteLine("Forma de Pagamento: " + pagamento);
                        break;
                    case 5:
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
    }
}