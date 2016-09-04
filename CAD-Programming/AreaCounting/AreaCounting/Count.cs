using System;
using System.Text.RegularExpressions;

namespace AreaCounting
{
	public interface ICount
    {
		double countArea();
    }


    public class Circle : ICount
    {
		public double radius;
		
		public Circle(string radius)
		{
			NumberValidator validator = new NumberValidator();
			if (validator.validate(radius))
			{
				this.radius = Convert.ToDouble(radius);
            }
		}

		public double countArea()
		{
			return System.Math.PI * radius * radius;
		}
    }

	public class Rectangle : ICount
	{
		public double width;
		public double height;

		public Rectangle(string width, string height)
		{
			NumberValidator validator = new NumberValidator();
			if (validator.validate(width) && validator.validate(height))
			{
				this.width = Convert.ToDouble(width);
				this.height = Convert.ToDouble(height);
			}
		}

		public double countArea()
		{
			return width * height;
		}
	}

	public class Triangle : ICount
	{
		public double a;
		public double b;
		public double c;
		public double alpha;
		public double height;
		public double radius;

		public Triangle(string a, string height)
		{
			NumberValidator validator = new NumberValidator();
			if (validator.validate(a) && validator.validate(height))
			{
				this.a = Convert.ToDouble(a);
				this.height = Convert.ToDouble(height);
			}
		}

		public Triangle(string a, string b, string alpha)
		{
			NumberValidator numValidator = new NumberValidator();
			AngleValidator angleValidator = new AngleValidator();
			if (numValidator.validate(a) && numValidator.validate(b) && angleValidator.validate(alpha))
			{
				this.a = Convert.ToDouble(a);
				this.b = Convert.ToDouble(b);
				this.alpha = Convert.ToDouble(alpha);
			}
		}

		public Triangle(string a, string b, string c, string radius)
		{
			NumberValidator validator = new NumberValidator();
			if (validator.validate(a) &&
				validator.validate(b) && 
				validator.validate(c) &&
				validator.validate(radius))
			{
				this.a = Convert.ToDouble(a);
				this.b = Convert.ToDouble(b);
				this.c = Convert.ToDouble(c);
				this.radius = Convert.ToDouble(radius);
			}
		}

		public double countArea()
		{
			if (a != 0.0 && height != 0.0)
			{
                return (1.0 / 2.0) * a * height;
			}
			else if (a != 0.0 && b != 0.0 && alpha != 0.0)
			{
                return (1.0 / 2.0) * a * b * Math.Sin(alpha * (Math.PI / 180.0));
			}
			else if (a != 0.0 && b != 0.0 && c != 0.0 && radius != 0.0)
			{
				return radius * ((a + b + c) / 2.0);
			}

			return 0.0;
		}
	}

	public interface IValidator
	{
		bool validate(string input);
	}

	public class NumberValidator : IValidator
	{
		public bool validate(string input)
		{
			string pattern = @"^(\d+)?(\,\d+)?$"; // ,0357 / 58,19 and similar
			Regex regex = new Regex(pattern);

			// регулярное выражение почему-то пропускает пустые строки, поэтому вводим дополнительную проверку
			if (regex.IsMatch(input) && input != String.Empty) 
			{
				return true;
			}
			else
			{
				throw new ArgumentException("Ошибка при вводе числа с запятой.");
			}
		}
	}

	public class AngleValidator : IValidator
	{
		public bool validate(string input)
		{
			NumberValidator validator = new NumberValidator();
			validator.validate(input);

			double angle = Convert.ToDouble(input);

			if (angle >= 0.0 && angle <= 360.0)
			{
				return true;
			}

			throw new ArgumentException("Угол не может быть меньше 0 и больше 360 градусов.");
		}
	}
}
