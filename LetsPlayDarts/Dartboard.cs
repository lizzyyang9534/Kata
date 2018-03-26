using System;

namespace LetsPlayDarts
{
	public class Dartboard
	{
		public const double BullEye = 6.35;
		public const double Bull = 15.9;
		public const double TripleRingInner = 99;
		public const double TripleRingOuter = 107;
		public const double DoubleRingInner = 162;
		public const double DoubleRingOuter = 170;
		private int[] points = { 20, 1, 18, 4, 13, 6, 10, 15, 2, 17,
			3, 19, 7, 16, 8, 11, 14, 9, 12, 5 };

		public string GetScore(double x, double y)
		{
			double hypotenuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
			if (hypotenuse > DoubleRingOuter)
			{
				return "X";
			}
			if (hypotenuse <= BullEye)
			{
				return "DB";
			}
			if (hypotenuse > BullEye && hypotenuse <= Bull)
			{
				return "SB";
			}
			return "";
		}
	}
}