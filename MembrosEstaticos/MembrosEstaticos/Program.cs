using MembrosEstaticos;

Console.WriteLine("Entre com o valor do Raio");
double raio = double.Parse(Console.ReadLine());


double circ = Calculadora.Circunferencia(raio);
double volume = Calculadora.Volume(raio);

Console.WriteLine($"Circunferencia: {circ:F2}");
Console.WriteLine($"Volume: {volume:F2}");
Console.WriteLine($"Valor de PI: {Calculadora.pi}");