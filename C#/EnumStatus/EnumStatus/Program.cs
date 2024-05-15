using EnumStatus.Entities;
using EnumStatus.Entities.Enums;

namespace EnumStatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 00001,
                Moment = DateTime.Now,
                Status = OrderStatus.PemdingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PemdingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
