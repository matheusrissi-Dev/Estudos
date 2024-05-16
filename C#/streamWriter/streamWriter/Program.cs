namespace streamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\VisualStudio\Estudos\C#\arquivosParaTestes\file1.txt";
            string targetPath = @"C:\VisualStudio\Estudos\C#\arquivosParaTestes\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string item in lines)
                    {
                        sw.WriteLine(item.ToUpper());
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine($"Um erro foi encontrado: {e.Message}");
            }
        }
    }
}
