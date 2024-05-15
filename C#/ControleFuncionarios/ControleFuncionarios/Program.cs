namespace ControleFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();

            Console.WriteLine("Quantos funcionarios quer registrar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"ID [{i + 1}]:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Nome[{i + 1}]: ");
                string nome = Console.ReadLine();
                Console.WriteLine($"Salario[{i + 1}]: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionarios(id, nome, salario));
            }

            Console.WriteLine("Entre com o ID que haverá reajuste do salario: ");
            int reajuseID = int.Parse(Console.ReadLine());


            Funcionarios idConsulta = funcionarios.Find(x => x.Id == reajuseID);

            foreach (var item in funcionarios)
            {
                if (idConsulta != null)
                {
                    Console.WriteLine($"Qual aporcentagemque será reajustada do funcionario {item.Nome}");
                    double porcet = double.Parse(Console.ReadLine());
                    idConsulta.ReajustaSalario(porcet);
                    break;

                }
                else
                {
                    Console.WriteLine("Este ID não existe");
                    break;
                }
            }
            

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionarios: ");
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item);
            }



        }
    }
}
