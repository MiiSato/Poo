using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class ConversorDeMoeda
    {
        public static double GetPrecoFinal(double precoDolar, double qtdDolar)
        {
            return (precoDolar * qtdDolar) + ((qtdDolar * 0.06) * precoDolar);
        }
    }
}
