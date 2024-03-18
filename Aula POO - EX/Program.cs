using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_EX
{
    class Aluno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public string Nome { get; set; }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }

        public void Gravar()
        {
            Console.Write("Qual o nome do aluno: ");
            Nome = Console.ReadLine();

            Console.Write("Nota 1: ");
            Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            Nota2 = double.Parse(Console.ReadLine());
        }

        public void Mostrar(double media)
        {
            Console.WriteLine($"Aluno: {Nome}");
            Console.WriteLine($"Nota 1: {Nota1}");
            Console.WriteLine($"Nota 2: {Nota2}");
            Console.WriteLine($"Média: {media}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            Aluno aluno = new Aluno();

            aluno.Gravar();
            media = aluno.CalcularMedia();
            aluno.Mostrar(media);

            Console.ReadKey();
        }
    }
}