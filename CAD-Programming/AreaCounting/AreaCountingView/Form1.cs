using System;
using System.Windows.Forms;
using AreaCounting;
using System.Text.RegularExpressions;

namespace AreaCountingView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void circleAreaButton_Click(object sender, EventArgs e)
		{
			string[] arguments = Tools.replaceDotsByCommas(new string[] { circleRadius.Text });

			NumberValidator validator = new NumberValidator();
			if (validator.validate(arguments))
			{
				Circle circle = new Circle(arguments);
				showAnswer(circle.countArea());
			}
		}

		private void rectangleAreaButton_Click(object sender, EventArgs e)
		{
			string[] arguments = Tools.replaceDotsByCommas(new string[] { rectangleWidth.Text, rectangleHeight.Text });

			NumberValidator validator = new NumberValidator();
			if (validator.validate(arguments))
			{
				Rectangle rect = new Rectangle(arguments);
				showAnswer(rect.countArea());
			}
		}

		private void triangleAreaButton_Click(object sender, EventArgs e)
		{
			string[] arguments = new string[] { };
			string mode = "";

			int index = triangleTabControl.SelectedIndex;
            if (index == 0)
			{
				arguments = Tools.replaceDotsByCommas(new string[] {
					BHTriangleBase.Text,
					BHTriangleHeight.Text
				});

				mode = "Base + Height";
			}
			else if (index == 1)
			{
				arguments = Tools.replaceDotsByCommas(new string[] {
					SATriangleSideA.Text,
					SATriangleSideB.Text,
					SATriangleAngle.Text
				});

				AngleValidator angleValidator = new AngleValidator();
				angleValidator.validate(new string[] { SATriangleAngle.Text });

				mode = "Side + Angle";
			}
			else if (index == 2)
			{
				arguments = Tools.replaceDotsByCommas(new string[] {
					SSSTriangleSideA.Text,
					SSSTriangleSideB.Text,
					SSSTriangleSideC.Text,
					SSSTriangleRadius.Text
				});

				mode = "Sides + Inner circle";
			}

			NumberValidator validator = new NumberValidator();
			if (validator.validate(arguments))
			{
				Triangle triangle = new Triangle(arguments, mode);
				showAnswer(triangle.countArea());
			}
		}

		private void showAnswer(double answer)
		{
			MessageBox.Show("Площадь равна " + answer, "Ответ");
		}

		/* Unneccessary methods */

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void SATriangleSideA_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void SATriangleSideB_Click(object sender, EventArgs e)
		{

		}

		private void SATriangleAngle_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void SATrianglePage_Click(object sender, EventArgs e)
		{

		}

		private void SSSTrianglePage_Click(object sender, EventArgs e)
		{

		}

		private void regExprCheckButotn_Click(object sender, EventArgs e)
		{
			string pattern = @"^(\d+|(?<exponent>\d*)(\.|\,)(?<mantissa>\d+))$";
			string replacePattern = @"${exponent},${mantissa}";
			Regex regex = new Regex(pattern);

			string result = Regex.Replace(circleRadius.Text, pattern, replacePattern);
			Console.WriteLine("Результат: {0}", result);
		}
	}
}
