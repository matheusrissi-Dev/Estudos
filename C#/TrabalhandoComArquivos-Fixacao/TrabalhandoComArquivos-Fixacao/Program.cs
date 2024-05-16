using TrabalhandoComArquivos_Fixacao.Entities;

namespace TrabalhandoComArquivos_Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\VisualStudio\Estudos\C#\arquivosParaTestes\lista.csv";


            try
            {

                string[] lines = File.ReadAllLines(sourcePath);
                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";


                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (var item in lines)
                    {
                        string[] campos = item.Split(',');
                        string name = campos[0];
                        double price = double.Parse(campos[1]);
                        int quantidade = int.Parse(campos[2]);

                        Product prod = new Product(name, price, quantidade);

                        sw.WriteLine($"Nome: {prod.Name}, Preço: {prod.Total()}");
                    }
                }



            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
