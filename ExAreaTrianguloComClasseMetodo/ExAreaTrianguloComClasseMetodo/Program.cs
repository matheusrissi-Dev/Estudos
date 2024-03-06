using ExAreaTrianguloComClasseMetodo;
using System.Threading.Channels;

double areaX, areaY;

Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

Console.WriteLine("Digite 3 lados do triangulo 1");
x.l1 = double.Parse(Console.ReadLine());
x.l2 = double.Parse(Console.ReadLine());
x.l3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite 3 lados do triangulo 2");
y.l1 = double.Parse(Console.ReadLine());
y.l2 = double.Parse(Console.ReadLine());
y.l3 = double.Parse(Console.ReadLine());

areaX = x.Area();
areaY = y.Area();

if (areaX > areaY)
{
    Console.WriteLine("Triangulo 1 é maior");
}
else
{
    Console.WriteLine("Triangulo 2 é maior");
}
