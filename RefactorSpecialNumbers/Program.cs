using System;

namespace RefactorSpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			int total = 0; 
			for (int i = 1; i <= input; i++)
			{
				var temp = i;
				while (i > 0)
				{
					total += i % 10;
					i = i / 10;
				}
				bool isItTrue = (total == 5) || (total == 7) || (total == 11);
				Console.WriteLine($"{temp} -> {isItTrue}");
				total = 0;
				i = temp;
			}
		}
	}
}
