using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Desenvolva um projeto que leia o nome de 3 estados brasileiros e suas
populações, em seguida forneça o número de pessoas vacinadas de cada
estado. Calcule e mostre a porcentagem de pessoas que ainda falta vacinar.
Permita que o usuário possa digitar 3 estados mais de uma vez.
 */

namespace Aula_POO___001_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis para nomes de estados, populações, pessoas vacinadas e totais
            string estado1, estado2, estado3;
            double popu1, popu2, popu3;
            double poputotal;
            double vacinados1, vacinados2, vacinados3;
            double vacinadostotal;
            double faltavacinar;
            string con = "SIM"; // Inicializa a variável de controle do loop

            // Loop para permitir que o usuário digite 3 estados mais de uma vez
            do
            {
                // Entrada de dados para o primeiro estado
                Console.WriteLine("Digite o nome do primeiro estado:");
                estado1 = Console.ReadLine();
                Console.WriteLine("Digite a população do primeiro estado:");
                popu1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número de pessoas vacinadas no primeiro estado:");
                vacinados1 = double.Parse(Console.ReadLine());

                // Entrada de dados para o segundo estado (e assim por diante)
                Console.WriteLine("Digite o nome do segundo estado:");
                estado2 = Console.ReadLine();
                Console.WriteLine("Digite a população do segundo estado:");
                popu2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número de pessoas vacinadas no segundo estado:");
                vacinados2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do terceiro estado:");
                estado3 = Console.ReadLine();
                Console.WriteLine("Digite a população do terceiro estado:");
                popu3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número de pessoas vacinadas no terceiro estado:");
                vacinados3 = double.Parse(Console.ReadLine());

                // Cálculos de totais e faltavacinar
                poputotal = popu1 + popu2 + popu3;
                vacinadostotal = vacinados1 + vacinados2 + vacinados3;
                faltavacinar = poputotal - vacinadostotal;

                // Exibe a quantidade de pessoas que ainda falta vacinar
                Console.WriteLine($"Falta Vacinar: {faltavacinar.ToString("0")}");

                // Pergunta ao usuário se deseja continuar
                Console.WriteLine("Digite SIM caso queira continuar");
                con = Console.ReadLine();

            } while (con == "SIM"); // Condição para continuar o loop
        }
    }
}