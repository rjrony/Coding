using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _799_ChampagneTower
	{
		public double ChampagneTower(int poured, int query_row, int query_glass)
		{
			var tower = new double[101, 101];
			tower[0, 0] = poured;
			for (int i = 0; i < query_row; i++)
			{
				for (int j = 0; j < i+1; j++)
				{
					if (tower[i,j] >= 1) {
						var pass = tower[i, j] - 1;
						tower[i, j] = 1;
						tower[i + 1, j] += 1.0 * pass / 2;
						tower[i + 1, j + 1] += 1.0 * pass / 2;
					}
				}
			}

			return Math.Min(1,tower[query_row,query_glass]);
		}

		//wrong approach: try to solve as a easy math problem
		public double ChampagneTower2(int poured, int query_row, int query_glass)
		{
			if (poured < 2 && query_row > 0) return 0.0;
			int totalGlassUptoRow = (query_row + 1) * (query_row + 2) / 2;
			if (poured >= totalGlassUptoRow)
			{
				return 1.0;
			}

			int totalGlassUptoAboveRow = query_row * (query_row + 1) / 2;
			if (poured > totalGlassUptoAboveRow)
			{
				int excess = poured - totalGlassUptoAboveRow;
				double fallPerSide = excess*1.0 / (query_row);
				return (query_glass == 0 || query_glass == query_row) ? fallPerSide/2 : fallPerSide;
			}

			return 0.0;
		}
	}
}
