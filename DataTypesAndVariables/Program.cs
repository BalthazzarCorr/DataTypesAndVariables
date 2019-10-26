using System;

namespace CenturiesToMinutes
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputCenuries = int.Parse(Console.ReadLine());

			int years = 100*inputCenuries;
			decimal day = Math.Truncate(365.2422m *years);

			decimal hours = 24*day;
			decimal minutes = 60*hours;

			Console.WriteLine($"{inputCenuries} centuries = {years} years = {day} days = {hours} hours = {minutes} minutes");


		}
	}
}
