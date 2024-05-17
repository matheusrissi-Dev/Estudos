using locacaoDeCarro.Entities;
using locacaoDeCarro.Services;
using System.Globalization;

namespace locacaoDeCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Aluguel");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data e hora de retirada do carro (dd/MM/yyyy hh:mm): ");
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            Console.Write("Data e hora de devolução do carro (dd/MM/yyyy hh:mm): ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            
            Console.WriteLine("Entra com o preco por hora: ");
            double hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Entra com o preco por dia: ");
            double day = double.Parse(Console.ReadLine());


            AluguelCarro aluguelCarro = new AluguelCarro(retirada, devolucao, new Veiculo(modelo));
            ServicoDeAluguel servicoDeAluguel = new ServicoDeAluguel(hora, day, new TaxaBrasil());
            servicoDeAluguel.ProcessoPagamento(aluguelCarro);


            Console.WriteLine("Pagamento:");
            Console.WriteLine(aluguelCarro.Pagamento);





        }
    }
}
