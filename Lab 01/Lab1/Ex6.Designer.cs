namespace Lab1
{
	partial class Ex6
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
			textBoxInputScores = new TextBox();
			labelInputScores = new Label();
			listViewScores = new ListView();
			columnSubject = new ColumnHeader();
			columnGrades = new ColumnHeader();
			labelAvg = new Label();
			labelMax = new Label();
			labelMin = new Label();
			labelGrade = new Label();
			labelPassed = new Label();
			labelFailed = new Label();
			textBoxAvg = new TextBox();
			textBoxMax = new TextBox();
			textBoxMin = new TextBox();
			textBoxGrades = new TextBox();
			textBoxPass = new TextBox();
			textBoxFail = new TextBox();
			labelTitle = new Label();
			buttonCalc = new Button();
			buttonReset = new Button();
			buttonExit = new Button();
			SuspendLayout();
			// 
			// textBoxInputScores
			// 
			textBoxInputScores.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxInputScores.Location = new Point(290, 60);
			textBoxInputScores.Name = "textBoxInputScores";
			textBoxInputScores.Size = new Size(473, 40);
			textBoxInputScores.TabIndex = 0;
			// 
			// labelInputScores
			// 
			labelInputScores.AutoSize = true;
			labelInputScores.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelInputScores.Location = new Point(31, 60);
			labelInputScores.Name = "labelInputScores";
			labelInputScores.Size = new Size(252, 35);
			labelInputScores.TabIndex = 1;
			labelInputScores.Text = "Nhập điểm các môn";
			// 
			// listViewScores
			// 
			listViewScores.Columns.AddRange(new ColumnHeader[] { columnSubject, columnGrades });
			listViewScores.Font = new Font("Open Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
			listViewScores.FullRowSelect = true;
			listViewScores.GridLines = true;
			listViewScores.Location = new Point(43, 117);
			listViewScores.Name = "listViewScores";
			listViewScores.Size = new Size(207, 270);
			listViewScores.TabIndex = 2;
			listViewScores.UseCompatibleStateImageBehavior = false;
			listViewScores.View = View.Details;
			// 
			// columnSubject
			// 
			columnSubject.Text = "Môn";
			columnSubject.Width = 110;
			// 
			// columnGrades
			// 
			columnGrades.Text = "Điểm";
			columnGrades.Width = 100;
			// 
			// labelAvg
			// 
			labelAvg.AutoSize = true;
			labelAvg.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelAvg.Location = new Point(256, 122);
			labelAvg.Name = "labelAvg";
			labelAvg.Size = new Size(216, 35);
			labelAvg.TabIndex = 3;
			labelAvg.Text = "Điểm Trung Bình";
			// 
			// labelMax
			// 
			labelMax.AutoSize = true;
			labelMax.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelMax.Location = new Point(256, 168);
			labelMax.Name = "labelMax";
			labelMax.Size = new Size(194, 35);
			labelMax.TabIndex = 4;
			labelMax.Text = "Điểm Cao Nhất";
			// 
			// labelMin
			// 
			labelMin.AutoSize = true;
			labelMin.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelMin.Location = new Point(257, 214);
			labelMin.Name = "labelMin";
			labelMin.Size = new Size(209, 35);
			labelMin.TabIndex = 5;
			labelMin.Text = "Điểm Thấp Nhất";
			// 
			// labelGrade
			// 
			labelGrade.AutoSize = true;
			labelGrade.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelGrade.Location = new Point(256, 260);
			labelGrade.Name = "labelGrade";
			labelGrade.Size = new Size(116, 35);
			labelGrade.TabIndex = 6;
			labelGrade.Text = "Xếp Loại";
			// 
			// labelPassed
			// 
			labelPassed.AutoSize = true;
			labelPassed.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelPassed.Location = new Point(256, 306);
			labelPassed.Name = "labelPassed";
			labelPassed.Size = new Size(157, 35);
			labelPassed.TabIndex = 7;
			labelPassed.Text = "Số Môn Đậu";
			// 
			// labelFailed
			// 
			labelFailed.AutoSize = true;
			labelFailed.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelFailed.Location = new Point(256, 352);
			labelFailed.Name = "labelFailed";
			labelFailed.Size = new Size(151, 35);
			labelFailed.TabIndex = 8;
			labelFailed.Text = "Số Môn Rớt";
			// 
			// textBoxAvg
			// 
			textBoxAvg.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxAvg.Location = new Point(478, 122);
			textBoxAvg.Name = "textBoxAvg";
			textBoxAvg.ReadOnly = true;
			textBoxAvg.Size = new Size(142, 40);
			textBoxAvg.TabIndex = 9;
			// 
			// textBoxMax
			// 
			textBoxMax.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxMax.Location = new Point(478, 168);
			textBoxMax.Name = "textBoxMax";
			textBoxMax.ReadOnly = true;
			textBoxMax.Size = new Size(142, 40);
			textBoxMax.TabIndex = 10;
			// 
			// textBoxMin
			// 
			textBoxMin.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxMin.Location = new Point(478, 214);
			textBoxMin.Name = "textBoxMin";
			textBoxMin.ReadOnly = true;
			textBoxMin.Size = new Size(142, 40);
			textBoxMin.TabIndex = 11;
			// 
			// textBoxGrades
			// 
			textBoxGrades.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxGrades.Location = new Point(478, 260);
			textBoxGrades.Name = "textBoxGrades";
			textBoxGrades.ReadOnly = true;
			textBoxGrades.Size = new Size(142, 40);
			textBoxGrades.TabIndex = 12;
			// 
			// textBoxPass
			// 
			textBoxPass.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxPass.Location = new Point(478, 306);
			textBoxPass.Name = "textBoxPass";
			textBoxPass.ReadOnly = true;
			textBoxPass.Size = new Size(142, 40);
			textBoxPass.TabIndex = 13;
			// 
			// textBoxFail
			// 
			textBoxFail.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxFail.Location = new Point(478, 352);
			textBoxFail.Name = "textBoxFail";
			textBoxFail.ReadOnly = true;
			textBoxFail.Size = new Size(142, 40);
			textBoxFail.TabIndex = 14;
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelTitle.Location = new Point(362, 9);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(137, 35);
			labelTitle.TabIndex = 15;
			labelTitle.Text = "Tính Điểm";
			// 
			// buttonCalc
			// 
			buttonCalc.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCalc.Location = new Point(641, 158);
			buttonCalc.Name = "buttonCalc";
			buttonCalc.Size = new Size(122, 45);
			buttonCalc.TabIndex = 16;
			buttonCalc.Text = "Tính";
			buttonCalc.UseVisualStyleBackColor = true;
			buttonCalc.Click += buttonCalc_Click;
			// 
			// buttonReset
			// 
			buttonReset.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonReset.Location = new Point(641, 250);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(122, 45);
			buttonReset.TabIndex = 17;
			buttonReset.Text = "Đặt Lại";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.Click += buttonReset_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(641, 342);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(122, 45);
			buttonExit.TabIndex = 18;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// Ex6
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(808, 434);
			Controls.Add(buttonExit);
			Controls.Add(buttonReset);
			Controls.Add(buttonCalc);
			Controls.Add(labelTitle);
			Controls.Add(textBoxFail);
			Controls.Add(textBoxPass);
			Controls.Add(textBoxGrades);
			Controls.Add(textBoxMin);
			Controls.Add(textBoxMax);
			Controls.Add(textBoxAvg);
			Controls.Add(labelFailed);
			Controls.Add(labelPassed);
			Controls.Add(labelGrade);
			Controls.Add(labelMin);
			Controls.Add(labelMax);
			Controls.Add(labelAvg);
			Controls.Add(listViewScores);
			Controls.Add(labelInputScores);
			Controls.Add(textBoxInputScores);
			Name = "Ex6";
			Text = "Bài 6";
			FormClosed += Ex6_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxInputScores;
		private Label labelInputScores;
		private ListView listViewScores;
		private Label labelAvg;
		private Label labelMax;
		private Label labelMin;
		private Label labelGrade;
		private Label labelPassed;
		private Label labelFailed;
		private TextBox textBoxAvg;
		private TextBox textBoxMax;
		private TextBox textBoxMin;
		private TextBox textBoxGrades;
		private TextBox textBoxPass;
		private TextBox textBoxFail;
		private Label labelTitle;
		private Button buttonCalc;
		private Button buttonReset;
		private Button buttonExit;
		private ColumnHeader columnSubject;
		private ColumnHeader columnGrades;
	}
}