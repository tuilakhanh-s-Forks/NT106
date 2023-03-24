namespace Lab1
{
	partial class Ex1
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
			textBoxNum1 = new TextBox();
			textBoxNum2 = new TextBox();
			groupBoxInput = new GroupBox();
			labelInput2 = new Label();
			labelInput1 = new Label();
			label1 = new Label();
			textBoxSum = new TextBox();
			labelSum = new Label();
			btnCal = new Button();
			buttonExit = new Button();
			buttonDelete = new Button();
			groupBoxInput.SuspendLayout();
			SuspendLayout();
			// 
			// textBoxNum1
			// 
			textBoxNum1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxNum1.Location = new Point(202, 46);
			textBoxNum1.Name = "textBoxNum1";
			textBoxNum1.Size = new Size(428, 40);
			textBoxNum1.TabIndex = 0;
			// 
			// textBoxNum2
			// 
			textBoxNum2.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxNum2.Location = new Point(202, 98);
			textBoxNum2.Name = "textBoxNum2";
			textBoxNum2.Size = new Size(428, 40);
			textBoxNum2.TabIndex = 1;
			// 
			// groupBoxInput
			// 
			groupBoxInput.Controls.Add(labelInput2);
			groupBoxInput.Controls.Add(labelInput1);
			groupBoxInput.Controls.Add(textBoxNum1);
			groupBoxInput.Controls.Add(textBoxNum2);
			groupBoxInput.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBoxInput.Location = new Point(47, 96);
			groupBoxInput.Name = "groupBoxInput";
			groupBoxInput.Size = new Size(707, 166);
			groupBoxInput.TabIndex = 9;
			groupBoxInput.TabStop = false;
			groupBoxInput.Text = "Nhập";
			// 
			// labelInput2
			// 
			labelInput2.AutoSize = true;
			labelInput2.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelInput2.Location = new Point(28, 98);
			labelInput2.Name = "labelInput2";
			labelInput2.Size = new Size(142, 35);
			labelInput2.TabIndex = 3;
			labelInput2.Text = "Số Thứ Hai";
			// 
			// labelInput1
			// 
			labelInput1.AutoSize = true;
			labelInput1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelInput1.Location = new Point(28, 46);
			labelInput1.Name = "labelInput1";
			labelInput1.Size = new Size(163, 35);
			labelInput1.TabIndex = 2;
			labelInput1.Text = "Số Thứ Nhất";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(290, 37);
			label1.Name = "label1";
			label1.Size = new Size(287, 35);
			label1.TabIndex = 8;
			label1.Text = "Tính Tổng 2 Số Nguyên";
			// 
			// textBoxSum
			// 
			textBoxSum.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxSum.Location = new Point(249, 374);
			textBoxSum.Name = "textBoxSum";
			textBoxSum.ReadOnly = true;
			textBoxSum.Size = new Size(428, 40);
			textBoxSum.TabIndex = 7;
			// 
			// labelSum
			// 
			labelSum.AutoSize = true;
			labelSum.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelSum.Location = new Point(75, 374);
			labelSum.Name = "labelSum";
			labelSum.Size = new Size(110, 35);
			labelSum.TabIndex = 11;
			labelSum.Text = "Kết Quả";
			// 
			// btnCal
			// 
			btnCal.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnCal.Location = new Point(372, 297);
			btnCal.Name = "btnCal";
			btnCal.Size = new Size(129, 51);
			btnCal.TabIndex = 10;
			btnCal.Text = "Tính";
			btnCal.UseVisualStyleBackColor = true;
			btnCal.Click += btnCal_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(569, 297);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(129, 51);
			buttonExit.TabIndex = 12;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonDelete.Location = new Point(174, 297);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(129, 51);
			buttonDelete.TabIndex = 13;
			buttonDelete.Text = "Xoá";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// Ex1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonDelete);
			Controls.Add(buttonExit);
			Controls.Add(groupBoxInput);
			Controls.Add(label1);
			Controls.Add(textBoxSum);
			Controls.Add(labelSum);
			Controls.Add(btnCal);
			Name = "Ex1";
			Text = "Bài 1";
			FormClosed += Ex1_FormClosed;
			groupBoxInput.ResumeLayout(false);
			groupBoxInput.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxNum1;
		private TextBox textBoxNum2;
		private GroupBox groupBoxInput;
		private Label labelInput2;
		private Label labelInput1;
		private Label label1;
		private TextBox textBoxSum;
		private Label labelSum;
		private Button btnCal;
		private Button buttonExit;
		private Button buttonDelete;
	}
}