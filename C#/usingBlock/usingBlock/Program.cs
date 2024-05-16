namespace usingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\VisualStudio\Estudos\C#\arquivosParaTestes\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
            }
        }
    }
}
