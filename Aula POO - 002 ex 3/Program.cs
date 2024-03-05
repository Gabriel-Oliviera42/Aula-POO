using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
