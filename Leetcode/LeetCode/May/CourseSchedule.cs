using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class CourseSchedule
	{
		public bool CanFinish(int numCourses, int[][] prerequisites)
		{
			var matrix = new int[numCourses, numCourses];
			foreach (var item in prerequisites)
			{
				if (matrix[item[1], item[0]] == 1)
				{
					return false;
				}
				matrix[item[0], item[1]] = 1;
			}

			return true;
		}
	}
}
