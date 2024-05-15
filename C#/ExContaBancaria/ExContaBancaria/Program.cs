using ExContaBancaria;
using System.Xml;

Contabancaria contabancaria;


//Set Numero da conta
Console.WriteLine("Digite o numero da conta:");
string nConta = Console.ReadLine();


//Set Nome do titular
Console.WriteLine("Digite o nome do titular");
string nomeConta = Console.ReadLine();
contabancaria = new Contabancaria(nConta, nomeConta);


//Verifica valor inicial
Console.WriteLine("Havera deposito inicial (S/N)");
string op = Console.ReadLine();
double valorInicial;
if (op == "S")
{
    Console.WriteLine("Entre com o valor do deposito inicial");
    valorInicial = double.Parse(Console.ReadLine());
    contabancaria.ValorInicial(op, valorInicial);
    contabancaria.CalculaSaldo();
}
Console.WriteLine(contabancaria);

//Verifica Sque e deposito
Console.WriteLine("Qual o valor deseja Depositar: ");
double deposito = double.Parse(Console.ReadLine());
contabancaria.Deposito = deposito;
contabancaria.CalculaSaldo();
Console.WriteLine(contabancaria);


Console.WriteLine("Qual o valor deseja sacar: ");
double saque = double.Parse(Console.ReadLine());
contabancaria.Saque = -1 * saque - 5.00;
contabancaria.CalculaSaldo();
Console.WriteLine(contabancaria);