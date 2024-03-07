using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPedidosdeCliente.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Products Item { get; set; } = new Products();




        public OrderItem() { }

        public OrderItem(int quantity, Products price)
        {
            Quantity = quantity;
            Item = price;
        }


        public double SubTotal()
        {
            return Quantity * Item.Price;
        }

        public override string ToString()
        {
            double subtotal = SubTotal();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados da compra: ");
            sb.AppendLine($"Item: {Item.Name}, Quantidade: {Item.Price}, Subtotal: R${subtotal}");
            return base.ToString();
        }

    }
}
