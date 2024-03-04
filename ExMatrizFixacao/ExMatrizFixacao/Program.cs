namespace ExMatrizFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Fazer um programa que le 2 numeros M e N, e  depos ler uma matriz de M linhas por N colunas contendo numeros inteiros 
            podendo haver repetição. Em seguida, ler um numero inteiro X que pertence a matriz. Para cada ocorrencia de X,
            mostrar os valores a esquerda, acima a direita e abaixo de X, quando houver.
            */

            Console.WriteLine("Digite 2 numeros inteiros");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Digite o valores da linha {i}");
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }


            Console.WriteLine("Digite um numero que exista na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == matriz[i, j])
                    {
                        Console.WriteLine($"Posição do numero dijitado [{i}] [{j}]");

                        if (j > 0)
                        {
                            Console.WriteLine($"Numero a esquerda --> {matriz[i, j - 1]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Numero a direita --> {matriz[i, j + 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Numero a cima --> {matriz[i - 1, j]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Numero a baixo --> {matriz[i + 1, j]}");
                        }    
                    }
                }
            }
        }
    }
}
