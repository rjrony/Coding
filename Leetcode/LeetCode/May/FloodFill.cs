using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class FloodFill_
	{
		public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
		{
			Fill(image, sr, sc, image[sr][sc], newColor);
			return image;
		}

		public void Fill(int[][] image, int sr, int sc, int oldColor, int newColor)
		{

			if ((image.Length-1 < sr || 0 > sr) 
				|| (image[0].Length-1 < sc || 0 > sc) 
				|| image[sr][sc] != oldColor)
			{
				return;
			}
			image[sr][sc] = newColor;
			Fill(image, sr + 1, sc, oldColor, newColor);
			Fill(image, sr - 1, sc, oldColor, newColor);
			Fill(image, sr, sc + 1, oldColor, newColor);
			Fill(image, sr, sc - 1, oldColor, newColor);
		}
	}
}
