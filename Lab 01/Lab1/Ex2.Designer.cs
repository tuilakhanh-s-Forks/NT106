namespace Lab1
{
	partial class Ex2
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
			labelNum1 = new Label();
			labelNum2 = new Label();
			labelNum3 = new Label();
			textBoxNum1 = new TextBox();
			textBoxNum2 = new TextBox();
			textBoxNum3 = new TextBox();
			groupBox1 = new GroupBox();
			label5 = new Label();
			textBoxMax = new TextBox();
			textBoxMin = new TextBox();
			labelMax = new Label();
			labelMin = new Label();
			buttonDelete = new Button();
			buttonSearch = new Button();
			buttonExit = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// labelNum1
			// 
			labelNum1.AutoSize = true;
			labelNum1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelNum1.Location = new Point(98, 43);
			labelNum1.Name = "labelNum1";
			labelNum1.Size = new Size(163, 35);
			labelNum1.TabIndex = 0;
			labelNum1.Text = "Số Thứ Nhất";
			// 
			// labelNum2
			// 
			labelNum2.AutoSize = true;
			labelNum2.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelNum2.Location = new Point(98, 99);
			labelNum2.Name = "labelNum2";
			labelNum2.Size = new Size(142, 35);
			labelNum2.TabIndex = 1;
			labelNum2.Text = "Số Thứ Hai";
			// 
			// labelNum3
			// 
			labelNum3.AutoSize = true;
			labelNum3.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelNum3.Location = new Point(98, 170);
			labelNum3.Name = "labelNum3";
			labelNum3.Size = new Size(133, 35);
			labelNum3.TabIndex = 2;
			labelNum3.Text = "Số Thứ Ba";
			// 
			// textBoxNum1
			// 
			textBoxNum1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxNum1.Location = new Point(267, 40);
			textBoxNum1.Name = "textBoxNum1";
			textBoxNum1.Size = new Size(445, 40);
			textBoxNum1.TabIndex = 3;
			// 
			// textBoxNum2
			// 
			textBoxNum2.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxNum2.Location = new Point(267, 99);
			textBoxNum2.Name = "textBoxNum2";
			textBoxNum2.Size = new Size(445, 40);
			textBoxNum2.TabIndex = 4;
			// 
			// textBoxNum3
			// 
			textBoxNum3.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxNum3.Location = new Point(267, 165);
			textBoxNum3.Name = "textBoxNum3";
			textBoxNum3.Size = new Size(445, 40);
			textBoxNum3.TabIndex = 5;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBoxNum3);
			groupBox1.Controls.Add(labelNum1);
			groupBox1.Controls.Add(textBoxNum2);
			groupBox1.Controls.Add(labelNum2);
			groupBox1.Controls.Add(textBoxNum1);
			groupBox1.Controls.Add(labelNum3);
			groupBox1.Location = new Point(12, 74);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(807, 230);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nhập";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(289, 22);
			label5.Name = "label5";
			label5.Size = new Size(335, 35);
			label5.TabIndex = 7;
			label5.Text = "Tìm Số Lớn Nhất Nhỏ Nhất";
			// 
			// textBoxMax
			// 
			textBoxMax.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxMax.Location = new Point(179, 391);
			textBoxMax.Name = "textBoxMax";
			textBoxMax.ReadOnly = true;
			textBoxMax.Size = new Size(217, 40);
			textBoxMax.TabIndex = 8;
			// 
			// textBoxMin
			// 
			textBoxMin.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxMin.Location = new Point(602, 391);
			textBoxMin.Name = "textBoxMin";
			textBoxMin.ReadOnly = true;
			textBoxMin.Size = new Size(217, 40);
			textBoxMin.TabIndex = 9;
			// 
			// labelMax
			// 
			labelMax.AutoSize = true;
			labelMax.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelMax.Location = new Point(12, 394);
			labelMax.Name = "labelMax";
			labelMax.Size = new Size(161, 35);
			labelMax.TabIndex = 10;
			labelMax.Text = "Số Lớn Nhất";
			// 
			// labelMin
			// 
			labelMin.AutoSize = true;
			labelMin.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelMin.Location = new Point(430, 396);
			labelMin.Name = "labelMin";
			labelMin.Size = new Size(166, 35);
			labelMin.TabIndex = 11;
			labelMin.Text = "Số Nhỏ Nhất";
			// 
			// buttonDelete
			// 
			buttonDelete.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonDelete.Location = new Point(179, 327);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(130, 40);
			buttonDelete.TabIndex = 12;
			buttonDelete.Text = "Xoá";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonSearch
			// 
			buttonSearch.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonSearch.Location = new Point(398, 327);
			buttonSearch.Name = "buttonSearch";
			buttonSearch.Size = new Size(130, 40);
			buttonSearch.TabIndex = 13;
			buttonSearch.Text = "Tìm";
			buttonSearch.UseVisualStyleBackColor = true;
			buttonSearch.Click += buttonSearch_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(627, 327);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(130, 40);
			buttonExit.TabIndex = 14;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// Ex2
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(843, 455);
			Controls.Add(buttonExit);
			Controls.Add(buttonSearch);
			Controls.Add(buttonDelete);
			Controls.Add(labelMin);
			Controls.Add(labelMax);
			Controls.Add(textBoxMin);
			Controls.Add(textBoxMax);
			Controls.Add(label5);
			Controls.Add(groupBox1);
			Name = "Ex2";
			Text = "Bài 2";
			FormClosed += Ex2_FormClosed;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelNum1;
		private Label labelNum2;
		private Label labelNum3;
		private TextBox textBoxNum1;
		private TextBox textBoxNum2;
		private TextBox textBoxNum3;
		private GroupBox groupBox1;
		private Label label5;
		private TextBox textBoxMax;
		private TextBox textBoxMin;
		private Label labelMax;
		private Label labelMin;
		private Button buttonDelete;
		private Button buttonSearch;
		private Button buttonExit;
	}
}