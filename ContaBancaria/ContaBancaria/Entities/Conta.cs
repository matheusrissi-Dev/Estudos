using ContaBancaria.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entities
{
    internal class Conta
    {
        public int Number { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public Conta() { }

        public Conta(int number, string titular, double saldo, double limiteDeSaque)
        {
            Number = number;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Deposito(double deposito)
        {
            if (deposito is double && deposito >= 0)
            {
                Saldo += deposito;
            }
            else
            {
                throw new DomainException("Valor digitado invalido");
            }
            
        }

        public void Saque(double saque)
        {
            if((Saldo > 0 && saque < LimiteDeSaque) && saque < Saldo)
            {
                Saldo -= saque;
            }
            else
            {
                throw new DomainException("Não é possiovel realizar essa operação: Sem saldo " +
                    "ou Saque maior que limite permitido");
            }
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Novo saldo: {Saldo}");

            return sb.ToString();
        }

    }
}
