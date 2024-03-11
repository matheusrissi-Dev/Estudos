using ExHeranca.Entities;

namespace ExHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(0001, "Mathue", 0.0);
            ContaCorporativa contaCorporativa = new ContaCorporativa(0001, "Maria", 0.0, 10000);

            //Upcasting
            Conta conta1 = contaCorporativa;
            Conta conta2 = new ContaCorporativa(00003, "Joaquin", 10, 1500);
            Conta conta3 = new ContaPoupanca(0004, "Luiz", 10000, 0.02);


            //DownCasting
            ContaCorporativa conta4 = (ContaCorporativa)conta2;
            conta4.Emprestimo(100);

            //ContaCorporativa conta5 = (ContaCorporativa)conta3;
            if (conta3 is ContaCorporativa)
            {
                ContaCorporativa conta5 = (ContaCorporativa)conta3;
                conta5.Emprestimo(200);
                Console.WriteLine("Emprestimo realizado com sucesso");
            }

            if(conta3 is ContaPoupanca)
            {
                ContaPoupanca conta5 = conta3 as ContaPoupanca;
                conta5.AtualizarSaldo();
                Console.WriteLine("Saldo atualizado");

            }


        }

    }
}

