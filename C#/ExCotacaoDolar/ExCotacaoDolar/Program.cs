using ExCotacaoDolar;

Console.WriteLine("Qual a cotacao do dolar?");
double cotacao = double.Parse(Console.ReadLine());

Console.WriteLine("Quantos dolares você vai comprar?");
double dolar = double.Parse(Console.ReadLine());

double reais = ConversorDeMoeda.calcular(cotacao, dolar);

Console.WriteLine($"Valor a ser pago em Reais: R${reais:F2}");