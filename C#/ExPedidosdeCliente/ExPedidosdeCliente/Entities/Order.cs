using ExPedidosdeCliente.Entities.Enum;
using System.Text;


namespace ExPedidosdeCliente.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            orderItems.Remove(orderItem);
        }


        public double Total()
        {
            double total = 0;
            foreach (var item in orderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //Resumo
            sb.AppendLine("\n---------------------------------------------");
            sb.AppendLine("Resumo da compra");
            sb.AppendLine($"Momento da compra: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order Status {Status}");
            sb.AppendLine("---------------------------------------------");
            //Cliente
            sb.AppendLine($"cliente: {Client.Name}, {Client.BirthDate.ToString("dd/MM/yyyy")}, {Client.Email}");
            sb.AppendLine("---------------------------------------------");
            //Compra
            foreach (var item in orderItems)
            {
                double subtotal = item.SubTotal();
                sb.AppendLine($"Item: {item.Item.Name}, Quantidade: {item.Quantity}, Subtotal: {subtotal}"); 
            }
            double total = Total();
            sb.AppendLine($"Total: {total:F2}");

            return sb.ToString();
        }

    }
}
