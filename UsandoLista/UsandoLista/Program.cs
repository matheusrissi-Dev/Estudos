using System.Collections.Generic;

List<string> list = new List<string>();

list.Add("Bob"); ;
list.Add("Joao");
list.Add("Clebinho");
list.Add("Mariala");
list.Insert(2, "Arco");
list.Insert(1, "Amora");
list.Add("Andorinha");
list.Add("Carlinhos");
list.Add("Jos");


foreach (string item in list)
{
    Console.WriteLine(item);

}
Console.WriteLine("List count " + list.Count);
Console.WriteLine("\n-------------------------------------------\n");


string s1 = list.Find(X => X[0] == 'A');
Console.WriteLine("Primeiro nome iniciado com A: " + s1);

string s2 = list.FindLast(X => X[0] == 'A');
Console.WriteLine("Ultimo nome iniciado com A: " + s2);

int p1 =  list.FindIndex(X => X[0] == 'A');
Console.WriteLine("Primeira posição que começa com A: "+ p1);

int p2 = list.FindLastIndex(X => X[0] == 'A');
Console.WriteLine("Ultima posição que começa com A: " + p2);

List<string> lis2 = list.FindAll(X => X.Length < 5);
foreach (string item in lis2)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n-------------------------------------------\n");


list.Remove("Bob");
foreach (string item in list)
{
    Console.WriteLine(item);

}

Console.WriteLine("\n-------------------------------------------\n");
list.RemoveAll(X => X[0] == 'A');
foreach (string item in list)
{
    Console.WriteLine(item);

}
Console.WriteLine("\n-------------------------------------------\n");
list.RemoveAt(2);
foreach (string item in list)
{
    Console.WriteLine(item);

}
Console.WriteLine("\n-------------------------------------------\n");

list.RemoveRange(2, 1);
foreach (string item in list)
{
    Console.WriteLine(item);

}