using heranca.Entities;
using System;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria��o de objetos da superclasse e subclasse
            Conta acc = new Conta(1001, "Ashe", 0);
            ContaJuridica bacc = new ContaJuridica(1002, "Red", 0, 500);

            //Criando objeto conta que ira herdar as informa��es do objeto bacc, que � uma ContaJuridica
            Conta acc1 = bacc;

            //Criando objeto conta que ira herdar os par�metros da subclasse ContaJuridica que s�o colocados
            Conta acc2 = new ContaJuridica(1003, "Pikachu", 0, 200);

            //Criando objeto conta que ira herdar os par�metros da subclasse ContaJuridica que s�o colocados
            Conta acc3 = new ContaPoupanca(1004, "Jolteon", 0, 0.01);

            //downcasting, Criando os objetos das subclasses que herdam os par�metros da superclasse
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100);

            if (acc3 is ContaJuridica)
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is ContaPoupanca)
            {
                //ContaPoupanca acc5 = (ContaPoupanca)acc3;
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.AtualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}