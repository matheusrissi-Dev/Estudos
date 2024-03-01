namespace VetoresUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas querem medir a altura: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double[] vet = new double[n];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Digite a altura da pesoa [{i}]");
                vet[i] = double.Parse(Console.ReadLine());
                sum += vet[i];
            }

            double avg = sum / n;
            Console.WriteLine(vet);
            Console.WriteLine($"A media das alturas é de {avg:F2}");
        }
    }
}
