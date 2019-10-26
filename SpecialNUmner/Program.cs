using System;

namespace SpecialNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			

			for (int i = 1; i <= input; i++)
			{
				int sum = 0;
				int digits = i;
				while (digits > 0)
				{
					sum += digits % 10;
					digits = digits / 10;

				}

				bool special = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine($"{i} -> {special} ");
			}
		}
	}
}
