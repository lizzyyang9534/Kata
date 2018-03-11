using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertStringToCamelCase
{
	[TestClass]
	public class ConverterTest
	{
		[TestMethod]
		public void EmptyString()
		{
			Assert.AreEqual("", Converter.ToCamelCase(""));
		}

		[TestMethod]
		public void InvalidSymbol()
		{
			Assert.AreEqual("the*stealth/warrior", Converter.ToCamelCase("the*stealth/warrior"));
		}

		[TestMethod]
		public void ContainsDashAndUnderscore()
		{
			Assert.AreEqual("theStealthWarrior", Converter.ToCamelCase("the-stealth_warrior"));
		}

		[TestMethod]
		public void LowerCamelStringWithUnderscore()
		{
			Assert.AreEqual("theStealthWarrior", Converter.ToCamelCase("the_stealth_warrior"));
		}

		[TestMethod]
		public void UpperCamelStringWithUnderscore()
		{
			Assert.AreEqual("TheStealthWarrior", Converter.ToCamelCase("The_stealth_warrior"));
		}

		[TestMethod]
		public void LowerCamelStringWithDash()
		{
			Assert.AreEqual("theStealthWarrior", Converter.ToCamelCase("the-Stealth-Warrior"));
		}

		[TestMethod]
		public void UpperCamelStringWithDash()
		{
			Assert.AreEqual("TheStealthWarrior", Converter.ToCamelCase("The-Stealth-Warrior"));
		}
	}
}
