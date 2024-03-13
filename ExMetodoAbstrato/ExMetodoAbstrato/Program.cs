using ExMetodoAbstrato.Entities;
using System.Collections.Generic;
using System.Globalization;


Console.Write("Numero de contribuintes: ");
int n = int.Parse(Console.ReadLine());

List<Contribuintes> contribuintes = new List<Contribuintes>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Contribuinte {i + 1}");
    Console.Write("Pessoa Juridica ou Fisica: ");
    string JuridicaFisica = Console.ReadLine().ToLower().Trim();

    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Renda anual: ");
    double rendaAnaual = double.Parse(Console.ReadLine());


    if (JuridicaFisica == "juridica")
    {
        Console.Write("Numero de funcionarios: ");
        int nFuncioanrios = int.Parse((Console.ReadLine()));
        contribuintes.Add(new PessoaJuridica(name, rendaAnaual, nFuncioanrios));
    }
    else
    {
        Console.Write("Gasto com Saude: ");
        double gastoSaude = double.Parse((Console.ReadLine()));
        contribuintes.Add(new PessoaFisica(name, rendaAnaual, gastoSaude));
    }
}

double sum = 0.0;
Console.WriteLine();
Console.WriteLine("Taxa paga:");
foreach (Contribuintes item in contribuintes)
{
    double tax = item.ImpostoPago();
    Console.WriteLine($"{item.Nome} : R${tax.ToString("F2")}");
    sum += tax;
}
Console.WriteLine();
Console.WriteLine($"Taxa Total: ${sum.ToString("F2")} ");

