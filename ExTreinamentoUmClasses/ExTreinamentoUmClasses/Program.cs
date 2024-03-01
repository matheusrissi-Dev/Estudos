

using ExTreinamentoUmClasses;

Pessoa p1, p2;
p1 = new Pessoa();
p2 = new Pessoa();

Console.WriteLine("Digite o nome 1");
p1.nome = Console.ReadLine();
Console.WriteLine("Digite a idade 1");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome 2");
p2.nome = Console.ReadLine();
Console.WriteLine("Digite a idade 2");
p2.idade = int.Parse(Console.ReadLine());

if(p1.idade > p2.idade)
{
    Console.WriteLine($"{p1.nome} é mais velha");
}
else
{
    Console.WriteLine($"{p2.nome} é mais velha");
}