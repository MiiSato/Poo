using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Aluno:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as notas do aluno:");

            do
            {
                Console.WriteLine("Digite a Nota do primeiro trimeste:");
                aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
            } while (aluno.Nota1 < 0 || aluno.Nota1 > 30);

            do
            {
                Console.WriteLine("Digite a Nota do segundo trimeste:");
                aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
            } while (aluno.Nota2 < 0 || aluno.Nota2 > 35);

            do
            {
                Console.WriteLine("Digite a Nota do terceiro trimeste:");
                aluno.Nota3 = Convert.ToDouble(Console.ReadLine());
            } while (aluno.Nota3 < 0 || aluno.Nota3 > 35);

            double notaFinal = aluno.GetNotaFinal();

            Console.WriteLine("Nota final:" + notaFinal);

            if(notaFinal >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO"); 
                Console.WriteLine("Faltaram: " + (60 - notaFinal) + " pontos.");
            }

            Console.ReadKey();
        }
    }
}
