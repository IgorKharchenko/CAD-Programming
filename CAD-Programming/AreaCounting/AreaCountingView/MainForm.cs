using System;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace AreaCountingView
{
	public partial class AreaCountingForm : Form
	{
		public AreaCountingForm()
		{
			InitializeComponent();
			SaveFileItem.Click += SaveFileItem_Click;
			LoadFileItem.Click += LoadFileItem_Click;
			OpenFile.Filter = "Serialized data binary files|*.sbf|All files|*.*";
			SaveFile.Filter = "Serialized data binary files|*.sbf|All files|*.*";
			_figureFormSpecimen = new FigureCreatingForm(this, FigureAreaDataGrid);
			_findFormSpecimen = new FindForm(this, FigureAreaDataGrid);
			#if !DEBUG
			RandomData.Visible = false;
			#endif
		}

		private FigureCreatingForm _figureFormSpecimen;
		private FindForm _findFormSpecimen;

		/// <summary>
		/// Save data grid to XML serialized data file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveFileItem_Click(object sender, EventArgs e)
		{
			if (SaveFile.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			string filename = SaveFile.FileName;
			TextWriter writer = new StreamWriter(filename);

			// xml SERIALIZE

			DataSet ds = new DataSet();		// Data cash
			DataTable dt = new DataTable(); // Data cash table
			dt.TableName = "FigureAreas";   // Data cash table name
			dt.Columns.Add("Figure");
			dt.Columns.Add("Area");
			ds.Tables.Add(dt);              // Add DataTable in DataSet

			foreach (DataGridViewRow AreaGridRow in FigureAreaDataGrid.Rows)
			{
				DataRow Row = ds.Tables["FigureAreas"].NewRow();

				Row["Figure"] = AreaGridRow.Cells[0].Value;
				Row["Area"] = AreaGridRow.Cells[1].Value;

				ds.Tables["FigureAreas"].Rows.Add(Row);
			}

			ds.WriteXml(writer);
			writer.Close();
			MessageBox.Show("File was saved successfully.");
		}
		
		/// <summary>
		/// Load XML serialized file on data grid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadFileItem_Click(object sender, EventArgs e)
		{
			if (OpenFile.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			if (FigureAreaDataGrid.Rows.Count > 0)
			{
				DialogResult cleanTable = MessageBox.Show("Clear table?", "Table isn't empty", MessageBoxButtons.YesNoCancel);
				if (cleanTable == DialogResult.Yes)
				{
					CleanDataGrid(FigureAreaDataGrid);
				}
				else if (cleanTable == DialogResult.Cancel)
				{
					return;
				}
			}
			string filename = OpenFile.FileName;
			var writer = new FileStream(filename, FileMode.Open);
			
			if (!OpenFile.CheckFileExists)
			{
				MessageBox.Show("File not exists.");
				return;
			}

			DataSet ds = new DataSet();
			ds.ReadXml(writer);
			writer.Close();
			
			if (ds.Tables["FigureAreas"] == null)
			{
				MessageBox.Show("XML Reader error: table \"FigureAreas\" doesn't exist in file");
				return;
			}

			foreach (DataRow Row in ds.Tables["FigureAreas"].Rows)
			{
				int n = FigureAreaDataGrid.Rows.Add();
				FigureAreaDataGrid.Rows[n].Cells[0].Value = Row["Figure"];
				FigureAreaDataGrid.Rows[n].Cells[1].Value = Row["Area"];
			}

			MessageBox.Show("File was loaded successfully.");
		}


		/// <summary>
		/// Checks for entering only numbers. He's public!
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void CheckNumberKeyPressed(object sender, KeyPressEventArgs e)
		{
			/*	If not in [0-9] or delimiter was entered -- set event handled.
				Delimiter is dot or comma -> input number must contain only 1 dot or only 1 comma.
			*/
			if ( !(Char.IsControl(e.KeyChar))
				&& !(Char.IsDigit(e.KeyChar))
				&& !((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf(".") == -1) && (((TextBox)sender).Text.IndexOf(",") == -1))
				&& !((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(",") == -1) && (((TextBox)sender).Text.IndexOf(".") == -1))
				&& (((TextBox)sender).Text.Length != 0))
			{
				e.Handled = true;
			}
			/* Otherwise all is OK */
		}

		public void CheckCharacterKeyPressed(object sender, KeyPressEventArgs e)
		{
			/* If not a letter entered -- set event handled */
			if ( !(Char.IsControl(e.KeyChar)) 
				&& !(Char.IsLetter(e.KeyChar))
				&& (((TextBox)sender).Text.Length != 0))
			{
				e.Handled = true;
			}
			/* Otherwise all is OK */
		}

		/// <summary>
		/// Cleans all data from find data grid. Public method.
		/// </summary>
		public void CleanDataGrid(DataGridView dataGrid)
		{
			while (true)
			{
				if (dataGrid.CurrentRow != null)
				{
					dataGrid.Rows.Remove(dataGrid.CurrentRow);
				}
				else
				{
					return;
				}
			}
		}

		/// <summary>
		/// Add figure object to main form datagrid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddObjectInDataGrid(object sender, EventArgs e)
		{
			_figureFormSpecimen.ShowDialog();
		}

		/// <summary>
		/// Find figure objects in main form datagrid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FindObjectInDataGrid(object sender, EventArgs e)
		{
			_findFormSpecimen.ShowDialog();
		}

		/// <summary>
		/// Delete all data from data grid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteObjectFromDataGrid(object sender, EventArgs e)
		{
			if(FigureAreaDataGrid.CurrentRow != null)
			{
				FigureAreaDataGrid.Rows.Remove(FigureAreaDataGrid.CurrentRow);
			}
		}

		/// <summary>
		/// Generate random data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GenerateRandomData(object sender, EventArgs e)
		{
			var RandomValue = new Random();
			for (int i = 0; i < 10; i++)
			{
                var FigureArea = RandomValue.Next(1,100);
				var FigureName = "";
				if (FigureArea > 0 && FigureArea <= 33)
				{
					FigureName = "Circle";
				}
				else if (FigureArea >= 34 && FigureArea <= 66)
				{
					FigureName = "Rectangle";
				}
				else if (FigureArea >= 67 && FigureArea <= 100)
				{
					FigureName = "Triangle";
				}
				FigureAreaDataGrid.Rows.Add();
				FigureAreaDataGrid["FigureName", FigureAreaDataGrid.Rows.Count - 1].Value = FigureName;
				FigureAreaDataGrid["FigureArea", FigureAreaDataGrid.Rows.Count - 1].Value = FigureArea;
			}
		}
	}
}
