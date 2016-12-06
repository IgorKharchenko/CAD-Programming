using System.Text.RegularExpressions;

namespace AreaCounting
{
	public class Tools
	{
		/// <summary>
		/// Try to convert all dots in commas in input string
		/// because strings with dots aren't supported by a method Convert.ToDouble()
		/// </summary>
		/// <param name="input">An input string with dots</param>
		/// <returns>A string where all dots are replaced by commas</returns>
		public static string ReplaceDotsByCommas(string input)
		{
			string pattern = @"^(?<exponent>\d*)(\.|\,)(?<mantissa>\d+)$";
			string replacePattern = @"${exponent},${mantissa}";
			Regex regex = new Regex(pattern);

			return Regex.Replace(input, pattern, replacePattern);
		}
	}
}
