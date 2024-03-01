using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3. Faça um projeto que leia o nome e calcule o IMC de 5 pessoas.
Apresente um demonstrativo estatístico sobre o IMC das 5 pessoas.
 */
namespace Aula_POO___001_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis para pesos, alturas, IMCs e resultados de cada pessoa
            double peso1, peso2, peso3, peso4, peso5;
            double altura1, altura2, altura3, altura4, altura5;
            double imc1, imc2, imc3, imc4, imc5;
            string resultado1, resultado2, resultado3, resultado4, resultado5;

            // Contadores para estatísticas de classificação de IMC
            double magreza = 0, normal = 0, sobrepeso = 0, ob1 = 0, ob2 = 0, ob3 = 0;

            // Entrada de dados para a pessoa 1
            Console.WriteLine("Digite o peso 1:");
            peso1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura 1:");
            altura1 = double.Parse(Console.ReadLine());
            imc1 = peso1 / (altura1 * altura1);

            // Classificação do IMC e atualização dos contadores
            if (imc1 < 18.5)
            {
                resultado1 = "Magreza";
                magreza++;
            }
            else if (imc1 < 24.9)
            {
                resultado1 = "Normal";
                normal++;
            }
            else if (imc1 < 29.9)
            {
                resultado1 = "Sobrepeso";
                sobrepeso++;
            }
            else if (imc1 < 34.9)
            {
                resultado1 = "Obesidade grau I";
                ob1++;
            }
            else if (imc1 < 39.9)
            {
                resultado1 = "Obesidade grau II";
                ob2++;
            }
            else
            {
                resultado1 = "Obesidade grau III";
                ob3++;
            }

            // Entrada de dados para a pessoa 2 (e assim por diante)
            Console.WriteLine("Digite o peso 2:");
            peso2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura 2:");
            altura2 = double.Parse(Console.ReadLine());
            imc2 = peso2 / (altura2 * altura2);

            if (imc2 < 18.5)
            {
                resultado2 = "Magreza";
                magreza++;
            }
            else if (imc2 < 24.9)
            {
                resultado2 = "Normal";
                normal++;
            }
            else if (imc2 < 29.9)
            {
                resultado2 = "Sobrepeso";
                sobrepeso++;
            }
            else if (imc2 < 34.9)
            {
                resultado2 = "Obesidade grau I";
                ob1++;
            }
            else if (imc2 < 39.9)
            {
                resultado2 = "Obesidade grau II";
                ob2++;
            }
            else
            {
                resultado2 = "Obesidade grau III";
                ob3++;
            }

            // Entrada de dados para a pessoa 3 (e assim por diante)
            Console.WriteLine("Digite o peso 3:");
            peso3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura 3:");
            altura3 = double.Parse(Console.ReadLine());
            imc3 = peso3 / (altura3 * altura3);

            if (imc3 < 18.5)
            {
                resultado3 = "Magreza";
                magreza++;
            }
            else if (imc3 < 24.9)
            {
                resultado3 = "Normal";
                normal++;
            }
            else if (imc3 < 29.9)
            {
                resultado3 = "Sobrepeso";
                sobrepeso++;
            }
            else if (imc3 < 34.9)
            {
                resultado3 = "Obesidade grau I";
                ob1++;
            }
            else if (imc3 < 39.9)
            {
                resultado3 = "Obesidade grau II";
                ob2++;
            }
            else
            {
                resultado3 = "Obesidade grau III";
                ob3++;
            }

            // Entrada de dados para a pessoa 4 (e assim por diante)
            Console.WriteLine("Digite o peso 4:");
            peso4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura 4:");
            altura4 = double.Parse(Console.ReadLine());
            imc4 = peso4 / (altura4 * altura4);

            if (imc4 < 18.5)
            {
                resultado4 = "Magreza";
                magreza++;
            }
            else if (imc4 < 24.9)
            {
                resultado4 = "Normal";
                normal++;
            }
            else if (imc4 < 29.9)
            {
                resultado4 = "Sobrepeso";
                sobrepeso++;
            }
            else if (imc4 < 34.9)
            {
                resultado4 = "Obesidade grau I";
                ob1++;
            }
            else if (imc4 < 39.9)
            {
                resultado4 = "Obesidade grau II";
                ob2++;
            }
            else
            {
                resultado4 = "Obesidade grau III";
                ob3++;
            }

            // Entrada de dados para a pessoa 5 (última pessoa)
            Console.WriteLine("Digite o peso 5:");
            peso5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura 5:");
            altura5 = double.Parse(Console.ReadLine());
            imc5 = peso5 / (altura5 * altura5);

            if (imc5 < 18.5)
            {
                resultado5 = "Magreza";
                magreza++;
            }
            else if (imc5 < 24.9)
            {
                resultado5 = "Normal";
                normal++;
            }
            else if (imc5 < 29.9)
            {
                resultado5 = "Sobrepeso";
                sobrepeso++;
            }
            else if (imc5 < 34.9)
            {
                resultado5 = "Obesidade grau I";
                ob1++;
            }
            else if (imc5 < 39.9)
            {
                resultado5 = "Obesidade grau II";
                ob2++;
            }
            else
            {
                resultado5 = "Obesidade grau III";
                ob3++;
            }

            // Exibe estatísticas finais
            Console.WriteLine($"Estatísticas:");
            Console.WriteLine($"Magreza: {magreza}");
            Console.WriteLine($"Normal: {normal}");
            Console.WriteLine($"Sobrepeso: {sobrepeso}");
            Console.WriteLine($"Obesidade grau I: {ob1}");
            Console.WriteLine($"Obesidade grau II: {ob2}");
            Console.WriteLine($"Obesidade grau III: {ob3}");
            Console.ReadKey(); // Aguarda uma tecla ser pressionada antes de fechar
        }
    }
}
}