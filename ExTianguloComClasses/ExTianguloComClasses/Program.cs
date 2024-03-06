using ExTianguloComClasses;

double p, areaX, areaY;
Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Digite os 3 lados do triangulo X");
x.ladoUm = double.Parse(Console.ReadLine());
x.ladoDois = double.Parse(Console.ReadLine());
x.ladoTreis = double.Parse(Console.ReadLine());

Console.WriteLine("Digite os 3 lados do triangulo Y");
y.ladoUm = double.Parse(Console.ReadLine());
y.ladoDois = double.Parse(Console.ReadLine());
y.ladoTreis = double.Parse(Console.ReadLine());


p = (x.ladoUm + x.ladoDois + x.ladoTreis) / 2;
areaX = Math.Sqrt(p * (p - x.ladoUm) * (p - x.ladoDois) * (p - x.ladoTreis));

p = (y.ladoUm + y.ladoDois + y.ladoTreis) / 2;
areaY = Math.Sqrt(p * (p - y.ladoUm) * (p - y.ladoDois) * (p - y.ladoTreis));

Console.WriteLine($"Area de X: {areaX:F4}");
Console.WriteLine($"Area de Y: {areaY:F4}");


if (areaX < areaY)
{
    Console.WriteLine("Area do triangulo Y é maior");
}
else
{
    Console.WriteLine("Area do triangulo X é maior");
}