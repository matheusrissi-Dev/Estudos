using ExDadosDeFuncionario;

Funcionario funcionario = new Funcionario();

Console.Write("Escreva seu nome: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Escreva seu salario Bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Escreva o imposto: R$");
funcionario.Imposto = double.Parse(Console.ReadLine());
Console.WriteLine(funcionario);



Console.Write("Digite a porcentagem para aumento de salario: ");
double aumento = double.Parse(Console.ReadLine());
funcionario.AumentarSalario(aumento);
Console.WriteLine(funcionario);
