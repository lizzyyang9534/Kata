using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestSum
{
	public class Calculator
	{
		public int LargestSum(int[] arr)
		{
			if (arr.Any(x => x < 0))
			{
				return 0;
			}
			return arr.Sum(x => x);
		}
	}
}