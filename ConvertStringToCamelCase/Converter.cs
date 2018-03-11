using System.Linq;

namespace ConvertStringToCamelCase
{
	public class Converter
	{
		public static string ToCamelCase(string input)
		{
			return string.Concat(input.Split('-', '_').Select((x, i) => x = i > 0 ? ToUpperCamelCase(x) : x));
		}

		private static string ToUpperCamelCase(string input)
		{
			return string.Concat(char.ToUpper(input.First()), input.Substring(1));
		}
	}
}
