namespace path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\VisualStudio\Estudos\C#\arquivosParaTestes\file1.txt";

            Console.WriteLine("DirectorySeparatorChar:");
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator:");
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine("GetDirectoryName:");
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName:");
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension:");
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension:");
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine("GetFullPath:");
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine("GetTempPath");
            Console.WriteLine(Path.GetTempPath());





        }
    }
}
