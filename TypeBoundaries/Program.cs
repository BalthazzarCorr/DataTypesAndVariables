using System;

namespace TypeBoundaries
{
	class Program
	{
		static void Main(string[] args)
		{
			string dataType = Console.ReadLine();

			switch (dataType)
			{
				case "int":
					Console.WriteLine($"{int.MaxValue}\n{int.MinValue}");
					break;
				case "byte":
					Console.WriteLine($"{byte.MaxValue}\n{byte.MinValue}");
					break;
				case "uint":
					Console.WriteLine($"{uint.MaxValue}\n{uint.MinValue}");
					break;
				case "long":
					Console.WriteLine($"{long.MaxValue}\n{long.MinValue}");
					break;
				case "sbyte":
					Console.WriteLine($"{sbyte.MaxValue}\n{sbyte.MinValue}");
					break;
			}
		}
	}
}
