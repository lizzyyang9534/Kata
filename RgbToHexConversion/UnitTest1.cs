using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RgbToHexConversion
{
	[TestClass]
	public class UnitTest1
	{
		ColorConverter colorConverter = new ColorConverter();

		[TestMethod]
		public void ExceedMaximumValue()
		{
			Assert.AreEqual("FFFFFF", colorConverter.Rgb(255, 255, 300));
		}

		[TestMethod]
		public void ContainsNegativeValue()
		{
			Assert.AreEqual("9400D3", colorConverter.Rgb(148, -20, 211));
		}

		[TestMethod]
		public void White()
		{
			Assert.AreEqual("FFFFFF", colorConverter.Rgb(255, 255, 255));
		}

		[TestMethod]
		public void Black()
		{
			Assert.AreEqual("000000", colorConverter.Rgb(0, 0, 0));
		}

		[TestMethod]
		public void AnotherColor()
		{
			Assert.AreEqual("9400D3", colorConverter.Rgb(148, 0, 211));
			Assert.AreEqual("90C3D4", colorConverter.Rgb(144, 195, 212));
		}

		[TestMethod]
		public void SingleHexDigitNumber()
		{
			Assert.AreEqual("D4350C", colorConverter.Rgb(212, 53, 12));
		}
	}
}
