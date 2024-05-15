using ExPedidosdeCliente.Entities;
using ExPedidosdeCliente.Entities.Enum;

namespace ExPedidosdeCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get client Data 
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Dia de nascimento: (DD/MM/YYY)");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            //Instance Client
            Client client = new Client(name, email, dateBirth);



            //Get Order Data
            Console.WriteLine("Entre com os dados da solcitação: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Quantos itens serão comprados: ");
            int quantidadeItem = int.Parse(Console.ReadLine());

            //Isntyanciando Order e Order Item
            Order order = new Order(DateTime.Now, orderStatus, client);

            for (int i = 0; i < quantidadeItem; i++)
            {
                Console.WriteLine($"Entre com os dados do produto {i + 1}");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Quantidade que vai levar? ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.Write("Preco do produto: ");
                double precoProduto = double.Parse(Console.ReadLine());

                Products products = new Products(nomeProduto,precoProduto);
                OrderItem orderItem = new OrderItem(quantidade, products);
                order.AddItem(orderItem);
            }
            Console.WriteLine(order);
        }
    }
}
