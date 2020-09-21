using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public Retangulo (double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        
        public double GetArea()
        {
            return largura * altura;
        }

        public double GetPerimetro()
        {
            return (largura * 2) + (altura * 2);
        }

        public double GetDiagonal()
        {
            return Math.Sqrt(largura*largura + altura*altura);
        }
    }
}
