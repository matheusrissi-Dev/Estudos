

namespace locacaoDeCarro.Entities
{
    internal class Pagamento
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Pagamento(double pagamentobasico, double taxa)
        {
            PagamentoBasico = pagamentobasico;
            Taxa = taxa;
        }

        public double TotalPagamento
        {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return $"Pagamento Base: {PagamentoBasico:f2}\n" +
                $"Taxa: {Taxa}%\n" +
                $"Total a pagar: {TotalPagamento:f2}";
        }

    }
}
