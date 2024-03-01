using ExConstrutor;

Console.WriteLine("Entre com o nome do produto");
string nome = Console.ReadLine();
Console.WriteLine("Entre com o preço do produto");
double preco = double.Parse(Console.ReadLine());
//Console.WriteLine("Digite a quantiade de produto");
//int quantidade = int.Parse(Console.ReadLine());

//Produto produto = new Produto(nome, preco, quantidade);
Produto produto = new Produto(nome, preco);
Console.WriteLine(produto);
