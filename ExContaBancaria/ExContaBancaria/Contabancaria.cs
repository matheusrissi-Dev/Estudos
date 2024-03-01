using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancaria
{
    class Contabancaria
    {
        private double _vaalorInicial = 0.00;
        public string? NumConta { get;  private set; }
        public string? NomeTitular { get;  private set; }
        public double Saldo { get; private set; }
        public double Saque { get; set; }
        public double Deposito { get; set; }

        public Contabancaria(string? numConta, string? nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
        }

        public double ValorInicial(string op, double primeiroValor)
        {
            if (op == "S")
            {
                _vaalorInicial = _vaalorInicial + primeiroValor;
            }
           
            return _vaalorInicial;
        }
        public void CalculaSaldo()
        {
           
            Saldo =  _vaalorInicial + Deposito + Saque;
  
        }


        public override string ToString()
        {
            return $"Conta: {NumConta}, Titular {NomeTitular}, Saldo: {Saldo}";
        }




    }
}
