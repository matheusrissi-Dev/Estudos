namespace UsandoRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calcular.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
