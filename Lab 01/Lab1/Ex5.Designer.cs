namespace Lab1
{
	partial class Ex5
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
			textBoxInputA = new TextBox();
			textBoxInputB = new TextBox();
			labelInputA = new Label();
			labelInputB = new Label();
			labelTitle = new Label();
			buttonCalculate = new Button();
			buttonDelete = new Button();
			buttonExit = new Button();
			groupBox1 = new GroupBox();
			labelS3 = new Label();
			labelFactorialB = new Label();
			labelS1 = new Label();
			labelFactorialA = new Label();
			labelS2 = new Label();
			labelFactorialBTitle = new Label();
			label8 = new Label();
			labelS2Title = new Label();
			labelS1Title = new Label();
			labelFactorialATitle = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// textBoxInputA
			// 
			textBoxInputA.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxInputA.Location = new Point(190, 101);
			textBoxInputA.Name = "textBoxInputA";
			textBoxInputA.Size = new Size(194, 40);
			textBoxInputA.TabIndex = 0;
			// 
			// textBoxInputB
			// 
			textBoxInputB.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxInputB.Location = new Point(543, 104);
			textBoxInputB.Name = "textBoxInputB";
			textBoxInputB.Size = new Size(194, 40);
			textBoxInputB.TabIndex = 1;
			// 
			// labelInputA
			// 
			labelInputA.AutoSize = true;
			labelInputA.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelInputA.Location = new Point(86, 104);
			labelInputA.Name = "labelInputA";
			labelInputA.Size = new Size(103, 35);
			labelInputA.TabIndex = 2;
			labelInputA.Text = "Nhập A";
			// 
			// labelInputB
			// 
			labelInputB.AutoSize = true;
			labelInputB.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelInputB.Location = new Point(435, 104);
			labelInputB.Name = "labelInputB";
			labelInputB.Size = new Size(102, 35);
			labelInputB.TabIndex = 3;
			labelInputB.Text = "Nhập B";
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelTitle.Location = new Point(283, 26);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(275, 35);
			labelTitle.TabIndex = 4;
			labelTitle.Text = "Tính Giá Trị Biểu Thức";
			// 
			// buttonCalculate
			// 
			buttonCalculate.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCalculate.Location = new Point(87, 170);
			buttonCalculate.Name = "buttonCalculate";
			buttonCalculate.Size = new Size(336, 46);
			buttonCalculate.TabIndex = 5;
			buttonCalculate.Text = "Tìm các giá trị";
			buttonCalculate.UseVisualStyleBackColor = true;
			buttonCalculate.Click += buttonCalculate_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonDelete.Location = new Point(459, 170);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(126, 46);
			buttonDelete.TabIndex = 6;
			buttonDelete.Text = "Xoá";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(614, 170);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(123, 46);
			buttonExit.TabIndex = 7;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(labelS3);
			groupBox1.Controls.Add(labelFactorialB);
			groupBox1.Controls.Add(labelS1);
			groupBox1.Controls.Add(labelFactorialA);
			groupBox1.Controls.Add(labelS2);
			groupBox1.Controls.Add(labelFactorialBTitle);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(labelS2Title);
			groupBox1.Controls.Add(labelS1Title);
			groupBox1.Controls.Add(labelFactorialATitle);
			groupBox1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.Location = new Point(55, 230);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(671, 230);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Kết Quả";
			// 
			// labelS3
			// 
			labelS3.AutoSize = true;
			labelS3.Location = new Point(482, 175);
			labelS3.Name = "labelS3";
			labelS3.Size = new Size(0, 35);
			labelS3.TabIndex = 14;
			// 
			// labelFactorialB
			// 
			labelFactorialB.AutoSize = true;
			labelFactorialB.Location = new Point(494, 36);
			labelFactorialB.Name = "labelFactorialB";
			labelFactorialB.Size = new Size(0, 35);
			labelFactorialB.TabIndex = 13;
			// 
			// labelS1
			// 
			labelS1.AutoSize = true;
			labelS1.Location = new Point(329, 85);
			labelS1.Name = "labelS1";
			labelS1.Size = new Size(0, 35);
			labelS1.TabIndex = 12;
			// 
			// labelFactorialA
			// 
			labelFactorialA.AutoSize = true;
			labelFactorialA.Location = new Point(81, 39);
			labelFactorialA.Name = "labelFactorialA";
			labelFactorialA.Size = new Size(0, 35);
			labelFactorialA.TabIndex = 11;
			// 
			// labelS2
			// 
			labelS2.AutoSize = true;
			labelS2.Location = new Point(329, 129);
			labelS2.Name = "labelS2";
			labelS2.Size = new Size(0, 35);
			labelS2.TabIndex = 10;
			// 
			// labelFactorialBTitle
			// 
			labelFactorialBTitle.AutoSize = true;
			labelFactorialBTitle.Location = new Point(446, 36);
			labelFactorialBTitle.Name = "labelFactorialBTitle";
			labelFactorialBTitle.Size = new Size(64, 35);
			labelFactorialBTitle.TabIndex = 9;
			labelFactorialBTitle.Text = "B! = ";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(31, 175);
			label8.Name = "label8";
			label8.Size = new Size(472, 35);
			label8.TabIndex = 3;
			label8.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = ";
			// 
			// labelS2Title
			// 
			labelS2Title.AutoSize = true;
			labelS2Title.Location = new Point(32, 129);
			labelS2Title.Name = "labelS2Title";
			labelS2Title.Size = new Size(317, 35);
			labelS2Title.TabIndex = 2;
			labelS2Title.Text = "S2 = 1 + 2 + 3 + 4 + ... + B = ";
			// 
			// labelS1Title
			// 
			labelS1Title.AutoSize = true;
			labelS1Title.Location = new Point(31, 85);
			labelS1Title.Name = "labelS1Title";
			labelS1Title.Size = new Size(318, 35);
			labelS1Title.TabIndex = 1;
			labelS1Title.Text = "S1 = 1 + 2 + 3 + 4 + ... + A = ";
			// 
			// labelFactorialATitle
			// 
			labelFactorialATitle.AutoSize = true;
			labelFactorialATitle.Location = new Point(32, 39);
			labelFactorialATitle.Name = "labelFactorialATitle";
			labelFactorialATitle.Size = new Size(65, 35);
			labelFactorialATitle.TabIndex = 0;
			labelFactorialATitle.Text = "A! = ";
			// 
			// Ex5
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(802, 500);
			Controls.Add(groupBox1);
			Controls.Add(buttonExit);
			Controls.Add(buttonDelete);
			Controls.Add(buttonCalculate);
			Controls.Add(labelTitle);
			Controls.Add(labelInputB);
			Controls.Add(labelInputA);
			Controls.Add(textBoxInputB);
			Controls.Add(textBoxInputA);
			Name = "Ex5";
			Text = "Bài 5";
			FormClosed += Ex5_FormClosed;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxInputA;
		private TextBox textBoxInputB;
		private Label labelInputA;
		private Label labelInputB;
		private Label labelTitle;
		private Button buttonCalculate;
		private Button buttonDelete;
		private Button buttonExit;
		private GroupBox groupBox1;
		private Label labelS3;
		private Label labelFactorialB;
		private Label labelS1;
		private Label labelFactorialA;
		private Label labelS2;
		private Label labelFactorialBTitle;
		private Label label8;
		private Label labelS2Title;
		private Label labelS1Title;
		private Label labelFactorialATitle;
	}
}