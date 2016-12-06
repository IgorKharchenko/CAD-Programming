using System;
using System.Collections.Generic;

namespace AreaCounting
{
	public class AngleValidator : NumberValidator
	{
		public bool Validate(string input)
		{
			base.Validate(input);

			try
			{
				if (Convert.ToDouble(input) <= 0.0 && Convert.ToDouble(input) >= 360.0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			catch(Exception)
			{
				throw new Exception(" Невозможно конвертировать значение в формат Double");
			}
		}
	}
}
