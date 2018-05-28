using System;
using NUnit.Framework;

namespace HighestRank
{
	[TestFixture]
	public class KataTests
	{
		[Test]
		public void BasicTest()
		{
			var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
			Assert.AreEqual(12, Kata.HighestRank(arr));
		}

		[Test]
		public void TieTest()
		{
			var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 };
			Assert.AreEqual(12, Kata.HighestRank(arr));
		}
	}
}
