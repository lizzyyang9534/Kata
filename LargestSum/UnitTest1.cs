using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace LargestSum
{
	[TestFixture]
	public class LargestSumTest
	{
		[TestCase(new[] { -1, -2, -3 }, 0)]
		[TestCase(new int[0], 0)]
		[TestCase(new[] { 1, 2, 3, 4 }, 10)]
		[TestCase(new[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 }, 187)]
		public void TestFromDescription(int[] arr, int result)
		{
			var calculator = new Calculator();
			NUnit.Framework.Assert.AreEqual(calculator.LargestSum(arr), result);
		}
	}
}
