namespace Lab1
{
	partial class Ex4
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
			labelTitle = new Label();
			labelInputMoney = new Label();
			textBoxInputMoney = new TextBox();
			textBoxResultMoney = new TextBox();
			comboBoxUnit = new ComboBox();
			labelResultMoney = new Label();
			labelRateTitle = new Label();
			labelRate = new Label();
			buttonConvert = new Button();
			buttonExit = new Button();
			buttonDelete = new Button();
			SuspendLayout();
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelTitle.Location = new Point(301, 57);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(243, 35);
			labelTitle.TabIndex = 0;
			labelTitle.Text = "Chuyển Đổi Tiền Tệ";
			// 
			// labelInputMoney
			// 
			labelInputMoney.AutoSize = true;
			labelInputMoney.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelInputMoney.Location = new Point(36, 138);
			labelInputMoney.Name = "labelInputMoney";
			labelInputMoney.Size = new Size(188, 35);
			labelInputMoney.TabIndex = 1;
			labelInputMoney.Text = "Số tiền cần đổi";
			// 
			// textBoxInputMoney
			// 
			textBoxInputMoney.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxInputMoney.Location = new Point(230, 132);
			textBoxInputMoney.Name = "textBoxInputMoney";
			textBoxInputMoney.Size = new Size(370, 40);
			textBoxInputMoney.TabIndex = 2;
			// 
			// textBoxResultMoney
			// 
			textBoxResultMoney.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxResultMoney.Location = new Point(230, 301);
			textBoxResultMoney.Name = "textBoxResultMoney";
			textBoxResultMoney.Size = new Size(370, 40);
			textBoxResultMoney.TabIndex = 3;
			// 
			// comboBoxUnit
			// 
			comboBoxUnit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			comboBoxUnit.FormattingEnabled = true;
			comboBoxUnit.Location = new Point(606, 130);
			comboBoxUnit.Name = "comboBoxUnit";
			comboBoxUnit.Size = new Size(174, 43);
			comboBoxUnit.TabIndex = 4;
			comboBoxUnit.SelectedIndexChanged += comboBoxUnit_SelectedIndexChanged;
			// 
			// labelResultMoney
			// 
			labelResultMoney.AutoSize = true;
			labelResultMoney.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelResultMoney.Location = new Point(36, 301);
			labelResultMoney.Name = "labelResultMoney";
			labelResultMoney.Size = new Size(176, 35);
			labelResultMoney.TabIndex = 5;
			labelResultMoney.Text = "Số tiền đã đổi";
			// 
			// labelRateTitle
			// 
			labelRateTitle.AutoSize = true;
			labelRateTitle.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelRateTitle.Location = new Point(36, 375);
			labelRateTitle.Name = "labelRateTitle";
			labelRateTitle.Size = new Size(186, 35);
			labelRateTitle.TabIndex = 6;
			labelRateTitle.Text = "Tỷ giá quy đổi:";
			// 
			// labelRate
			// 
			labelRate.AutoSize = true;
			labelRate.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelRate.Location = new Point(230, 375);
			labelRate.Name = "labelRate";
			labelRate.Size = new Size(0, 35);
			labelRate.TabIndex = 7;
			// 
			// buttonConvert
			// 
			buttonConvert.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonConvert.Location = new Point(221, 217);
			buttonConvert.Name = "buttonConvert";
			buttonConvert.Size = new Size(186, 41);
			buttonConvert.TabIndex = 8;
			buttonConvert.Text = "Chuyển Đổi";
			buttonConvert.UseVisualStyleBackColor = true;
			buttonConvert.Click += buttonConvert_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(651, 369);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(129, 41);
			buttonExit.TabIndex = 9;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonDelete.Location = new Point(454, 217);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(186, 41);
			buttonDelete.TabIndex = 10;
			buttonDelete.Text = "Xoá";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// Ex4
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(820, 442);
			Controls.Add(buttonDelete);
			Controls.Add(buttonExit);
			Controls.Add(buttonConvert);
			Controls.Add(labelRate);
			Controls.Add(labelRateTitle);
			Controls.Add(labelResultMoney);
			Controls.Add(comboBoxUnit);
			Controls.Add(textBoxResultMoney);
			Controls.Add(textBoxInputMoney);
			Controls.Add(labelInputMoney);
			Controls.Add(labelTitle);
			Name = "Ex4";
			Text = "Bài 4";
			FormClosed += Ex4_FormClosed;
			Load += Ex4_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelTitle;
		private Label labelInputMoney;
		private TextBox textBoxInputMoney;
		private TextBox textBoxResultMoney;
		private ComboBox comboBoxUnit;
		private Label labelResultMoney;
		private Label labelRateTitle;
		private Label labelRate;
		private Button buttonConvert;
		private Button buttonExit;
		private Button buttonDelete;
	}
}