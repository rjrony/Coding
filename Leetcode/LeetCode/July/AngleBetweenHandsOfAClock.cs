using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.July
{
	public class AngleBetweenHandsOfAClock
	{
		public double AngleClock(int hour, int minutes)
		{
			const int TotalAngle = 360;
			const int HourAngle = 30; // 360/12
			const int MinuteAngle = 6; // 360/60

			var hourAngles = 1.0 * HourAngle * (hour % 12) + 1.0 * HourAngle * minutes / 60;
			var minuteAngles = 1.0 * MinuteAngle * minutes;

			double angle1;
			double angle2;
			if (hourAngles > minuteAngles)
			{
				angle1 = hourAngles - minuteAngles;
				angle2 = TotalAngle + minuteAngles - hourAngles;
			}
			else
			{
				angle1 = minuteAngles - hourAngles;
				angle2 = TotalAngle + hourAngles - minuteAngles;
			}

			return Math.Min(angle1, angle2);
		}
	}
}
