using System;
using System.Data;
using System.Windows.Forms;

namespace AreaCountingView
{
	public partial class FindForm : Form
	{
		private AreaCountingForm _mainForm;
		private DataGridView _parentsDataGrid;
		
		public FindForm(AreaCountingForm ParentsForm, DataGridView ParentsDataGrid)
		{
			InitializeComponent();

			_mainForm = ParentsForm;
			_parentsDataGrid = ParentsDataGrid;
		}

		/// <summary>
		/// Find figure button click, checks parent data grid for needed field
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FindFigure_Click(object sender, EventArgs e)
		{
			/* 1. Clean all data in find result */
			_mainForm.CleanDataGrid(FindFigureDataGrid);

			/* 2. Set finded values */
			DataSet ds = new DataSet();			// Data cash
			DataTable dt = new DataTable();		// Data cash table
			dt.TableName = "FigureAreasFind";   // Data cash table name
			dt.Columns.Add("Figure");
			dt.Columns.Add("Area");
			ds.Tables.Add(dt);					// Add DataTable to DataSet

			/* 2.1 Search by name or by  in parent data grid */
			foreach (DataGridViewRow AreaGridRow in _parentsDataGrid.Rows)
			{
				string parentName = Convert.ToString(AreaGridRow.Cells[0].Value);
				double parentArea = Convert.ToDouble(AreaGridRow.Cells[1].Value);
				string findName = Convert.ToString(FigureName.Text);
				double findArea = 0.0;		// Default value is 0.0
				if (FigureArea.Text != "")
				{
					findArea = Convert.ToDouble(FigureArea.Text);	// If value is set -- use him
                }

				DataRow Row = ds.Tables["FigureAreasFind"].NewRow();
				Row["Figure"] = parentName;
				Row["Area"] = parentArea;

				if (findName != "" && findArea != 0.0)
				{
					if (findName == parentName && findArea == parentArea)
					{
						ds.Tables["FigureAreasFind"].Rows.Add(Row);
					}
				}
				else if (findName != "")
				{
					if (findName == parentName)
					{
						ds.Tables["FigureAreasFind"].Rows.Add(Row);
					}
				}
				else if (findArea != 0.0)
				{
					if (findArea == parentArea)
					{
						ds.Tables["FigureAreasFind"].Rows.Add(Row);
					}
				}
			}

			/* 2.2 Set data source to find figure data grid */
			
			BindingSource bindSrc = new BindingSource();

			bindSrc.DataSource = ds.Tables["FigureAreasFind"].DefaultView;
			FindFigureDataGrid.AutoGenerateColumns = true;
			FindFigureDataGrid.DataSource = bindSrc;
		}

		/// <summary>
		/// Calling main form public handler for checking number symbol in input
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckNumberKeyPressed(object sender, KeyPressEventArgs e)
		{
			_mainForm.CheckNumberKeyPressed(sender, e);
		}

		/// <summary>
		/// Calling main form public handler for checking character symbol in input
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckCharacterKeyPressed(object sender, KeyPressEventArgs e)
		{
			_mainForm.CheckCharacterKeyPressed(sender, e);
		}

		/// <summary>
		/// Clear find data grid result
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearFindResult_Click(object sender, EventArgs e)
		{
			_mainForm.CleanDataGrid(FindFigureDataGrid);
		}

		/// <summary>
		/// Cancel button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelFindButton_Click(object sender, EventArgs e)
		{
			// Clean search textboxes
			FigureName.Text = "";
			FigureArea.Text = "";
			_mainForm.CleanDataGrid(FindFigureDataGrid);
			this.Close();
		}

	}
}
