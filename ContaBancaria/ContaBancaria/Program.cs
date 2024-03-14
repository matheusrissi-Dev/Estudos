using ContaBancaria.Entities;
using ContaBancaria.Entities.Exception;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dados da conta");
                Console.Write("Numero da conta: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Nome do titular: ");
                string name = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                Console.Write("Limite de Saque: ");
                double limit = double.Parse(Console.ReadLine());

                Conta conta = new Conta(number, name, saldoInicial, limit);


                Console.WriteLine();
                Console.Write("Deseja Sacar ou Depositar (S ou D) Ou Sair (0)");
                string op = Console.ReadLine().ToUpper();
                
                while (op != "0")
                {
                    if (op == "D")
                    {
                        Console.WriteLine();
                        Console.Write("Valor do deposito: ");
                        double deposito = double.Parse(Console.ReadLine());
                        conta.Deposito(deposito);
                        Console.WriteLine(conta);

                        Console.WriteLine();
                        Console.Write("Deseja fazer outra operação: (S ou N)");
                        string outraOp = Console.ReadLine().ToUpper();
                        if (outraOp == "S")
                        {
                            Console.Write("Deseja Sacar ou Depositar (S ou D) Ou Sair (0)");
                            op = Console.ReadLine().ToUpper();
                        }
                        else
                        {
                            op = "0";
                        }

                    }
                    else if (op == "S")
                    {
                        Console.WriteLine();
                        Console.Write("Valor do saque: ");
                        double saque = double.Parse(Console.ReadLine());
                        conta.Saque(saque);

                        Console.WriteLine(conta);

                        Console.WriteLine();
                        Console.Write("Deseja fazer outra operação: (S ou N)");
                        string outraOp = Console.ReadLine().ToUpper();
                        if(outraOp == "S")
                        {
                            Console.Write("Deseja Sacar ou Depositar (S ou D) Ou Sair (0)");
                            op = Console.ReadLine().ToUpper();
                        }
                        else
                        {
                            op = "0";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção invalida. Tente novamente");
                        op = Console.ReadLine().ToUpper();
                    }
                }


            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

        }
    }
}
