namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\VisualStudio\arquivosParaTestes\file1.txt";
            string targetPath = @"C:\VisualStudio\arquivosParaTestes\file2.txt";

            try
            {
                FileInfo file = new FileInfo(sourcePath);
                file.CopyTo(targetPath);

                string[] linhas = File.ReadAllLines(sourcePath);
                foreach (string item in linhas)
                {
                    Console.WriteLine(item);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
            }
        }
    }
}
