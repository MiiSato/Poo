using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome:");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario Bruto:");
            funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Imposto:");
            funcionario.Imposto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Funcionario:" + funcionario.Nome + ", " + funcionario.GetSalarioLiquido());

            Console.Write("Digite a porcentagem para aumentar o salario:");
            funcionario.AumentarSalario(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Dados atualizados:" + funcionario.Nome + ", " + funcionario.GetSalarioLiquido());

            Console.ReadKey();
        }
    }
}
