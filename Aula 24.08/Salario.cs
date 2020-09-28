using System; 

namespace Course { 

	class SalarioClass { 

		string x;
		string y;

		public static void Main(String[] args)
		{

			pessoa x, y;

			x = new SalarioClass();
			y = new SalarioClass();

			Console.WriteLine("Nome:");
			x.nome = Console.ReadLine();
			Console.WriteLine("salario:");
			x.salario = int.Parse(Console.ReadLine());

			Console.WriteLine("Nome:");
			y.nome = Console.ReadLine();
			Console.WriteLine("salario:");
			y.salario = int.Parse(Console.ReadLine());

			if(x.salario > y.salario)
			{
				Console.WriteLine("O maior salario é:" + x.nome);
			}
			else
			{
				Console.WriteLine("O maior salario é:" + y.nome);
			}


		}
	}		
}