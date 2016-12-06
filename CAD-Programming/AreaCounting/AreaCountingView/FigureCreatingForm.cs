using System;
using System.Windows.Forms;
using System.Drawing;
using AreaCounting;

namespace AreaCountingView
{
	public partial class FigureCreatingForm : Form
	{
		private AreaCountingForm _mainForm;
		private DataGridView _parentDataGrid;

		public FigureCreatingForm(AreaCountingForm ParentsForm, DataGridView ParentsDataGrid)
		{
			InitializeComponent();

			this._mainForm = ParentsForm;
			this._parentDataGrid = ParentsDataGrid;
		}

		/// <summary>
		/// Add object in Grid Control
		/// </summary>
		/// <param name="sender"></param>
		private void AddObjectInGridButton_Click(object sender, EventArgs e)
		{
			var validator = new NumberValidator();
			var validateUpTextBox = validator.Validate(FigureUpTextBox.Text);
			var validateDownTextBox = validator.Validate(FigureDownTextBox.Text);

			switch ((Figures)FigureComboBox.SelectedIndex)
			{
				case Figures.Circle:
					if (validateUpTextBox)
					{
						var radius = Convert.ToDouble(Tools.ReplaceDotsByCommas(FigureUpTextBox.Text));
						var circle = new Circle(radius);
						_parentDataGrid.Rows.Add();
						_parentDataGrid["FigureName", _parentDataGrid.Rows.Count - 1].Value = "Circle";
						_parentDataGrid["FigureArea", _parentDataGrid.Rows.Count - 1].Value = circle.CountArea();
					}
					else
					{
						var errors = new string[1] { "" };
						if (!validateUpTextBox) errors[0] = "Circle radius";
						ShowErrorMessage(errors);
					}
					break;
				case Figures.Rectangle:
					if (validateUpTextBox && validateDownTextBox)
					{
						var rectangleWidth = Convert.ToDouble(Tools.ReplaceDotsByCommas(FigureUpTextBox.Text));
						var rectangleHeight = Convert.ToDouble(Tools.ReplaceDotsByCommas(FigureDownTextBox.Text));
						var rectangle = new AreaCounting.Rectangle(rectangleWidth, rectangleHeight);
						_parentDataGrid.Rows.Add();
						_parentDataGrid["FigureName", _parentDataGrid.Rows.Count - 1].Value = "Rectangle";
						_parentDataGrid["FigureArea", _parentDataGrid.Rows.Count - 1].Value = rectangle.CountArea();
					}
					else
					{
						var errors = new string[2] {"", ""};
						if (!validateUpTextBox) errors[0] = "Rectangle width";
						if (!validateDownTextBox) errors[1] = "Rectangle height";
						ShowErrorMessage(errors);
					}
					break;
				case Figures.Triangle:
					if (validateUpTextBox && validateDownTextBox)
					{
						var triangleBase = Convert.ToDouble(Tools.ReplaceDotsByCommas(FigureUpTextBox.Text));
						var triangleHeight = Convert.ToDouble(Tools.ReplaceDotsByCommas(FigureDownTextBox.Text));
						var triangle = new AreaCounting.Rectangle(triangleBase, triangleHeight);
						_parentDataGrid.Rows.Add();
						_parentDataGrid["FigureName", _parentDataGrid.Rows.Count - 1].Value = "Triangle";
						_parentDataGrid["FigureArea", _parentDataGrid.Rows.Count - 1].Value = triangle.CountArea();
					}
					else
					{
						var errors = new string[2] {"", ""};
						if (!validateUpTextBox) errors[0] = "Triangle base";
						if (!validateDownTextBox) errors[1] = "Triangle height";
						ShowErrorMessage(errors);
					}
					break;
			}

		}

		/// <summary>
		/// Generates error message for user input errors if we have errors, in other case returns nothing
		/// </summary>
		/// <param name="errors"></param>
		/// <returns></returns>
		private void ShowErrorMessage(string[] errors)
		{
			var errorMessage = "Some values you entered are invalid. Check him:" + Environment.NewLine;
			int errorsCount = 0;

            foreach (string error in errors)
			{
				if (error == "") continue;
				errorMessage += "— " + error + " is invalid" + Environment.NewLine;
				errorsCount++;
			}

			if (errorsCount == 0) return;

			MessageBox.Show(errorMessage, "Errors during user input");
		}
		
		/// <summary>
		/// Make visible needed labels and textboxes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FigureComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ResetVisibility();

			switch ((Figures)FigureComboBox.SelectedIndex)
			{
				case Figures.Circle:
					FigureUpTextBox.Visible = true;
					FigureUpLabel.Visible = true;
					FigureUpLabel.Text = "Circle radius:";
					break;
				case Figures.Rectangle:
					FigureUpTextBox.Visible = true;
					FigureUpLabel.Visible = true;
					FigureDownTextBox.Visible = true;
					FigureDownLabel.Visible = true;

					FigureUpLabel.Text = "Rectangle width:";
					FigureDownLabel.Text = "Rectangle height:";
					break;
				case Figures.Triangle:
					FigureUpTextBox.Visible = true;
					FigureUpLabel.Visible = true;
					FigureDownTextBox.Visible = true;
					FigureDownLabel.Visible = true;

					FigureUpLabel.Text = "Triangle base:";
					FigureDownLabel.Text = "Triengle height:";
					break;
			}
		}

		/// <summary>
		/// Resets visibility
		/// </summary>
		private void ResetVisibility()
		{
			// Ну тут мы, допустим, чё-то там исправили да
			FigureUpTextBox.Visible = true; /*Ну и всё поломалось*/
			FigureUpLabel.Visible = false;
			FigureDownTextBox.Visible = false;
			FigureDownLabel.Visible = false;

			FigureUpLabel.Text = "Up Label";
			FigureDownLabel.Text = "Down Label";
		}

		/// <summary>
		/// Cancel button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Calling main form public hanler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckNumberKeyPressed(object sender, KeyPressEventArgs e)
		{
			_mainForm.CheckNumberKeyPressed(sender, e);
        }
	}
}
