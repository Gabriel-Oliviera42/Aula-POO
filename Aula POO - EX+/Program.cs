using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_EX
{
    class Pessoa
    {
        public double Altura;
        public double Peso;

        public Pessoa(double peso)
        {
            Peso = peso;
        }

        public double IMC() // ostodos são publicos e não estaticos porque não precisão ser executados juntos com o códigos
        {
            return Peso / (Altura * Altura);
        }

        public void Gravar()
        {
            Console.Write("Altura: ");
            Altura = double.Parse(Console.ReadLine());
        }

        public void Mostrar()
        {
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"IMC: {IMC().ToString("0.00")}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque o peso meu chapa: ");
            double peso = double.Parse(Console.ReadLine());
            Pessoa pessoa = new Pessoa(peso);

            pessoa.Gravar();
            pessoa.Mostrar();

            Console.ReadKey();

        }
    }
}