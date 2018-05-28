using System;
using System.Collections.Generic;
using System.Linq;

namespace HighestRank
{
	public class Kata
	{
		public static int HighestRank(int[] arr)
		{
			var dic = new Dictionary<int, int>();
			foreach (var num in arr)
			{
				if (dic.ContainsKey(num))
				{
					dic[num]++;
				}
				else
				{
					dic.Add(num, 1);
				}
			}
			return dic.Where(x => x.Value == dic.Max(y => y.Value)).Max(z => z.Key);
		}
	}
}