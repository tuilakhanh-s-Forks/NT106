namespace Lab_02
{
	partial class Ex02
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
			buttonReadFile = new Button();
			textBoxFileName = new TextBox();
			labelFileName = new Label();
			labelPath = new Label();
			textBoxPath = new TextBox();
			labelSize = new Label();
			textBoxSize = new TextBox();
			labelLines = new Label();
			textBoxLines = new TextBox();
			labelWords = new Label();
			textBoxWords = new TextBox();
			labelCharacters = new Label();
			textBoxCharacters = new TextBox();
			buttonExit = new Button();
			richTextBoxFile = new RichTextBox();
			SuspendLayout();
			// 
			// buttonReadFile
			// 
			buttonReadFile.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonReadFile.Location = new Point(89, 42);
			buttonReadFile.Name = "buttonReadFile";
			buttonReadFile.Size = new Size(276, 55);
			buttonReadFile.TabIndex = 0;
			buttonReadFile.Text = "Read from FIle";
			buttonReadFile.UseVisualStyleBackColor = true;
			buttonReadFile.Click += buttonReadFile_Click;
			// 
			// textBoxFileName
			// 
			textBoxFileName.Enabled = false;
			textBoxFileName.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxFileName.Location = new Point(204, 142);
			textBoxFileName.Name = "textBoxFileName";
			textBoxFileName.Size = new Size(210, 40);
			textBoxFileName.TabIndex = 1;
			// 
			// labelFileName
			// 
			labelFileName.AutoSize = true;
			labelFileName.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelFileName.Location = new Point(44, 145);
			labelFileName.Name = "labelFileName";
			labelFileName.Size = new Size(128, 35);
			labelFileName.TabIndex = 2;
			labelFileName.Text = "FileName";
			// 
			// labelPath
			// 
			labelPath.AutoSize = true;
			labelPath.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelPath.Location = new Point(44, 254);
			labelPath.Name = "labelPath";
			labelPath.Size = new Size(70, 35);
			labelPath.TabIndex = 4;
			labelPath.Text = "Path";
			// 
			// textBoxPath
			// 
			textBoxPath.Enabled = false;
			textBoxPath.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxPath.Location = new Point(204, 251);
			textBoxPath.Name = "textBoxPath";
			textBoxPath.Size = new Size(210, 40);
			textBoxPath.TabIndex = 3;
			// 
			// labelSize
			// 
			labelSize.AutoSize = true;
			labelSize.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelSize.Location = new Point(44, 201);
			labelSize.Name = "labelSize";
			labelSize.Size = new Size(61, 35);
			labelSize.TabIndex = 6;
			labelSize.Text = "Size";
			// 
			// textBoxSize
			// 
			textBoxSize.Enabled = false;
			textBoxSize.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxSize.Location = new Point(204, 196);
			textBoxSize.Name = "textBoxSize";
			textBoxSize.Size = new Size(210, 40);
			textBoxSize.TabIndex = 5;
			// 
			// labelLines
			// 
			labelLines.AutoSize = true;
			labelLines.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelLines.Location = new Point(44, 305);
			labelLines.Name = "labelLines";
			labelLines.Size = new Size(78, 35);
			labelLines.TabIndex = 8;
			labelLines.Text = "Lines";
			// 
			// textBoxLines
			// 
			textBoxLines.Enabled = false;
			textBoxLines.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxLines.Location = new Point(204, 305);
			textBoxLines.Name = "textBoxLines";
			textBoxLines.Size = new Size(210, 40);
			textBoxLines.TabIndex = 7;
			// 
			// labelWords
			// 
			labelWords.AutoSize = true;
			labelWords.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelWords.Location = new Point(44, 354);
			labelWords.Name = "labelWords";
			labelWords.Size = new Size(91, 35);
			labelWords.TabIndex = 10;
			labelWords.Text = "Words";
			// 
			// textBoxWords
			// 
			textBoxWords.Enabled = false;
			textBoxWords.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxWords.Location = new Point(204, 354);
			textBoxWords.Name = "textBoxWords";
			textBoxWords.Size = new Size(210, 40);
			textBoxWords.TabIndex = 9;
			// 
			// labelCharacters
			// 
			labelCharacters.AutoSize = true;
			labelCharacters.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelCharacters.Location = new Point(44, 403);
			labelCharacters.Name = "labelCharacters";
			labelCharacters.Size = new Size(144, 35);
			labelCharacters.TabIndex = 12;
			labelCharacters.Text = "Characters";
			// 
			// textBoxCharacters
			// 
			textBoxCharacters.Enabled = false;
			textBoxCharacters.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxCharacters.Location = new Point(204, 403);
			textBoxCharacters.Name = "textBoxCharacters";
			textBoxCharacters.Size = new Size(210, 40);
			textBoxCharacters.TabIndex = 11;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(89, 492);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(265, 63);
			buttonExit.TabIndex = 13;
			buttonExit.Text = "Exit";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// richTextBoxFile
			// 
			richTextBoxFile.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			richTextBoxFile.Location = new Point(435, 42);
			richTextBoxFile.Name = "richTextBoxFile";
			richTextBoxFile.Size = new Size(715, 531);
			richTextBoxFile.TabIndex = 14;
			richTextBoxFile.Text = "";
			// 
			// Ex02
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1168, 600);
			Controls.Add(richTextBoxFile);
			Controls.Add(buttonExit);
			Controls.Add(labelCharacters);
			Controls.Add(textBoxCharacters);
			Controls.Add(labelWords);
			Controls.Add(textBoxWords);
			Controls.Add(labelLines);
			Controls.Add(textBoxLines);
			Controls.Add(labelSize);
			Controls.Add(textBoxSize);
			Controls.Add(labelPath);
			Controls.Add(textBoxPath);
			Controls.Add(labelFileName);
			Controls.Add(textBoxFileName);
			Controls.Add(buttonReadFile);
			Name = "Ex02";
			Text = "Exercise 02";
			FormClosed += Ex02_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonReadFile;
		private TextBox textBoxFileName;
		private Label labelFileName;
		private Label labelPath;
		private TextBox textBoxPath;
		private Label labelSize;
		private TextBox textBoxSize;
		private Label labelLines;
		private TextBox textBoxLines;
		private Label labelWords;
		private TextBox textBoxWords;
		private Label labelCharacters;
		private TextBox textBoxCharacters;
		private Button buttonExit;
		private RichTextBox richTextBoxFile;
	}
}