namespace LeituraDeprodutos.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }


        public ImportedProduct() { }

        public ImportedProduct(string name, double price,double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"Produto: {Name} Total: {TotalPrice()} Taxa de importação: R$:{CustomsFee}";
        }


    }
}
