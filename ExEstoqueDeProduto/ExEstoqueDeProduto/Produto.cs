using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEstoqueDeProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int add)
        {
            Quantidade += add;
        }

        public void RemoverProdutor(int remover)
        {
            Quantidade -= remover;
        }

        public override string ToString()
        {
            return $"Dados atualizados: {Nome}, Preço: ${Preco}, Estoque: {Quantidade}, Total ${ValorTotalEmEstoque()}";
        }
    }
}
