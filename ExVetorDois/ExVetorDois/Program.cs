namespace ExVetorDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            Produto[] vetProd = new Produto[n];

            for (int i = 0; i < vetProd.Length; i++)
            {
                Console.WriteLine($"Qual o nome do produto: {i+1}");
                string name = Console.ReadLine();
                Console.WriteLine($"Qual o preço do produto: {i+1}");
                double price = double.Parse(Console.ReadLine());
                vetProd[i] = new Produto { Nome = name, Preco = price };
                sum += vetProd[i].Preco;
            }

            double avg = sum / n;
            Console.WriteLine($"Media dos produtos é de {avg:F2}");
        }
    }
}
