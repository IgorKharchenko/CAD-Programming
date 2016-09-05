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
			if (validator.Validate(arguments))
			{
				Circle circle = new Circle(arguments);
				ShowAnswer(circle.countArea());
			}
		}

		private void rectangleAreaButton_Click(object sender, EventArgs e)
		{
			string[] arguments = Tools.replaceDotsByCommas(new string[] { rectangleWidth.Text, rectangleHeight.Text });

			NumberValidator validator = new NumberValidator();
			if (validator.Validate(arguments))
			{
				Rectangle rect = new Rectangle(arguments);
				ShowAnswer(rect.countArea());
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
				angleValidator.Validate(new string[] { SATriangleAngle.Text });

				mode = "Side + Angle";
			}
			else if (index == 2)
			{
				arguments = Tools.replaceDotsByCommas(new string[] {
					InnerTriangleSideA.Text,
					InnerTriangleSideB.Text,
					InnerTriangleSideC.Text,
					InnerTriangleRadius.Text
				});

				mode = "Sides + Inner circle";
			}
			else if (index == 3)
			{
				arguments = Tools.replaceDotsByCommas(new string[] {
					OuterTriangleSideA.Text,
					OuterTriangleSideB.Text,
					OuterTriangleSideC.Text,
					OuterTriangleRadius.Text
				});

				mode = "Sides + Outer circle";
			}
			else if (index == 4)
			{
				arguments = Tools.replaceDotsByCommas(new string[] {
					SidesTriangleSideA.Text,
					SidesTriangleSideB.Text,
					SidesTriangleSideC.Text
				});

				mode = "Three sides";
			}

			NumberValidator validator = new NumberValidator();
			if (validator.Validate(arguments))
			{
				Triangle triangle = new Triangle(arguments, mode);
				ShowAnswer(triangle.countArea());
			}
		}

		private void ShowAnswer(double answer)
		{
			MessageBox.Show("Площадь равна " + answer, "Ответ", MessageBoxButtons.OK);
		}

		/* Unneccessary and undeletable methods */

		private void regExprCheckButotn_Click(object sender, EventArgs e)
		{

		}
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
		private void OuterCircleTrianglePage_Click(object sender, EventArgs e)
		{

		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void SidesTriangleSideB_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
