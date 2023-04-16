namespace Lab_02
{
	partial class Ex03
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
			richTextBoxExpression = new RichTextBox();
			richTextBoxResult = new RichTextBox();
			buttonCalculate = new Button();
			buttonReadFile = new Button();
			SuspendLayout();
			// 
			// richTextBoxExpression
			// 
			richTextBoxExpression.Font = new Font("Open Sans Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
			richTextBoxExpression.Location = new Point(12, 26);
			richTextBoxExpression.Name = "richTextBoxExpression";
			richTextBoxExpression.Size = new Size(469, 585);
			richTextBoxExpression.TabIndex = 0;
			richTextBoxExpression.Text = "";
			// 
			// richTextBoxResult
			// 
			richTextBoxResult.Font = new Font("Open Sans Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
			richTextBoxResult.Location = new Point(659, 26);
			richTextBoxResult.Name = "richTextBoxResult";
			richTextBoxResult.Size = new Size(469, 585);
			richTextBoxResult.TabIndex = 1;
			richTextBoxResult.Text = "";
			// 
			// buttonCalculate
			// 
			buttonCalculate.Font = new Font("Open Sans Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCalculate.Location = new Point(499, 266);
			buttonCalculate.Name = "buttonCalculate";
			buttonCalculate.Size = new Size(133, 47);
			buttonCalculate.TabIndex = 2;
			buttonCalculate.Text = "Calculate";
			buttonCalculate.UseVisualStyleBackColor = true;
			buttonCalculate.Click += buttonCalculate_Click;
			// 
			// buttonReadFile
			// 
			buttonReadFile.Font = new Font("Open Sans Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
			buttonReadFile.Location = new Point(499, 26);
			buttonReadFile.Name = "buttonReadFile";
			buttonReadFile.Size = new Size(139, 47);
			buttonReadFile.TabIndex = 3;
			buttonReadFile.Text = "Read";
			buttonReadFile.UseVisualStyleBackColor = true;
			buttonReadFile.Click += buttonReadFile_Click;
			// 
			// Ex03
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1140, 633);
			Controls.Add(buttonReadFile);
			Controls.Add(buttonCalculate);
			Controls.Add(richTextBoxResult);
			Controls.Add(richTextBoxExpression);
			Name = "Ex03";
			Text = "Exercise 03";
			FormClosed += Ex03_FormClosed;
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox richTextBoxExpression;
		private RichTextBox richTextBoxResult;
		private Button buttonCalculate;
		private Button buttonReadFile;
	}
}