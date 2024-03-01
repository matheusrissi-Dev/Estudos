using System.Diagnostics;
using System.Xml.Linq;

namespace AluguelDeQuartos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            InfoQuartos[] vetEstudante = new InfoQuartos[10];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Qual o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o email do estudante: ");
                string email = Console.ReadLine();
                Console.WriteLine("Qual o quarto deseja alugar?");
                int numQuarto = int.Parse(Console.ReadLine());



                vetEstudante[numQuarto] = new InfoQuartos { Nome = nome, Email = email};
            }

            for (int i = 0; i < 10; i++)
            {
                if (vetEstudante[i] != null)
                {
                    Console.WriteLine(i + ": " + vetEstudante[i]);
                }
            }
        }
    }
}
