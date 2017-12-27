using System.Linq;

namespace Kata
{
    public class MoveZero
    {
        public static int[] MoveZeroes(int[] input)
        {
            var formatedInput = input.Where(x => x != 0).ToList();
            formatedInput.AddRange(Enumerable.Repeat(0, input.Length - formatedInput.Count));

            return formatedInput.ToArray();
        }
    }
}
