using System;
using NUnit.Framework;

namespace AnagramDetection
{
	[TestFixture]
	public class AnagramDetectionTest
	{
		[Test]
		[TestCase("foefet", "toffee", true)]
		[TestCase("Buckethead", "DeathCubeK", true)]
		[TestCase("Twoo", "Woot", true)]
		[TestCase("apple", "pale", false)]
		[TestCase("apple", "banana", false)]
		public void FixedTest(string str1, string str2, bool result)
		{
			Assert.AreEqual(result, new Anagram().IsAnagram(str1, str2));
		}
	}
}
