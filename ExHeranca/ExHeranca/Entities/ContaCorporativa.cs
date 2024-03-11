namespace ExHeranca.Entities
{
    class ContaCorporativa : Conta
    {
        public double LimiteEmprestimo { get; set; }


        public ContaCorporativa() { }

        public ContaCorporativa(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double emprestimo)
        {
            if (emprestimo < LimiteEmprestimo)
            {
                Saldo += emprestimo;
            }        
        }


    }
}
