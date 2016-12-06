namespace AreaCountingView
{
	partial class FindForm
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
			this.components = new System.ComponentModel.Container();
			this.FindFigureGroupBox = new System.Windows.Forms.GroupBox();
			this.CancelFindButton = new System.Windows.Forms.Button();
			this.FindFigure = new System.Windows.Forms.Button();
			this.FigureArea = new System.Windows.Forms.TextBox();
			this.FigureAreaLabel = new System.Windows.Forms.Label();
			this.FigureName = new System.Windows.Forms.TextBox();
			this.FigureNameLabel = new System.Windows.Forms.Label();
			this.FindFigureDataGrid = new System.Windows.Forms.DataGridView();
			this.ClearFindResult = new System.Windows.Forms.Button();
			this.iValidatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.FindFigureGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FindFigureDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iValidatorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// FindFigureGroupBox
			// 
			this.FindFigureGroupBox.Controls.Add(this.CancelFindButton);
			this.FindFigureGroupBox.Controls.Add(this.FindFigure);
			this.FindFigureGroupBox.Controls.Add(this.FigureArea);
			this.FindFigureGroupBox.Controls.Add(this.FigureAreaLabel);
			this.FindFigureGroupBox.Controls.Add(this.FigureName);
			this.FindFigureGroupBox.Controls.Add(this.FigureNameLabel);
			this.FindFigureGroupBox.Location = new System.Drawing.Point(12, 12);
			this.FindFigureGroupBox.Name = "FindFigureGroupBox";
			this.FindFigureGroupBox.Size = new System.Drawing.Size(213, 125);
			this.FindFigureGroupBox.TabIndex = 0;
			this.FindFigureGroupBox.TabStop = false;
			this.FindFigureGroupBox.Text = "Find Figure";
			// 
			// CancelFindButton
			// 
			this.CancelFindButton.Location = new System.Drawing.Point(9, 89);
			this.CancelFindButton.Name = "CancelFindButton";
			this.CancelFindButton.Size = new System.Drawing.Size(90, 27);
			this.CancelFindButton.TabIndex = 3;
			this.CancelFindButton.Text = "Cancel";
			this.CancelFindButton.UseVisualStyleBackColor = true;
			this.CancelFindButton.Click += new System.EventHandler(this.CancelFindButton_Click);
			// 
			// FindFigure
			// 
			this.FindFigure.Location = new System.Drawing.Point(117, 89);
			this.FindFigure.Name = "FindFigure";
			this.FindFigure.Size = new System.Drawing.Size(90, 27);
			this.FindFigure.TabIndex = 1;
			this.FindFigure.Text = "Find Figure";
			this.FindFigure.UseVisualStyleBackColor = true;
			this.FindFigure.Click += new System.EventHandler(this.FindFigure_Click);
			// 
			// FigureArea
			// 
			this.FigureArea.Location = new System.Drawing.Point(90, 54);
			this.FigureArea.Name = "FigureArea";
			this.FigureArea.Size = new System.Drawing.Size(117, 20);
			this.FigureArea.TabIndex = 2;
			this.FigureArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// FigureAreaLabel
			// 
			this.FigureAreaLabel.AutoSize = true;
			this.FigureAreaLabel.Location = new System.Drawing.Point(6, 57);
			this.FigureAreaLabel.Name = "FigureAreaLabel";
			this.FigureAreaLabel.Size = new System.Drawing.Size(64, 13);
			this.FigureAreaLabel.TabIndex = 1;
			this.FigureAreaLabel.Text = "Figure Area:";
			// 
			// FigureName
			// 
			this.FigureName.Location = new System.Drawing.Point(90, 26);
			this.FigureName.Name = "FigureName";
			this.FigureName.Size = new System.Drawing.Size(117, 20);
			this.FigureName.TabIndex = 1;
			this.FigureName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckCharacterKeyPressed);
			// 
			// FigureNameLabel
			// 
			this.FigureNameLabel.AutoSize = true;
			this.FigureNameLabel.Location = new System.Drawing.Point(6, 29);
			this.FigureNameLabel.Name = "FigureNameLabel";
			this.FigureNameLabel.Size = new System.Drawing.Size(70, 13);
			this.FigureNameLabel.TabIndex = 0;
			this.FigureNameLabel.Text = "Figure Name:";
			// 
			// FindFigureDataGrid
			// 
			this.FindFigureDataGrid.AutoGenerateColumns = false;
			this.FindFigureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FindFigureDataGrid.DataSource = this.iValidatorBindingSource;
			this.FindFigureDataGrid.Location = new System.Drawing.Point(231, 12);
			this.FindFigureDataGrid.Name = "FindFigureDataGrid";
			this.FindFigureDataGrid.Size = new System.Drawing.Size(270, 344);
			this.FindFigureDataGrid.TabIndex = 1;
			// 
			// ClearFindResult
			// 
			this.ClearFindResult.Location = new System.Drawing.Point(378, 362);
			this.ClearFindResult.Name = "ClearFindResult";
			this.ClearFindResult.Size = new System.Drawing.Size(123, 29);
			this.ClearFindResult.TabIndex = 2;
			this.ClearFindResult.Text = "Clear Find Result";
			this.ClearFindResult.UseVisualStyleBackColor = true;
			this.ClearFindResult.Click += new System.EventHandler(this.ClearFindResult_Click);
			// 
			// iValidatorBindingSource
			// 
			this.iValidatorBindingSource.DataSource = typeof(AreaCounting.IValidator);
			// 
			// FindForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(513, 401);
			this.Controls.Add(this.ClearFindResult);
			this.Controls.Add(this.FindFigureDataGrid);
			this.Controls.Add(this.FindFigureGroupBox);
			this.Name = "FindForm";
			this.Text = "FindForm";
			this.FindFigureGroupBox.ResumeLayout(false);
			this.FindFigureGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FindFigureDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iValidatorBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox FindFigureGroupBox;
		private System.Windows.Forms.Button FindFigure;
		private System.Windows.Forms.TextBox FigureArea;
		private System.Windows.Forms.Label FigureAreaLabel;
		private System.Windows.Forms.TextBox FigureName;
		private System.Windows.Forms.Label FigureNameLabel;
		private System.Windows.Forms.DataGridView FindFigureDataGrid;
		private System.Windows.Forms.BindingSource iValidatorBindingSource;
		private System.Windows.Forms.Button ClearFindResult;
		private System.Windows.Forms.Button CancelFindButton;
	}
}