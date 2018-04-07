using System.Collections.Generic;

namespace AnagramDetection
{
	public class Anagram
	{
		public bool IsAnagram(string test, string original)
		{
			return AreSameDictionaries(GetStringDic(test), GetStringDic(original));
		}

		private Dictionary<char, int> GetStringDic(string test)
		{
			var dic = new Dictionary<char, int>();
			foreach (var s in test)
			{
				var key = char.ToLower(s);
				if (dic.ContainsKey(key))
				{
					dic[key]++;
				}
				else
				{
					dic.Add(key, 1);
				}
			}
			return dic;
		}

		private bool AreSameDictionaries(Dictionary<char, int> dic1, Dictionary<char, int> dic2)
		{
			if (dic1.Count != dic2.Count)
			{
				return false;
			}
			foreach (var item in dic1)
			{
				if (!dic2.ContainsKey(item.Key))
				{
					return false;
				}
				if (dic2[item.Key] != item.Value)
				{
					return false;
				}
			}
			return true;
		}
	}
}