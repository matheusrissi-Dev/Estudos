
string[] vet = new string[] { "Matheus", "Gabby", "João" };

foreach (string item in vet)
{
    Console.WriteLine($"Com FOREACH {item}");
}

for (int i = 0; i < vet.Length; i++)
{
    Console.WriteLine($"Com FOR {vet[i]}");
}