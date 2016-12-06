namespace AreaCountingView
{
	partial class AreaCountingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GroupBox = new System.Windows.Forms.GroupBox();
			this.Find = new System.Windows.Forms.Button();
			this.RandomData = new System.Windows.Forms.Button();
			this.DeleteObject = new System.Windows.Forms.Button();
			this.AddObject = new System.Windows.Forms.Button();
			this.FigureAreaDataGrid = new System.Windows.Forms.DataGridView();
			this.FigureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FigureArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveFileItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadFileItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.SaveFile = new System.Windows.Forms.SaveFileDialog();
			this.GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FigureAreaDataGrid)).BeginInit();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox
			// 
			this.GroupBox.Controls.Add(this.Find);
			this.GroupBox.Controls.Add(this.RandomData);
			this.GroupBox.Controls.Add(this.DeleteObject);
			this.GroupBox.Controls.Add(this.AddObject);
			this.GroupBox.Controls.Add(this.FigureAreaDataGrid);
			this.GroupBox.Location = new System.Drawing.Point(3, 27);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(273, 458);
			this.GroupBox.TabIndex = 0;
			this.GroupBox.TabStop = false;
			// 
			// Find
			// 
			this.Find.Location = new System.Drawing.Point(155, 406);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(108, 41);
			this.Find.TabIndex = 5;
			this.Find.Text = "Find";
			this.Find.UseVisualStyleBackColor = true;
			this.Find.Click += new System.EventHandler(this.FindObjectInDataGrid);
			// 
			// RandomData
			// 
			this.RandomData.Location = new System.Drawing.Point(9, 406);
			this.RandomData.Name = "RandomData";
			this.RandomData.Size = new System.Drawing.Size(108, 41);
			this.RandomData.TabIndex = 4;
			this.RandomData.Text = "Random Data";
			this.RandomData.UseVisualStyleBackColor = true;
			this.RandomData.Click += new System.EventHandler(this.GenerateRandomData);
			// 
			// DeleteObject
			// 
			this.DeleteObject.Location = new System.Drawing.Point(155, 352);
			this.DeleteObject.Name = "DeleteObject";
			this.DeleteObject.Size = new System.Drawing.Size(108, 41);
			this.DeleteObject.TabIndex = 3;
			this.DeleteObject.Text = "Delete Figure";
			this.DeleteObject.UseVisualStyleBackColor = true;
			this.DeleteObject.Click += new System.EventHandler(this.DeleteObjectFromDataGrid);
			// 
			// AddObject
			// 
			this.AddObject.Location = new System.Drawing.Point(9, 352);
			this.AddObject.Name = "AddObject";
			this.AddObject.Size = new System.Drawing.Size(108, 41);
			this.AddObject.TabIndex = 2;
			this.AddObject.Text = "Add Figure";
			this.AddObject.UseVisualStyleBackColor = true;
			this.AddObject.Click += new System.EventHandler(this.AddObjectInDataGrid);
			// 
			// FigureAreaDataGrid
			// 
			this.FigureAreaDataGrid.AllowUserToAddRows = false;
			this.FigureAreaDataGrid.AllowUserToDeleteRows = false;
			this.FigureAreaDataGrid.AllowUserToResizeRows = false;
			this.FigureAreaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FigureAreaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FigureName,
            this.FigureArea});
			this.FigureAreaDataGrid.Location = new System.Drawing.Point(6, 19);
			this.FigureAreaDataGrid.Name = "FigureAreaDataGrid";
			this.FigureAreaDataGrid.Size = new System.Drawing.Size(261, 319);
			this.FigureAreaDataGrid.TabIndex = 1;
			// 
			// FigureName
			// 
			this.FigureName.HeaderText = "Figure";
			this.FigureName.Name = "FigureName";
			// 
			// FigureArea
			// 
			this.FigureArea.HeaderText = "Area";
			this.FigureArea.Name = "FigureArea";
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(280, 24);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "MenuStrip";
			// 
			// FileItem
			// 
			this.FileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileItem,
            this.LoadFileItem});
			this.FileItem.Name = "FileItem";
			this.FileItem.Size = new System.Drawing.Size(48, 20);
			this.FileItem.Text = "Файл";
			// 
			// SaveFileItem
			// 
			this.SaveFileItem.Name = "SaveFileItem";
			this.SaveFileItem.Size = new System.Drawing.Size(180, 22);
			this.SaveFileItem.Text = "Сохранить таблицу";
			// 
			// LoadFileItem
			// 
			this.LoadFileItem.Name = "LoadFileItem";
			this.LoadFileItem.Size = new System.Drawing.Size(180, 22);
			this.LoadFileItem.Text = "Загрузить таблицу";
			// 
			// AreaCountingForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(280, 487);
			this.Controls.Add(this.GroupBox);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "AreaCountingForm";
			this.Text = "Расчёт площади геометрических фигур";
			this.GroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FigureAreaDataGrid)).EndInit();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox;
		private System.Windows.Forms.DataGridView FigureAreaDataGrid;
		private System.Windows.Forms.Button DeleteObject;
		private System.Windows.Forms.Button AddObject;
		private System.Windows.Forms.Button RandomData;
		private System.Windows.Forms.DataGridViewTextBoxColumn FigureName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FigureArea;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileItem;
		private System.Windows.Forms.ToolStripMenuItem SaveFileItem;
		private System.Windows.Forms.ToolStripMenuItem LoadFileItem;
		private System.Windows.Forms.OpenFileDialog OpenFile;
		private System.Windows.Forms.SaveFileDialog SaveFile;
		private System.Windows.Forms.Button Find;
	}
}

