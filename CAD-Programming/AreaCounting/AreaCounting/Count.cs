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

		public Circle()
		{
			throw new ArgumentNullException("Circle constructor: не заданы входные аргументы для конструктора");
		}
		
		public Circle(string[] radius)
		{
			this.radius = Convert.ToDouble(radius[0]);
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

		public Rectangle()
		{
			throw new ArgumentNullException("Rectangle constructor: не заданы входные аргументы для конструктора");
		}

		public Rectangle(string[] arguments)
		{
			this.width = Convert.ToDouble(arguments[0]);
			this.height = Convert.ToDouble(arguments[1]);
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

		public Triangle()
		{
			throw new ArgumentNullException("Triangle constructor: не заданы входные аргументы для конструктора");
		}

		public Triangle(string[] arguments, string mode)
		{
			switch (mode)
			{
				case "Base + Height":
					this.a = Convert.ToDouble(arguments[0]);
					this.height = Convert.ToDouble(arguments[1]);
					break;
				case "Side + Angle":
					this.a = Convert.ToDouble(arguments[0]);
					this.b = Convert.ToDouble(arguments[1]);
					this.alpha = Convert.ToDouble(arguments[2]);
					break;
				case "Sides + Inner circle":
					this.a = Convert.ToDouble(arguments[0]);
					this.b = Convert.ToDouble(arguments[1]);
					this.c = Convert.ToDouble(arguments[2]);
					this.radius = Convert.ToDouble(arguments[3]);
					break;
				default:
					throw new ArgumentNullException("Triangle constructor: режим расчёта площади треугольника не задан.");
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

	public class Tools
	{
		public static string[] replaceDotsByCommas(string[] input)
		{
			/* Поддерживаются числа: 12,34; 0,12; ,12
			Конвертируются в число с плавающей запятой: 12.34; 0.12; .12 */
			string pattern = @"^(?<exponent>\d*)(\.|\,)(?<mantissa>\d+)$";
			string replacePattern = @"${exponent},${mantissa}";
			Regex regex = new Regex(pattern);

			for (int i = 0, length = input.Length; i < length; i++)
			{
				input[i] = Regex.Replace(input[i], pattern, replacePattern);
			}

			return input;
		}
	}

	public interface IValidator
	{
		bool validate(string[] input);
	}

	public class NumberValidator : IValidator
	{
		public NumberValidator() { }

		public bool validate(string[] input)
		{
			/* Поддерживаются числа: 12,34; 0,12; ,12 */
			string pattern = @"^(\d+|\d*\,\d+)$";
			Regex regex = new Regex(pattern);
			
			foreach (string element in input)
			{
				if (!regex.IsMatch(element) || element == String.Empty)
				{
					throw new ArgumentException("Ошибка при вводе числа с запятой.");
				}
			}

			return true;
		}
	}

	public class AngleValidator : NumberValidator
	{
		public AngleValidator() { }
		
		public bool validate(string[] input)
		{
			base.validate(input);

			foreach (string element in input)
			{
				double angle = Convert.ToDouble(element);

				if (angle <= 0.0 && angle >= 360.0)
				{
					throw new ArgumentException("Угол не может быть меньше 0 и больше 360 градусов.");
				}
			}

			return true;
		}
	}
}
