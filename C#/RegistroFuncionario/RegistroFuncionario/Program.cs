using RegistroFuncionario.Entities;

namespace RegistroFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Quantos funcionarios serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());  

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Empregado {i + 1}:");
                Console.WriteLine("É terceirizado? (S/N)");
                string terceiro = Console.ReadLine().ToUpper();


                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (terceiro == "S")
                {
                    Console.Write("Valor Adicional: ");
                    double addChange = double.Parse(Console.ReadLine());
                    list.Add(new OutSourceEmployee(nome, hours, valuePerHour, addChange));
                }
                else
                {
                    list.Add(new Employee(nome, hours, valuePerHour));
                }
            }


            foreach (var item in list)
            {
                Console.WriteLine($"Nome: {item.Name} - R${item.Payment()}");
            }
        }
    }
}
