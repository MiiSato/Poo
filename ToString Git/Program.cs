using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotacao do dolar? ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantos dolares voce ira comprar? ");
            double quantidadeDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor a ser pago em reais: R$ " + ConversorDeMoeda.GetPrecoFinal(cotacaoDolar, quantidadeDolar));

            Console.ReadKey();
        }
    }
}
