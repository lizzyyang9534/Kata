using System.Linq;

namespace RgbToHexConversion
{
	public class ColorConverter
	{
		public string Rgb(int r, int g, int b)
		{
			return string.Join("", new[] { r, g, b }.Select(x => Clamp(x, 0, 255).ToString("X2")));
		}

		public int Clamp(int value, int min, int max)
		{
			return (value < min) ? min : (value > max) ? max : value;
		}
	}
}