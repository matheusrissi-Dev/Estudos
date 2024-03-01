using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCotacaoDolar
{
    class ConversorDeMoeda
    {
        static double Iod = 6.00;

        public static double calcular(double cotacao, double dol)
        {
            return ((Iod/100) * dol * cotacao) + (cotacao * dol);
        }

    }
}
