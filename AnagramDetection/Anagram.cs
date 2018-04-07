using System.Linq;

namespace AnagramDetection
{
	public class Anagram
	{
		public bool IsAnagram(string test, string original)
		{
			return GetFormatedString(test) == GetFormatedString(original);
		}

		private string GetFormatedString(string input)
		{
			var str = input.ToLower().ToList();
			str.Sort();
			return string.Concat(str);
		}
	}
}