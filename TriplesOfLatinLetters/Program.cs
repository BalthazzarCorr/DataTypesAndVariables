using System;

namespace TriplesOfLatinLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());

			for (int i = 0; i <= input-1; i++)
			{
				for (int j = 0; j <= input-1; j++)
				{
					for (int k = 0; k <= input-1; k++)
					{
						char firstLetter = (char) ('a' + i);
						char secontLetter = (char) ('a' + j);
						char thirdLetter = (char) ('a' + k);

						Console.WriteLine($"{firstLetter}{secontLetter}{thirdLetter}");
					}
				}
			}
		}
	}
}
