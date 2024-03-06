namespace ExMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual será o tamanho da sua matriz?");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for (int linhas = 0; linhas < n; linhas++)
            {
                Console.WriteLine($"Digite os numeros da linha {linhas}");
                string[] values = Console.ReadLine().Split(' ');
                for (int colunas = 0; colunas < n; colunas++)
                {
                    mat[linhas, colunas] = int.Parse(values[colunas]);
                }
            }



            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i ++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }



            Console.WriteLine("Quantidade de numero negariovs");
            int count = 0;
            for(int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
