using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
4. Pesquisar como declarar e usar um vetor em C# e reescrever o código do
exercício três usando um vetor para armazenar o nome das pessoas, um vetor
para o IMC de cada pessoa.
 */
namespace Aula_POO___001_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defina a quantidade de pessoas
            const int quantidadePessoas = 5;

            // Vetores para armazenar os dados
            double[] pesos = new double[quantidadePessoas]; // Peso de cada pessoa
            double[] alturas = new double[quantidadePessoas]; // Altura de cada pessoa
            double[] imcs = new double[quantidadePessoas]; // Índice de Massa Corporal (IMC)
            string[] resultados = new string[quantidadePessoas]; // Resultado do IMC

            // Contadores para estatísticas
            double magreza = 0, normal = 0, sobrepeso = 0, ob1 = 0, ob2 = 0, ob3 = 0; // Contadores

            // Loop para coletar dados
            for (int i = 0; i < quantidadePessoas; i++)
            {
                // Solicita o peso da pessoa
                Console.WriteLine($"Digite o peso da pessoa {i + 1}:");
                pesos[i] = double.Parse(Console.ReadLine()); // Lê e armazena o peso

                // Solicita a altura da pessoa
                Console.WriteLine($"Digite a altura da pessoa {i + 1}:");
                alturas[i] = double.Parse(Console.ReadLine()); // Lê e armazena a altura

                // Calcula o IMC
                imcs[i] = pesos[i] / (alturas[i] * alturas[i]);

                // Classifica o IMC e atualiza os contadores
                if (imcs[i] < 18.5)
                {
                    resultados[i] = "Magreza"; // IMC indica magreza
                    magreza++; // Incrementa contador
                }
                else if (imcs[i] < 24.9)
                {
                    resultados[i] = "Normal"; // IMC indica normalidade
                    normal++; // Incrementa contador
                }
                else if (imcs[i] < 29.9)
                {
                    resultados[i] = "Sobrepeso"; // IMC indica sobrepeso
                    sobrepeso++; // Incrementa contador
                }
                else if (imcs[i] < 34.9)
                {
                    resultados[i] = "Obesidade grau I"; // IMC indica obesidade grau I
                    ob1++; // Incrementa contador
                }
                else if (imcs[i] < 39.9)
                {
                    resultados[i] = "Obesidade grau II"; // IMC indica obesidade grau II
                    ob2++; // Incrementa contador
                }
                else
                {
                    resultados[i] = "Obesidade grau III"; // IMC indica obesidade grau III
                    ob3++; // Incrementa contador
                }
            }

            // Exibe estatísticas

            Console.WriteLine($"Estatísticas:");
            Console.WriteLine($"Magreza: {magreza}");
            Console.WriteLine($"Normal: {normal}");
            Console.WriteLine($"Sobrepeso: {sobrepeso}");
            Console.WriteLine($"Obesidade grau I: {ob1}");
            Console.WriteLine($"Obesidade grau II: {ob2}");
            Console.WriteLine($"Obesidade grau III: {ob3}");
            Console.ReadKey();
        }
    }
}