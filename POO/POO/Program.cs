using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a largura do retangulo:");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com a altura do retangulo:");
            double altura = Convert.ToDouble(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);

            Console.WriteLine("Area:" + retangulo.GetArea());
            Console.WriteLine("Perimetro:" + retangulo.GetPerimetro());
            Console.WriteLine("Diagonal:" + retangulo.GetDiagonal());

            Console.ReadKey();
        }
    }
}
