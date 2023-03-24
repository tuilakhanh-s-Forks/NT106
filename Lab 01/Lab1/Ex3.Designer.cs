namespace Lab1
{
	partial class Ex3
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
			labelInput = new Label();
			textBoxInput = new TextBox();
			textBoxResult = new TextBox();
			labelResult = new Label();
			buttonRead = new Button();
			buttonExit = new Button();
			buttonDelete = new Button();
			labelTitle = new Label();
			SuspendLayout();
			// 
			// labelInput
			// 
			labelInput.AutoSize = true;
			labelInput.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelInput.Location = new Point(77, 82);
			labelInput.Name = "labelInput";
			labelInput.Size = new Size(397, 35);
			labelInput.TabIndex = 0;
			labelInput.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
			// 
			// textBoxInput
			// 
			textBoxInput.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxInput.Location = new Point(496, 77);
			textBoxInput.Name = "textBoxInput";
			textBoxInput.Size = new Size(150, 40);
			textBoxInput.TabIndex = 1;
			// 
			// textBoxResult
			// 
			textBoxResult.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxResult.Location = new Point(496, 152);
			textBoxResult.Name = "textBoxResult";
			textBoxResult.ReadOnly = true;
			textBoxResult.Size = new Size(150, 40);
			textBoxResult.TabIndex = 2;
			// 
			// labelResult
			// 
			labelResult.AutoSize = true;
			labelResult.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelResult.Location = new Point(77, 171);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(106, 35);
			labelResult.TabIndex = 3;
			labelResult.Text = "Kết quả";
			// 
			// buttonRead
			// 
			buttonRead.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonRead.Location = new Point(299, 264);
			buttonRead.Name = "buttonRead";
			buttonRead.Size = new Size(133, 45);
			buttonRead.TabIndex = 4;
			buttonRead.Text = "Đọc";
			buttonRead.TextAlign = ContentAlignment.TopCenter;
			buttonRead.UseVisualStyleBackColor = true;
			buttonRead.Click += buttonRead_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(513, 264);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(133, 45);
			buttonExit.TabIndex = 5;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonDelete.Location = new Point(77, 264);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(133, 45);
			buttonDelete.TabIndex = 6;
			buttonDelete.Text = "Xoá";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelTitle.Location = new Point(322, 25);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(94, 35);
			labelTitle.TabIndex = 7;
			labelTitle.Text = "Đọc Số";
			// 
			// Ex3
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(725, 360);
			Controls.Add(labelTitle);
			Controls.Add(buttonDelete);
			Controls.Add(buttonExit);
			Controls.Add(buttonRead);
			Controls.Add(labelResult);
			Controls.Add(textBoxResult);
			Controls.Add(textBoxInput);
			Controls.Add(labelInput);
			Name = "Ex3";
			Text = "Bài 3";
			FormClosed += Ex3_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelInput;
		private TextBox textBoxInput;
		private TextBox textBoxResult;
		private Label labelResult;
		private Button buttonRead;
		private Button buttonExit;
		private Button buttonDelete;
		private Label labelTitle;
	}
}