namespace Lab1
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonEx1 = new Button();
			buttonEx3 = new Button();
			buttonEx5 = new Button();
			buttonEx6 = new Button();
			buttonEx2 = new Button();
			button6 = new Button();
			buttonExit = new Button();
			SuspendLayout();
			// 
			// buttonEx1
			// 
			buttonEx1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx1.Location = new Point(211, 99);
			buttonEx1.Name = "buttonEx1";
			buttonEx1.Size = new Size(129, 53);
			buttonEx1.TabIndex = 0;
			buttonEx1.Text = "Bài 1";
			buttonEx1.UseVisualStyleBackColor = true;
			buttonEx1.Click += buttonEx1_Click;
			// 
			// buttonEx3
			// 
			buttonEx3.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx3.Location = new Point(211, 202);
			buttonEx3.Name = "buttonEx3";
			buttonEx3.Size = new Size(129, 53);
			buttonEx3.TabIndex = 1;
			buttonEx3.Text = "Bài 3";
			buttonEx3.UseVisualStyleBackColor = true;
			buttonEx3.Click += buttonEx3_Click;
			// 
			// buttonEx5
			// 
			buttonEx5.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx5.Location = new Point(211, 292);
			buttonEx5.Name = "buttonEx5";
			buttonEx5.Size = new Size(129, 53);
			buttonEx5.TabIndex = 2;
			buttonEx5.Text = "Bài 5";
			buttonEx5.UseVisualStyleBackColor = true;
			buttonEx5.Click += buttonEx5_Click;
			// 
			// buttonEx6
			// 
			buttonEx6.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx6.Location = new Point(473, 292);
			buttonEx6.Name = "buttonEx6";
			buttonEx6.Size = new Size(129, 53);
			buttonEx6.TabIndex = 3;
			buttonEx6.Text = "Bài 6";
			buttonEx6.UseVisualStyleBackColor = true;
			buttonEx6.Click += buttonEx6_Click;
			// 
			// buttonEx2
			// 
			buttonEx2.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx2.Location = new Point(473, 99);
			buttonEx2.Name = "buttonEx2";
			buttonEx2.Size = new Size(129, 53);
			buttonEx2.TabIndex = 4;
			buttonEx2.Text = "Bài 2";
			buttonEx2.UseVisualStyleBackColor = true;
			buttonEx2.Click += buttonEx2_Click;
			// 
			// button6
			// 
			button6.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button6.Location = new Point(473, 202);
			button6.Name = "button6";
			button6.Size = new Size(129, 53);
			button6.TabIndex = 5;
			button6.Text = "Bài 4";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(338, 371);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(129, 53);
			buttonExit.TabIndex = 7;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonExit);
			Controls.Add(button6);
			Controls.Add(buttonEx2);
			Controls.Add(buttonEx6);
			Controls.Add(buttonEx5);
			Controls.Add(buttonEx3);
			Controls.Add(buttonEx1);
			Name = "MainForm";
			Text = "Lab1";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button buttonEx1;
		private Button buttonEx3;
		private Button buttonEx5;
		private Button buttonEx6;
		private Button buttonEx2;
		private Button button6;
		private Button buttonExit;
	}
}