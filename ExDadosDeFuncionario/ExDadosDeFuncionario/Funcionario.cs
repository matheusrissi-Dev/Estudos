using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDadosDeFuncionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double aumento)
        {
            SalarioBruto += SalarioBruto * aumento / 100.0;
        }

        public override string ToString()
        {
            return $"{Nome}, Salario liquido{SalarioLiquido()}";
        }


    }
}
