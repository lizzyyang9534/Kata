using NUnit.Framework;

namespace SortTheOdd
{
	[TestFixture]
	public class SortTheOddTest
	{
		[Test]
		public void BasicTests()
		{
			var sort = new SortTheOdd();
			Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, sort.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
		}

		[Test]
		public void ContainsZero()
		{
			var sort = new SortTheOdd();
			Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, sort.SortArray(new int[] { 5, 3, 1, 8, 0 }));
		}

		[Test]
		public void Empty()
		{
			var sort = new SortTheOdd();
			Assert.AreEqual(new int[] { }, sort.SortArray(new int[] { }));
		}
	}
}
