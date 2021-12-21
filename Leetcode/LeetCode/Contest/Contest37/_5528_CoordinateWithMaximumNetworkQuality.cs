using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Contest.Contest37
{
	public class _5528_CoordinateWithMaximumNetworkQuality
	{
		public int[] BestCoordinate(int[][] towers, int radius)
		{
			var len = towers.Length;
			var arr = new double[len];

			for (int i = 0; i < len; i++)
			{
				var totalQuality = 0;
				for (int j = 0; j < len; j++)
				{
					//d=sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2))
					var d = Math.Sqrt((towers[j][0] - towers[i][0]) * (towers[j][0] - towers[i][0]) 
						+ (towers[j][1] - towers[i][1]) * (towers[j][1] - towers[i][1]));
					if (d <= radius)
					{
						totalQuality += (int)Math.Floor(towers[j][2]/(1+d));
					}
				}
				arr[i] = totalQuality;
			}

			var max = arr.Max();
			var list = new List<int[]>();
			for (int i = 0; i < len; i++)
			{
				if (arr[i] == max)
				{
					var position = new int[] { towers[i][0], towers[i][1] };
					list.Add(position);
				}
			}

			if (list.Count>1)
			{
				list = list.OrderBy(x=>x[0]).ThenBy(x => x[1]).ToList();
			}

			return list.First();
		}

		public void Test()
		{
			//Input: towers = [[1,2,5],[2,1,7],[3,1,9]], radius = 2
			//Output: [2, 1]

			//var towers = new int[][] {
			//	new int[] { 1,2,5 },
			//	new int[] { 2,1,7 },
			//	new int[] { 3, 1, 9 }
			//};

			//Console.WriteLine(string.Join(',', BestCoordinate(towers, 2)));

			//[31,13,33],[24,45,38],[28,32,23],[7,23,22],[41,50,33],[47,21,3],[3,33,39],[11,38,5],[26,20,28],[48,39,16],[34,29,25], 21
			//[24,45]

			var towers = new int[][] {
				new int[] { 31,13,33},
				new int[] { 24,45,38 },
				new int[] { 28, 32, 23 },
				new int[] { 7,23,22 },
				new int[] { 41,50,33 },
				new int[] { 47,21,3 },
				new int[] { 3, 33, 39 } ,
				new int[] { 11,38,5 },
				new int[] { 26,20,28 },
				new int[] { 48,39,16 },
				new int[] { 34,29,25 }

			};

			Console.WriteLine(string.Join(',', BestCoordinate(towers, 21)));
		}
	}
}
