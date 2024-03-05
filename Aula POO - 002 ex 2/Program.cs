using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO___002_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de linhas da matriz:");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de colunas da matriz:");
            int colunas = int.Parse(Console.ReadLine());

            // Declaração e alocação da matriz
            int[,] matriz = new int[linhas, colunas];

            // Preenchimento da matriz
            PreencherMatriz(matriz);

            // Exibição da soma dos elementos
            ExibirSoma(matriz);

            // Cálculo e exibição da média dos valores
            ExibirMedia(matriz);
            Console.ReadKey();
        }

        // Função para preencher a matriz com valores informados pelo usuário
        static void PreencherMatriz(int[,] matriz)
        {
            Console.WriteLine("Informe os valores da matriz:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Matriz[{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Função para exibir a soma de todos os elementos da matriz
        static void ExibirSoma(int[,] matriz)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }

            Console.WriteLine($"Soma dos elementos: {soma}");
        }

        // Função para calcular e exibir a média dos valores na matriz
        static void ExibirMedia(int[,] matriz)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }

            double media = (double)soma / (matriz.GetLength(0) * matriz.GetLength(1));

            Console.WriteLine($"Média dos valores: {media:F2}");
        }
    }
}
