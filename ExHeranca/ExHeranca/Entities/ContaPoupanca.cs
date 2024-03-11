using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExHeranca.Entities
{
    class ContaPoupanca : Conta
    {
        public double TaxaDeJuros { get; set; }
        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaDeJuros) : base(numero, titular, saldo)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo = TaxaDeJuros * Saldo;
        }

        public override void Saque(double saque)
        {
            base.Saque(saque);
            Saldo -= 5;
        }

    }
}
