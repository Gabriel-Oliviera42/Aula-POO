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
            string estado1;
            string estado2;
            string estado3;

            double popu1;
            double popu2;
            double popu3;

            double poputotal;

            double vacinados1;
            double vacinados2;
            double vacinados3;

            double vacinadostotal;

            double faltavacinar;
            string con = "SIM";
            do
            {
                Console.WriteLine("Digite o nome do primeiro estado:");
                estado1 = Console.ReadLine();
                Console.WriteLine("Digite a população do primeiro estado:");
                popu1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número de pessoas vacinadas no primeiro estado:");
                vacinados1 = double.Parse(Console.ReadLine());

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

                poputotal = popu1 + popu2 + popu3;
                vacinadostotal = vacinados1 + vacinados2 + vacinados3;

                faltavacinar = poputotal - vacinadostotal;
                Console.WriteLine($"Falta Vacinar: {faltavacinar.ToString("0")}");

                Console.WriteLine("Digite SIM caso queira continuar");
                con = Console.ReadLine();

            } while (con == "SIM");
        }
    }
}