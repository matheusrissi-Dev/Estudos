namespace directoryAndDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\VisualStudio\Estudos\C#\arquivosParaTestes";


            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas: ");
                foreach (var item in folders)
                {
                    Console.WriteLine(item);
                }


                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos: ");
                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\Nova_Pasta");



            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocorreu um erro: {ex.Message}");
            }

        }
    }
}
