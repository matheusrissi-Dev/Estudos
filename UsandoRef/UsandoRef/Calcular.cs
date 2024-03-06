using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoRef
{
    internal class Calcular
    {
        public static int Triple(ref int x)
        {
            x = x * 3;
            return x;
        }

    }
}
