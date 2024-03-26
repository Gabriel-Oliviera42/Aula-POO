using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_EX
{
    class Aluno
    {
        public double Nota1;    
        public double Nota2;
        public string Nome;

        public Aluno()
        {
            Console.WriteLine("criei");
        }

        public Aluno(string nome)
        {
            this.Nome = nome;
        }

        public double CalcularMedia() // ostodos são publicos e não estaticos porque não precisão ser executados juntos com o códigos
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
            Aluno aluno1 = new Aluno(); //medtodo contrutor, ele aloca o espaço na mémoria, e 'zera' eles

            aluno1.Gravar();
            media = aluno1.CalcularMedia();
            aluno1.Mostrar(media);

            Console.ReadKey();

            Aluno aluno2; 
            Console.Write("Qual o nome do aluno: ");
            string nome = Console.ReadLine();

            aluno2 = new Aluno(nome);
            aluno2.Gravar();
            media = aluno2.CalcularMedia();
            aluno2.Mostrar(media);

            Console.ReadKey();
        }
    }
}