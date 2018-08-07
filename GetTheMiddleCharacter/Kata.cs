namespace GetTheMiddleCharacter
{
	public class Kata
	{
		public static string GetMiddle(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}
			return s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s.Substring(s.Length / 2, 1);
		}
	}
}