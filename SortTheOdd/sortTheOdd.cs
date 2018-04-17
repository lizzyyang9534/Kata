using System.Collections.Generic;

namespace SortTheOdd
{
	public class SortTheOdd
	{
		public int[] SortArray(int[] numArray)
		{
			var oddNumbers = new List<int>();
			var indexes = new List<int>();
			for (int i = 0; i < numArray.Length; i++)
			{
				if (IsOdd(numArray[i]))
				{
					oddNumbers.Add(numArray[i]);
					indexes.Add(i);
				}
			}

			oddNumbers.Sort();

			for (int i = 0; i < oddNumbers.Count; i++)
			{
				numArray[indexes[i]] = oddNumbers[i];
			}

			return numArray;
		}

		private bool IsOdd(int i)
		{
			return i % 2 != 0;
		}
	}
}