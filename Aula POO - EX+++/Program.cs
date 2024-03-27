using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO___ex__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transacao T1 = new Transacao();

            Console.Write("Valor do produto: ");
            T1.PrecoProduto = double.Parse(Console.ReadLine());
            Console.Write("Valor Pago: ");
            T1.ValorPago = double.Parse(Console.ReadLine());

            T1.GravarDados(T1.PrecoProduto, T1.ValorPago);
            Console.WriteLine(T1.MostraDados());
            Console.ReadKey();
        }
    }
}
