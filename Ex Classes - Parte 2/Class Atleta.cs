using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Classes___Parte_2
{
    class Atleta
    {
        // Propriedades da classe Atleta
        public string Nome;
        public int Idade;
        public string[] Modalidades;
        public double Bolsa;

        // Método para gravar os dados do atleta
        public void GravarDados(string nome, int idade, string[] modalidades)
        {
            Nome = nome;
            Idade = idade;
            Modalidades = modalidades;
            CalcularBolsa(); // Chama o método para calcular o valor da bolsa
        }

        // Método para mostrar os dados do atleta
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine("Modalidades:");
            foreach (var modalidade in Modalidades)
            {
                Console.WriteLine($"- {modalidade}");
            }
            Console.WriteLine($"Bolsa: {Bolsa}%");
        }

        // Método para retornar somente o nome do atleta
        public string RetornarNome()
        {
            return Nome;
        }

        // Método para retornar somente as modalidades do atleta
        public string[] RetornarModalidades()
        {
            return Modalidades;
        }

        // Método privado para calcular o valor da bolsa
        private void CalcularBolsa()
        {
            double porcentagem = 0;
            foreach (var modalidade in Modalidades)
            {
                // Calcula a porcentagem da bolsa com base na modalidade
                switch (modalidade.ToLower())
                {
                    case "futebol":
                        porcentagem += 20;
                        break;
                    case "voleibol":
                        porcentagem += 10;
                        break;
                    case "natação":
                        porcentagem += 20;
                        break;
                    case "basquete":
                        porcentagem += 15;
                        break;
                }
            }
            Bolsa = porcentagem; // Define o valor da bolsa
        }
    }
}