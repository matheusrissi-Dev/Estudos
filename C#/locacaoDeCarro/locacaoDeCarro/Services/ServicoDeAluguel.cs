

using locacaoDeCarro.Entities;

namespace locacaoDeCarro.Services
{
    internal class ServicoDeAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }


        private ITaxService _taxService;

        public ServicoDeAluguel(double precoHora, double precoDia, ITaxService taxService)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _taxService = taxService;
        }

        public void ProcessoPagamento(AluguelCarro aluguelCarro)
        {

            TimeSpan duration = aluguelCarro.Fim.Subtract(aluguelCarro.Inicio);
            double basicPayment = 0.0;

            if(duration.TotalHours <= 12)
            {
                basicPayment = Math.Ceiling(duration.TotalHours) * PrecoHora;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PrecoDia;
            }

            double tax = _taxService.Tax(basicPayment);


            aluguelCarro.Pagamento = new Pagamento(basicPayment, tax);

        }
    }
}
