using DadosDeTrabalhador.Entities;
using DadosDeTrabalhador.Entities.Enum;

namespace DadosDeTrabalhador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler os dados de um trbalhador com N contratos (N fornecido pelo usuario).
             * Depois solicitar do usuario um mes e mostrar qual foi o salario do funcionario nesse mes.
             */

            

            //Obtendo datos do trabalhador
            Console.WriteLine("Qual seu departamento: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Level: ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salario Base: ");
            double baseSalary = double.Parse(Console.ReadLine());
            
            //Instanciando dados
            Department dprtmnt = new Department(departamento);
            Worker worker = new Worker(name, workerLevel, baseSalary, dprtmnt);


            //Obtendo dados de contratos
            Console.WriteLine("Quandos contratos serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com dados do {i + 1}° contrato");
                Console.Write("Data (DD/MM/YYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração de horas: ");
                int horas = int.Parse(Console.ReadLine());

                //Instanciando dados decontrato
                HourContract contract = new HourContract(date, valorHora, horas);

                //Vinculando contrato ao trabalhador
                worker.AddContract(contract);
            }

            Console.WriteLine("Entre com o mes e ano para calcular o ganho: (MM/YYYY)");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine($"Nome: {worker.Name}\n" +
                $"Departamento {worker.Department.Name}\n" +
                $"Renda para {mesAno}: R${worker.Renda(mes, ano)}");


        }
    }
}
