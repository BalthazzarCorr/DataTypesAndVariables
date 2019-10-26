using System;

namespace NumberChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			if (input.Contains("."))
			{
				
				Console.WriteLine("floating-pointer");
			}
			else
			{
				Console.WriteLine("integer");
			}
		}
	}
}
