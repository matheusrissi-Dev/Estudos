

namespace locacaoDeCarro.Entities
{
    internal class AluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Pagamento Pagamento { get; set; }

        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }
    }
}
