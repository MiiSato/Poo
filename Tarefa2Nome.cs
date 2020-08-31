using System;

namespace Course
{
	
	class Pessoa
    {


		string a;
		string b;

		public static void Main(String[] args)
		{

			pessoa a, b;

			a = new Pessoa();
			b = new Pessoa();

			Console.WriteLine("Nome:");
			a.nome = Console.ReadLine();
			Console.WriteLine("Idade:");
			a.idade = int.Parse(Console.ReadLine());

			Console.WriteLine("Nome:");
			b.nome = Console.ReadLine();
			Console.WriteLine("Idade:");
			b.idade = int.Parse(Console.ReadLine());

			if(a.idade > b.idade)
			{
				Console.WriteLine("O mais velho é:" + a.nome);
			}
			else
			{
				Console.WriteLine("O mais velho é:" + b.nome);
			}

        }
    }
}