using System;

namespace ExactSumRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputCount = int.Parse(Console.ReadLine());
			decimal result = 0m;

			for (int i = inputCount; i>0; i--)
			{
				decimal inputNumber = decimal.Parse(Console.ReadLine());
				
				
					result+= inputNumber;
			}

			Console.WriteLine(result);
		}
	}
}
