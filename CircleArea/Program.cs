using System;

namespace CircleArea
{
	class Program
	{
		static void Main(string[] args)
		{
			double intputRadius = double.Parse(Console.ReadLine());

			double result = Math.Pow(intputRadius,2)*Math.PI;

			Console.WriteLine($"{result:f12}");

		}
	}
}
