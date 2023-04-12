namespace Lab_02
{
	partial class Ex01
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
			buttonWriteFile = new Button();
			richTextBoxFile = new RichTextBox();
			buttonExit = new Button();
			SuspendLayout();
			// 
			// buttonReadFile
			// 
			buttonReadFile.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonReadFile.Location = new Point(23, 27);
			buttonReadFile.Name = "buttonReadFile";
			buttonReadFile.Size = new Size(140, 57);
			buttonReadFile.TabIndex = 0;
			buttonReadFile.Text = "Đọc FIle";
			buttonReadFile.UseVisualStyleBackColor = true;
			buttonReadFile.Click += buttonReadFile_Click;
			// 
			// buttonWriteFile
			// 
			buttonWriteFile.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonWriteFile.Location = new Point(23, 104);
			buttonWriteFile.Name = "buttonWriteFile";
			buttonWriteFile.Size = new Size(140, 57);
			buttonWriteFile.TabIndex = 1;
			buttonWriteFile.Text = "Ghi File";
			buttonWriteFile.UseVisualStyleBackColor = true;
			buttonWriteFile.Click += buttonWriteFile_Click;
			// 
			// richTextBoxFile
			// 
			richTextBoxFile.Font = new Font("Open Sans Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			richTextBoxFile.Location = new Point(185, 27);
			richTextBoxFile.Name = "richTextBoxFile";
			richTextBoxFile.Size = new Size(821, 382);
			richTextBoxFile.TabIndex = 2;
			richTextBoxFile.Text = "";
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(23, 352);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(140, 57);
			buttonExit.TabIndex = 3;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// Ex01
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1018, 435);
			Controls.Add(buttonExit);
			Controls.Add(richTextBoxFile);
			Controls.Add(buttonWriteFile);
			Controls.Add(buttonReadFile);
			Name = "Ex01";
			Text = "Bài 01";
			FormClosed += Ex01_FormClosed;
			ResumeLayout(false);
		}

		#endregion

		private Button buttonReadFile;
		private Button buttonWriteFile;
		private RichTextBox richTextBoxFile;
		private Button buttonExit;
	}
}