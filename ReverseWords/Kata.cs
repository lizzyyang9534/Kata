using System;
using System.Linq;

namespace ReverseWords
{
	public class Kata
	{
		public string ReverseWords(string str)
		{
			var words = str.Split(' ');
			var reversedStr = words.Select(x => ReverseString(x));
			return string.Join(" ", reversedStr);
		}

		private string ReverseString(string str)
		{
			var arr = str.ToCharArray();
			return string.Join("", arr.Reverse());
		}
	}
}