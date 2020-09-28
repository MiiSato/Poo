using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double GetNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}
