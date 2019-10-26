using System;

namespace Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfPeople = int.Parse(Console.ReadLine());

			int capacityOfElevator = int.Parse(Console.ReadLine());

			int result = (int)Math.Ceiling((double)numberOfPeople/capacityOfElevator) ;

			Console.WriteLine(result);


		}
	}
}
