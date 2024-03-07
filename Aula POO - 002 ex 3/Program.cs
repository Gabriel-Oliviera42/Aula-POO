using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Crie um programa em C# que utiliza funções com passagem de valor por
referência para realizar as seguintes operações:
a. Recebe dois números do usuário e troca os valores entre eles utilizando uma
função.
b. Recebe um vetor de inteiros e calcula a soma de seus elementos usando uma
função.
 */

namespace Aula_POO___002_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parte a - Troca de valores entre dois números
            Console.WriteLine("Parte a - Troca de valores entre dois números");
            double num1, num2;

            Console.Write("Informe o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            TrocarValores(ref num1, ref num2);

            Console.WriteLine($"Valores após a troca: num1 = {num1}, num2 = {num2}");

            // Parte b - Cálculo da soma de elementos de um vetor
            Console.WriteLine("\nParte b - Cálculo da soma de elementos de um vetor");
            int[] vetor = { 1, 2, 3, 4, 5 };

            int soma = CalcularSoma(vetor);

            Console.WriteLine($"A soma dos elementos do vetor é: {soma}");

            // Parte c - Cálculo da soma de elementos na diagonal de uma matriz

            Console.WriteLine("Informe o número de linhas e colunas da matriz:");
            int linhas = int.Parse(Console.ReadLine());
            int colunas = linhas; // para fazer uma patriz quadrada

            // Declaração e alocação da matriz
            int[,] matriz = new int[linhas, colunas];
            int res = 0;
            PreencherMatriz(matriz);

            res = Somardiagonal(matriz);

            Console.WriteLine($"Média dos valores: {res}");

            Console.ReadKey();      
        }

        // Função para trocar valores entre dois números
        static void TrocarValores(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        // Função para calcular a soma dos elementos de um vetor
        static int CalcularSoma(int[] vetor)
        {
            int soma = 0;

            foreach (int elemento in vetor)
            {
                soma += elemento;
            }

            return soma;
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

        static int Somardiagonal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        soma += matriz[i,j];
                    }
                }
            }
            return soma;
        }

    }
}
