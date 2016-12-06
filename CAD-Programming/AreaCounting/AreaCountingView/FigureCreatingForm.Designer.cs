namespace AreaCountingView
{
	partial class FigureCreatingForm
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
			this.FigureComboBox = new System.Windows.Forms.ComboBox();
			this.FigureComboBoxLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FigureUpLabel = new System.Windows.Forms.Label();
			this.FigureDownLabel = new System.Windows.Forms.Label();
			this.AddObjectInGridButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.FigureUpTextBox = new System.Windows.Forms.TextBox();
			this.FigureDownTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// FigureComboBox
			// 
			this.FigureComboBox.FormattingEnabled = true;
			this.FigureComboBox.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Triangle"});
			this.FigureComboBox.Location = new System.Drawing.Point(98, 22);
			this.FigureComboBox.Name = "FigureComboBox";
			this.FigureComboBox.Size = new System.Drawing.Size(137, 21);
			this.FigureComboBox.TabIndex = 0;
			this.FigureComboBox.SelectedIndexChanged += new System.EventHandler(this.FigureComboBox_SelectedIndexChanged);
			// 
			// FigureComboBoxLabel
			// 
			this.FigureComboBoxLabel.AutoSize = true;
			this.FigureComboBoxLabel.Location = new System.Drawing.Point(5, 25);
			this.FigureComboBoxLabel.Name = "FigureComboBoxLabel";
			this.FigureComboBoxLabel.Size = new System.Drawing.Size(39, 13);
			this.FigureComboBoxLabel.TabIndex = 1;
			this.FigureComboBoxLabel.Text = "Figure:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 4;
			// 
			// FigureUpLabel
			// 
			this.FigureUpLabel.AutoSize = true;
			this.FigureUpLabel.Location = new System.Drawing.Point(5, 86);
			this.FigureUpLabel.Name = "FigureUpLabel";
			this.FigureUpLabel.Size = new System.Drawing.Size(50, 13);
			this.FigureUpLabel.TabIndex = 5;
			this.FigureUpLabel.Text = "Up Label";
			this.FigureUpLabel.Visible = false;
			// 
			// FigureDownLabel
			// 
			this.FigureDownLabel.AutoSize = true;
			this.FigureDownLabel.Location = new System.Drawing.Point(5, 112);
			this.FigureDownLabel.Name = "FigureDownLabel";
			this.FigureDownLabel.Size = new System.Drawing.Size(64, 13);
			this.FigureDownLabel.TabIndex = 6;
			this.FigureDownLabel.Text = "Down Label";
			this.FigureDownLabel.Visible = false;
			// 
			// AddObjectInGridButton
			// 
			this.AddObjectInGridButton.Location = new System.Drawing.Point(8, 152);
			this.AddObjectInGridButton.Name = "AddObjectInGridButton";
			this.AddObjectInGridButton.Size = new System.Drawing.Size(111, 28);
			this.AddObjectInGridButton.TabIndex = 13;
			this.AddObjectInGridButton.Text = "Add Object";
			this.AddObjectInGridButton.UseVisualStyleBackColor = true;
			this.AddObjectInGridButton.Click += new System.EventHandler(this.AddObjectInGridButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(125, 152);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(114, 28);
			this.CancelButton.TabIndex = 14;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// FigureUpTextBox
			// 
			this.FigureUpTextBox.Location = new System.Drawing.Point(98, 79);
			this.FigureUpTextBox.Name = "FigureUpTextBox";
			this.FigureUpTextBox.Size = new System.Drawing.Size(137, 20);
			this.FigureUpTextBox.TabIndex = 17;
			this.FigureUpTextBox.Visible = false;
			this.FigureUpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// FigureDownTextBox
			// 
			this.FigureDownTextBox.Location = new System.Drawing.Point(98, 105);
			this.FigureDownTextBox.Name = "FigureDownTextBox";
			this.FigureDownTextBox.Size = new System.Drawing.Size(137, 20);
			this.FigureDownTextBox.TabIndex = 18;
			this.FigureDownTextBox.Visible = false;
			this.FigureDownTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// FigureCreatingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(247, 192);
			this.Controls.Add(this.FigureDownTextBox);
			this.Controls.Add(this.FigureUpTextBox);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AddObjectInGridButton);
			this.Controls.Add(this.FigureDownLabel);
			this.Controls.Add(this.FigureUpLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FigureComboBoxLabel);
			this.Controls.Add(this.FigureComboBox);
			this.Name = "FigureCreatingForm";
			this.Text = "FigureCreatingForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox FigureComboBox;
		private System.Windows.Forms.Label FigureComboBoxLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label FigureUpLabel;
		private System.Windows.Forms.Label FigureDownLabel;
		private System.Windows.Forms.Button AddObjectInGridButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.TextBox FigureUpTextBox;
		private System.Windows.Forms.TextBox FigureDownTextBox;
	}
}