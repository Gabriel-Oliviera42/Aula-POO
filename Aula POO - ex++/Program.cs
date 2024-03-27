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
            double aux1, aux2;

            Console.Write("Valor do produto: ");
            aux1 = double.Parse(Console.ReadLine());
            Console.Write("Valor Pago: ");
            aux2 = double.Parse(Console.ReadLine());

            T1.GravarDados(aux1, aux2);
            Console.WriteLine(T1.MostraDados());
            Console.ReadKey();
        }
    }
}
