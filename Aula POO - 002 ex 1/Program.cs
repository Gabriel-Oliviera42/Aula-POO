using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Crie um programa em C# que realiza as seguintes operações em um vetor de
inteiros:
a. Preenche o vetor com valores informados pelo usuário.
b. Exibe a soma de todos os elementos do vetor.
c. Calcula a média dos valores no vetor.
d. Encontra e exibe o maior valor no vetor. 
 */

namespace Aula_POO___002_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetor:");
            int tamanho = int.Parse(Console.ReadLine());

            // Declaração e alocação do vetor
            int[] vetor = new int[tamanho];

            // Preenchimento do vetor
            PreencherVetor(vetor);

            // Exibição da soma dos elementos
            ExibirSoma(vetor);

            // Cálculo e exibição da média dos valores
            ExibirMedia(vetor);

            // Encontrar e exibir o maior valor no vetor
            ExibirMaiorValor(vetor);

            Console.ReadKey();
        }

        // Função para preencher o vetor com valores informados pelo usuário
        static void PreencherVetor(int[] vetor)
        {
            Console.WriteLine("Informe os valores do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Vetor[{i}]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        // Função para exibir a soma de todos os elementos do vetor
        static void ExibirSoma(int[] vetor)
        {
            int soma = 0;

            foreach (int elemento in vetor)
            {
                soma += elemento;
            }

            Console.WriteLine($"Soma dos elementos: {soma}");
        }

        // Função para calcular e exibir a média dos valores no vetor
        static void ExibirMedia(int[] vetor)
        {
            int soma = 0;

            foreach (int elemento in vetor)
            {
                soma += elemento;
            }

            double media = (double)soma / vetor.Length;

            Console.WriteLine($"Média dos valores: {media:F2}");
        }

        // Função para encontrar e exibir o maior valor no vetor
        static void ExibirMaiorValor(int[] vetor)
        {
            int maiorValor = vetor[0];

            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maiorValor)
                {
                    maiorValor = vetor[i];
                }
            }

            Console.WriteLine($"Maior valor no vetor: {maiorValor}");
        }
    }
}
