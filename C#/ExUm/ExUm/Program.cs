using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double media = 53.234567;

Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
Console.WriteLine($"{produto2}, cujo preço é ${preco2}");
Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero {genero}");
Console.WriteLine($"Media com 8 casas deciamis: {media:F8}");
Console.WriteLine($"Arrednodando com 3 casas decimais: {media:F3}");
Console.WriteLine($"Separador decimal invariant culture: " + media.ToString(CultureInfo.InvariantCulture),"F3");


