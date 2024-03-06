
double x1, x2, x3;
double y1, y2, y3;
double areaX, areaY, p;

Console.WriteLine("Entre com as medidas do triangulo X");
x1 = double.Parse(Console.ReadLine());
x2 = double.Parse(Console.ReadLine());
x3 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do triangulo Y");
y1 = double.Parse(Console.ReadLine());
y2 = double.Parse(Console.ReadLine());
y3 = double.Parse(Console.ReadLine());

p= (x1 + x2 + x3) / 2;
areaX = Math.Sqrt(p* (p-x1) * (p-x2) * (p-x3));

p = (y1 + y2 + y3) / 2;
areaY = Math.Sqrt(p * (p - y1) * (p - y2) * (p - y3));

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