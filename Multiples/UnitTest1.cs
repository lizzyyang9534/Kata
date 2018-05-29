using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Multiples
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test()
		{
			Assert.AreEqual(23, Kata.Solution(10));
		}
	}
}
