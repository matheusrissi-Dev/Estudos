using System.Text;

namespace LeituraDeprodutos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Produto: {Name} Preço: R${Price}");

            return sb.ToString();
        }

    }
}
