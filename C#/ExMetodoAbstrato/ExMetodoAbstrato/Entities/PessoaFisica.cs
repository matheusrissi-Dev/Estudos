using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMetodoAbstrato.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double GastoSaude { get; set; }


        public PessoaFisica() { }
        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }


        public override double ImpostoPago()
        {
            if (RendaAnual < 20000)
            {
                //double tax = (RendaAnual * 0.15) - (GastoSaude * 0.5);
                return (RendaAnual * 0.15) - (GastoSaude * 0.5); ;


            }
            else
            {
                //double tax = (RendaAnual * 0.25) - (GastoSaude * 0.5);
                return (RendaAnual * 0.25) - (GastoSaude * 0.5); ;
            }
        }
    }
}
