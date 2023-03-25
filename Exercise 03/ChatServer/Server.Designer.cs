namespace ChatServer
{
	partial class Server
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
			Exit = new Button();
			richTextBoxStatus = new RichTextBox();
			labelStatus = new Label();
			textBoxPort = new TextBox();
			labelPort = new Label();
			buttonStart = new Button();
			buttonStop = new Button();
			SuspendLayout();
			// 
			// Exit
			// 
			Exit.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			Exit.Location = new Point(763, 561);
			Exit.Name = "Exit";
			Exit.Size = new Size(112, 34);
			Exit.TabIndex = 0;
			Exit.Text = "Thoát";
			Exit.UseVisualStyleBackColor = true;
			// 
			// richTextBoxStatus
			// 
			richTextBoxStatus.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			richTextBoxStatus.Location = new Point(27, 96);
			richTextBoxStatus.Name = "richTextBoxStatus";
			richTextBoxStatus.Size = new Size(848, 432);
			richTextBoxStatus.TabIndex = 1;
			richTextBoxStatus.Text = "";
			// 
			// labelStatus
			// 
			labelStatus.AutoSize = true;
			labelStatus.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelStatus.Location = new Point(27, 46);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(100, 24);
			labelStatus.TabIndex = 2;
			labelStatus.Text = "Trạng thái";
			// 
			// textBoxPort
			// 
			textBoxPort.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxPort.Location = new Point(380, 26);
			textBoxPort.Name = "textBoxPort";
			textBoxPort.Size = new Size(150, 32);
			textBoxPort.TabIndex = 3;
			// 
			// labelPort
			// 
			labelPort.AutoSize = true;
			labelPort.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelPort.Location = new Point(326, 29);
			labelPort.Name = "labelPort";
			labelPort.Size = new Size(48, 24);
			labelPort.TabIndex = 4;
			labelPort.Text = "Port";
			// 
			// buttonStart
			// 
			buttonStart.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonStart.Location = new Point(312, 546);
			buttonStart.Name = "buttonStart";
			buttonStart.Size = new Size(112, 34);
			buttonStart.TabIndex = 5;
			buttonStart.Text = "Bắt Đầu";
			buttonStart.UseVisualStyleBackColor = true;
			buttonStart.Click += buttonStart_Click;
			// 
			// buttonStop
			// 
			buttonStop.Enabled = false;
			buttonStop.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonStop.Location = new Point(490, 546);
			buttonStop.Name = "buttonStop";
			buttonStop.Size = new Size(112, 34);
			buttonStop.TabIndex = 6;
			buttonStop.Text = "Dừng";
			buttonStop.UseVisualStyleBackColor = true;
			buttonStop.Click += buttonStop_Click;
			// 
			// Server
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(902, 607);
			Controls.Add(buttonStop);
			Controls.Add(buttonStart);
			Controls.Add(labelPort);
			Controls.Add(textBoxPort);
			Controls.Add(labelStatus);
			Controls.Add(richTextBoxStatus);
			Controls.Add(Exit);
			Name = "Server";
			Text = "Chat Server";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button Exit;
		private RichTextBox richTextBoxStatus;
		private Label labelStatus;
		private TextBox textBoxPort;
		private Label labelPort;
		private Button buttonStart;
		private Button buttonStop;
	}
}