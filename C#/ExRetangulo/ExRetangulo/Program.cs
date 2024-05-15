using ExRetangulo;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre com a largura e altura do retangulo");
retangulo.largura = double.Parse(Console.ReadLine());
retangulo.altura = double.Parse(Console.ReadLine());

Console.WriteLine(retangulo);