using System;
using NUnit.Framework;

namespace ReverseWords
{
	[TestFixture]
	public class ReverseWordsTest
	{
		[Test]
		public void Sentence()
		{
			var kata = new Kata();
			Assert.AreEqual("sihT si na !elpmaxe", kata.ReverseWords("This is an example!"));
		}

		[Test]
		public void Alphabet()
		{
			var kata = new Kata();
			Assert.AreEqual("T", kata.ReverseWords("T"));
		}

		[Test]
		public void Empty()
		{
			var kata = new Kata();
			Assert.AreEqual("", kata.ReverseWords(""));
		}
	}
}
