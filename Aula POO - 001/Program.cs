using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO___001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item;
            double valor;

            Console.WriteLine("Digite o nome do item:");
            item = Console.ReadLine();

            Console.WriteLine("Digite o valor:");
            valor = double.Parse(Console.ReadLine());

            if (valor >= 1000 )
            {
                valor = valor * 0.95;
            };
            Console.WriteLine($"O item: {item} custa: {valor.ToString("R$0.00")}");
            Console.ReadKey();
        }
    }
}
