using ExTeinamentoDoisClasses;

Funcionario fun1 = new Funcionario();
Funcionario fun2 = new Funcionario();

Console.WriteLine("Qual o nome do primeiro funcionario?");
fun1.Nome = Console.ReadLine();
Console.WriteLine("Qual o nome do segundo funcionario?");
fun2.Nome = Console.ReadLine();

Console.WriteLine("Qual o salario do primeiro funcionario?");
fun1.Salario = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o salario do segundo funcionario?");
fun2.Salario = double.Parse(Console.ReadLine());

double media = (fun1.Salario + fun2.Salario) / 2;

Console.WriteLine($"O nome dos funcionarios são: {fun1.Nome} e {fun2.Nome} com media salarial de {media:F2}");


