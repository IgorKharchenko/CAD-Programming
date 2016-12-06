using System;
using System.Text.RegularExpressions;

namespace AreaCounting
{
	public class NumberValidator : IValidator
	{
		public bool Validate(string input)
		{
			// All numbers with commas are available
			string pattern = @"^(\d+|\d*\,\d+)$";
			Regex regex = new Regex(pattern);

			
			if (!regex.IsMatch(input) || input == String.Empty)
			{
				return false;
			}

			return true;
		}
	}

}
