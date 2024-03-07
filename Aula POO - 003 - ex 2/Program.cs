using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Seja a estrutura:
struct FormasGeometricas
{
double largura;
double altura;
}
Implemente as funções a seguir:
double AreaTriangulo(Formas Geometricas FG) { }
void Gravar(ref FormasGeometricas FG) { }
void Mostrar(FormasGeometricas FG) { }
Desenvolva um projeto e demonstre o uso das funções.
*/
namespace Aula_POO___003___ex_2
{

    internal class Program
    {
        struct FormasGeometricas
        {
            public double largura;
            public double altura;
        }

        static void Main(string[] args)
        {
            // Declaração de variáveis
            int op = 0;

            FormasGeometricas FG1;
            FG1.largura = 0;
            FG1.altura = 0;

            // Loop principal
            while (op != 4)
            {
                Console.Clear(); // Limpa a tela do console
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Gravar");
                Console.WriteLine("2. AreaTriangulo");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Sair");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Qual opção você quer?");
                op = int.Parse(Console.ReadLine()); // Leitura da opção escolhida pelo usuário

                switch (op)
                {
                    case 1:
                        Gravar(ref FG1);
                        break;
                    case 2:
                        AreaTriangulo(FG1);
                        break;
                    case 3:
                        Mostrar(FG1);
                        break;
                    case 4:
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
        static void Gravar(ref FormasGeometricas FG)
        {
            Console.Write("Digite a altura:");
            FG.altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a largura:");
            FG.largura = double.Parse(Console.ReadLine());
        }

        static double AreaTriangulo(FormasGeometricas FG)
        {
            return (FG.altura * FG.largura)/ 2;
        }

        static void Mostrar(FormasGeometricas FG)
        {
            Console.WriteLine("a largura é " + FG.largura.ToString("0.00") + " e a altura é " + FG.altura.ToString("0.00"));
            Console.WriteLine("a area é " + AreaTriangulo(FG));
        }

    }
}
