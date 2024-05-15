using ExEstoqueDeProduto;

Produto produto = new Produto();

produto.Nome = "TV";
produto.Quantidade = 10;
produto.Preco = 900.00;

Console.WriteLine("Qual o nome do produto?");
produto.Nome = Console.ReadLine();

Console.WriteLine("Qual o preço do produto?");
produto.Preco = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a quantidade de produto?");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Dados do produto {produto}");



Console.Write("Digite o numero de produtos a ser adicionado: ");
int addRemove = int.Parse(Console.ReadLine());
produto.AdicionarProdutos(addRemove);
Console.WriteLine($"Dados atualizados {produto}");



Console.Write("Digite o numero de produtos a ser removidos: ");
addRemove = int.Parse(Console.ReadLine());
produto.RemoverProdutor(addRemove);
Console.WriteLine($"Dados atualizados {produto}");