using NUnit.Framework;

namespace CountingChangeCombinations
{
	[TestFixture]
	public class CoinTest
	{
		[Test]
		public static void SimpleCase()
		{
			var coin = new Coin();
			Assert.AreEqual(3, coin.CountCombinations(4, new[] { 1, 2 }));
		}

		[Test]
		public static void AnotherSimpleCase()
		{
			var coin = new Coin();
			Assert.AreEqual(4, coin.CountCombinations(10, new[] { 5, 2, 3 }));
		}

		[Test]
		public static void NoChange()
		{
			var coin = new Coin();
			Assert.AreEqual(0, coin.CountCombinations(11, new[] { 5, 7 }));
		}
	}
}
