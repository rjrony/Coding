using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _849_MaximizeDistanceToClosestPerson
	{
		//0, 0, 1, 0, 0, 0 
		//without additional array
		public int MaxDistToClosest(int[] seats)
		{
			var n = seats.Length;
			var distance = 0;
			var max = 1;

			for (int i = 0; i < n; i++)
			{
				if (seats[i] == 1)
				{
					seats[i] = 0;
					distance = 1;
				}
				else if (distance == 0)
				{
					seats[i] = int.MaxValue;
				}
				else
				{
					seats[i] = distance;
					++distance;
				}
			}

			distance = 0;
			for (int i = n - 1; i >= 0; i--)
			{
				if (seats[i] == 0)
				{
					distance = 1;
				}
				else if (distance != 0 && seats[i] > distance)
				{
					seats[i] = distance;
					++distance;
				}

				max = Math.Max(max, seats[i]);
			}

			return max;
		}

		//with 1 additional array
		public int MaxDistToClosest2(int[] seats)
		{
			var n = seats.Length;
			var distance = 0;
			var distances = new int[n];
			var max = 1;

			for (int i = 0; i < n; i++)
			{
				if (seats[i] == 1)
				{
					distances[i] = 0;
					distance = 1;
				}
				else if (distance == 0)
				{
					distances[i] = int.MaxValue;
				}
				else
				{
					distances[i] = distance;
					++distance;
				}
			}

			distance = 0;
			for (int i = n - 1; i >= 0; i--)
			{
				if (distances[i] == 0)
				{
					distance = 1;
				}
				else if(distance != 0 && distances[i] > distance)
				{
					distances[i] = distance;
					++distance;
				}

				max = Math.Max(max, distances[i]);
			}

			return max;
		}

		//with 2 additional arrays
		public int MaxDistToClosest1(int[] seats)
		{
			var n = seats.Length;
			var distance = 0;

			var distanceFromLeft = new int[n];
			var distanceFromRight = new int[n];

			var foundOne = false;
			for (int i = 0; i < n; i++)
			{
				if (seats[i] == 1)
				{
					distanceFromLeft[i] = 0;
					distance = 0;
					foundOne = true;
				}
				else if (foundOne == false)
				{
					distanceFromLeft[i] = int.MaxValue;
				}
				else
				{
					++distance;
					distanceFromLeft[i] = distance;
				}
			}

			distance = 0;
			foundOne = false;
			for (int i = n-1; i >= 0; i--)
			{
				if (seats[i] == 1)
				{
					distanceFromRight[i] = 0;
					distance = 0;
					foundOne = true;
				}
				else if (foundOne == false)
				{
					distanceFromRight[i] = int.MaxValue;
				}
				else
				{
					++distance;
					distanceFromRight[i] = distance;
				}
			}

			var max = 1;
			for (int i = 0; i < n; i++)
			{
				if (distanceFromLeft[i] > max && distanceFromRight[i] > max)
				{
					max = Math.Min(distanceFromLeft[i], distanceFromRight[i]);
				}
			}
			return max;
		}

		public void Test()
		{
			Console.WriteLine(MaxDistToClosest(new int[] { 1, 0, 0, 0, 1, 0, 1 }));
			Console.WriteLine(MaxDistToClosest(new int[] { 1, 0, 0, 0 }));
			Console.WriteLine(MaxDistToClosest(new int[] { 0, 1 }));
			Console.WriteLine(MaxDistToClosest(new int[] { 0, 0, 1, 0, 0, 0 }));
		}
	}
}
