using System;
using System.Windows.Forms;
using AreaCounting;

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
			Circle circle = new Circle(circleRadius.Text);
			showAnswer(circle.countArea());
		}

		private void rectangleAreaButton_Click(object sender, EventArgs e)
		{
			Rectangle rectangle = new Rectangle(rectangleWidth.Text, rectangleHeight.Text);
			showAnswer(rectangle.countArea());
		}

		private void triangleAreaButton_Click(object sender, EventArgs e)
		{
			int index = triangleTabControl.SelectedIndex;
            if (index == 0)
			{
				Triangle triangle = new Triangle(BHTriangleBase.Text, BHTriangleHeight.Text);
				showAnswer(triangle.countArea());
			}
			else if (index == 1)
			{
				Triangle triangle = new Triangle(SATriangleSideA.Text, SATriangleSideB.Text, SATriangleAngle.Text);
				showAnswer(triangle.countArea());
			}
			else if (index == 2)
			{
				Triangle triangle = new Triangle(SSSTriangleSideA.Text, SSSTriangleSideB.Text, SSSTriangleSideC.Text, SSSTriangleRadius.Text);
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
	}
}
