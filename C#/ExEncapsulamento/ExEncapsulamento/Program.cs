using ExEncapsulamento;

Produto produto = new Produto("TV", 500.00, 10);
Console.WriteLine(produto.Nome);

//produto.SetNome("TV 4K");
produto.Nome = "Tv 4k";
Console.WriteLine(produto.Nome);

//produto.SetNome("T");
produto.Nome = "T";
Console.WriteLine(produto.Nome);
