using System;
using AreaCounting;
using System.Collections.Generic;

namespace AreaCountingConsoleView
{
	class Program
	{
		public enum CountOptions { Circle, Rectangle, Triangle, Quit };

		static void Main()
		{
			bool repeat = true;

			do
			{
				MainMenu();
				CountOptions OptionNumber = TryReadOption();

				Console.Clear();
				Console.WriteLine(" === Расчёт площади фигуры === \n");

				switch (OptionNumber)
				{
					case CountOptions.Circle:
						Console.Write(" Введите радиус круга: ");
						var radius = TryReadDouble();
                        var circle = new Circle(radius);

						PrintAnswer(circle.CountArea());
						ReturnToMainMenu();
						break;
					case CountOptions.Rectangle:
						Console.Write(" Введите длину прямоугольника: ");
						var width = TryReadDouble();
						Console.Write(" Введите ширину прямоугольника: ");
						var height = TryReadDouble();
						var rectangle = new Rectangle(width, height);

						PrintAnswer(rectangle.CountArea());
						ReturnToMainMenu();
						break;
					case CountOptions.Triangle:
						Console.Write(" Введите основание треугольника: ");
						var triangleBase = TryReadDouble();
                        Console.Write(" Введите высоту треугольника: ");
						var triangleHeight = TryReadDouble();

						var triangle = new Triangle(triangleBase, triangleHeight);

						PrintAnswer(triangle.CountArea());
						
						ReturnToMainMenu();
						break;
					case CountOptions.Quit:
						repeat = false;
						break;
				}
			} while (repeat); 

		}
		
		/// <summary>
		/// Tries to read a number of type 'double' from standard input stream with replacing dots by commas, otherwise catches an argument exception
		/// </summary>
		static double TryReadDouble()
		{
			while (true)
			{
				try
				{
					double output = Convert.ToDouble(Tools.ReplaceDotsByCommas(Console.ReadLine()));
					return output;
				}
				catch (FormatException)
				{
					Console.Write(" Неверный формат ввода. Пожалуйста, повторите ввод: ");
				}
			}
		}

		/// <summary>
		/// Validates an angle, he must be from 0 to 360 degrees
		/// </summary>
		/// <param name="angle">An angle</param>
		/// <returns>true if an angle is in [0; 360] </returns>
		static double TryReadAngle()
		{
			while (true)
			{
				try
				{
					double angle = Convert.ToDouble(Console.ReadLine());
					if (angle >= 0.0 && angle <= 360.0)
					{
						return angle;
					}
					else
					{
						Console.Write(" Угол должен быть от 0 до 360 градусов. Пожалуйста, повторите ввод: ");
					}
				}
				catch (Exception)
				{
					Console.Write("Неверный формат ввода. Пожалуйста, повторите ввод: ");
				}
			}
		}

		/// <summary>
		/// Prints an answer of counting to standard output stream
		/// </summary>
		/// <param name="answer">An answer</param>
		static void PrintAnswer(double answer)
		{
			Console.WriteLine("\n Площадь равна {0:0.00}", answer);
		}

		/// <summary>
		/// Tries to read an option from standard input stream which number exists in array with option numbers
		/// </summary>
		/// <returns>A correct option number</returns>
		static CountOptions TryReadOption()
		{
			while (true)
			{
				try
				{
					int optionNumber = Convert.ToInt32(Console.ReadLine());

					switch (optionNumber)
					{
						case 1:
							return CountOptions.Circle;
						case 2:
							return CountOptions.Rectangle;
						case 3:
							return CountOptions.Triangle;
						case 0:
							return CountOptions.Quit;
						default:
							Console.Write(" Неверная опция. Пожалуйста, повторите ввод: ");
							break;
					}
				}
				catch (FormatException)
				{
					Console.Write(" Неверный формат ввода. Пожалуйста, повторите ввод: ");
				}
			}
		}

		/// <summary>
		/// Represents a main menu of console application
		/// </summary>
		static void MainMenu()
		{
			Console.Clear();
			Console.WriteLine(" ===== Расчёт площади геометрических фигур =====\n");
			Console.WriteLine(" 1. Круг");
			Console.WriteLine(" 2. Прямоугольник");
			Console.WriteLine(" 3. Треугольник\n");
			Console.WriteLine(" 0. Выйти из программы \n");
			Console.Write(" Выберите нужную опцию: ");
		}

		/// <summary>
		/// Returns a user to main menu of console application
		/// </summary>
		static void ReturnToMainMenu()
		{
			Console.Write("\n Нажмите любую клавишу для возврата в главное меню. ");
			Console.ReadKey();
		}
	}
}
