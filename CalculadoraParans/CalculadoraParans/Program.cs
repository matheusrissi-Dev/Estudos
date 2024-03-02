namespace CalculadoraParans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Sum(2, 3);
            int s2 = Calculadora.Sum(1,2,3,4,5);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
