using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.HackerCup
{
	public class TravelRestrictions
	{
		//static void Main(string[] args)
		public static void Main2()
		{
			var t = Int32.Parse(Console.ReadLine());

			for (int i = 1; i <= t; i++)
			{
				var n = Int32.Parse(Console.ReadLine());
				var incoming = Console.ReadLine();//.ToCharArray();
				var outgoing = Console.ReadLine();//.ToCharArray();

				

				Console.WriteLine($"Case #{i}:");
				Console.WriteLine($"{incoming}");
				Console.WriteLine($"{outgoing}");
			}
		}
	}
}
