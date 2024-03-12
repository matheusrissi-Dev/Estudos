using LeituraDeprodutos.Entities;

namespace LeituraDeprodutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Entre com o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto {i + 1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());


                bool optionValidate = true;
                while (optionValidate)
                {
                    Console.WriteLine("Este produto é: Comun // Usado // Importado -> [C][U][I] ");
                    string option = Console.ReadLine().ToUpper();
                    switch (option)
                    {
                        case "C":
                            list.Add(new Product(name, price));
                            optionValidate = false;
                            break;
                        case "U":
                            Console.Write("Data de fabriocação:");
                            DateTime date = DateTime.Parse(Console.ReadLine());
                            list.Add(new UsedProduct(name, price, date));
                            optionValidate = false;
                            break;
                        case "I":
                            Console.Write("Taxa de alfandega: ");
                            double tax = double.Parse(Console.ReadLine());
                            list.Add(new ImportedProduct(name, price, tax));
                            optionValidate = false;
                            break;
                        default:
                            Console.WriteLine("Opção invalida. Tente outra opção");
                            break;
                    }
                }
            }
            Console.WriteLine("Informações de preços");
            foreach (var item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
