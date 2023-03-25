namespace ChatClient
{
	partial class Client
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
			groupBoxConnection = new GroupBox();
			buttonDisconnect = new Button();
			buttonConnect = new Button();
			textBoxServerPort = new TextBox();
			textBoxServerIP = new TextBox();
			textBoxUsername = new TextBox();
			labelServerPort = new Label();
			labelServerIP = new Label();
			labelUsername = new Label();
			richTextBoxChatLog = new RichTextBox();
			groupBoxMesssage = new GroupBox();
			buttonSend = new Button();
			textBoxMessage = new TextBox();
			buttonExit = new Button();
			groupBoxConnection.SuspendLayout();
			groupBoxMesssage.SuspendLayout();
			SuspendLayout();
			// 
			// groupBoxConnection
			// 
			groupBoxConnection.Controls.Add(buttonDisconnect);
			groupBoxConnection.Controls.Add(buttonConnect);
			groupBoxConnection.Controls.Add(textBoxServerPort);
			groupBoxConnection.Controls.Add(textBoxServerIP);
			groupBoxConnection.Controls.Add(textBoxUsername);
			groupBoxConnection.Controls.Add(labelServerPort);
			groupBoxConnection.Controls.Add(labelServerIP);
			groupBoxConnection.Controls.Add(labelUsername);
			groupBoxConnection.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			groupBoxConnection.Location = new Point(27, 27);
			groupBoxConnection.Name = "groupBoxConnection";
			groupBoxConnection.Size = new Size(653, 185);
			groupBoxConnection.TabIndex = 0;
			groupBoxConnection.TabStop = false;
			groupBoxConnection.Text = "Tuỳ chọn kết nối";
			// 
			// buttonDisconnect
			// 
			buttonDisconnect.Enabled = false;
			buttonDisconnect.Location = new Point(520, 102);
			buttonDisconnect.Name = "buttonDisconnect";
			buttonDisconnect.Size = new Size(112, 59);
			buttonDisconnect.TabIndex = 7;
			buttonDisconnect.Text = "Ngắt Kết Nối";
			buttonDisconnect.UseVisualStyleBackColor = true;
			buttonDisconnect.Click += buttonDisconnect_Click;
			// 
			// buttonConnect
			// 
			buttonConnect.Location = new Point(522, 34);
			buttonConnect.Name = "buttonConnect";
			buttonConnect.Size = new Size(110, 62);
			buttonConnect.TabIndex = 6;
			buttonConnect.Text = "Kết Nối";
			buttonConnect.UseVisualStyleBackColor = true;
			buttonConnect.Click += buttonConnect_Click;
			// 
			// textBoxServerPort
			// 
			textBoxServerPort.Location = new Point(195, 127);
			textBoxServerPort.Name = "textBoxServerPort";
			textBoxServerPort.Size = new Size(297, 32);
			textBoxServerPort.TabIndex = 5;
			// 
			// textBoxServerIP
			// 
			textBoxServerIP.Location = new Point(195, 84);
			textBoxServerIP.Name = "textBoxServerIP";
			textBoxServerIP.Size = new Size(297, 32);
			textBoxServerIP.TabIndex = 4;
			// 
			// textBoxUsername
			// 
			textBoxUsername.Location = new Point(195, 34);
			textBoxUsername.Name = "textBoxUsername";
			textBoxUsername.Size = new Size(297, 32);
			textBoxUsername.TabIndex = 3;
			// 
			// labelServerPort
			// 
			labelServerPort.AutoSize = true;
			labelServerPort.Location = new Point(32, 130);
			labelServerPort.Name = "labelServerPort";
			labelServerPort.Size = new Size(111, 24);
			labelServerPort.TabIndex = 2;
			labelServerPort.Text = "Server Port";
			// 
			// labelServerIP
			// 
			labelServerIP.AutoSize = true;
			labelServerIP.Location = new Point(32, 87);
			labelServerIP.Name = "labelServerIP";
			labelServerIP.Size = new Size(91, 24);
			labelServerIP.TabIndex = 1;
			labelServerIP.Text = "Server IP";
			// 
			// labelUsername
			// 
			labelUsername.AutoSize = true;
			labelUsername.Location = new Point(32, 42);
			labelUsername.Name = "labelUsername";
			labelUsername.Size = new Size(130, 24);
			labelUsername.TabIndex = 0;
			labelUsername.Text = "Tên tài khoản";
			// 
			// richTextBoxChatLog
			// 
			richTextBoxChatLog.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			richTextBoxChatLog.Location = new Point(27, 229);
			richTextBoxChatLog.Name = "richTextBoxChatLog";
			richTextBoxChatLog.ReadOnly = true;
			richTextBoxChatLog.Size = new Size(653, 458);
			richTextBoxChatLog.TabIndex = 1;
			richTextBoxChatLog.Text = "";
			// 
			// groupBoxMesssage
			// 
			groupBoxMesssage.Controls.Add(buttonSend);
			groupBoxMesssage.Controls.Add(textBoxMessage);
			groupBoxMesssage.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			groupBoxMesssage.Location = new Point(27, 704);
			groupBoxMesssage.Name = "groupBoxMesssage";
			groupBoxMesssage.Size = new Size(653, 143);
			groupBoxMesssage.TabIndex = 2;
			groupBoxMesssage.TabStop = false;
			groupBoxMesssage.Text = "Tin Nhắn";
			// 
			// buttonSend
			// 
			buttonSend.Enabled = false;
			buttonSend.Location = new Point(522, 31);
			buttonSend.Name = "buttonSend";
			buttonSend.Size = new Size(110, 93);
			buttonSend.TabIndex = 1;
			buttonSend.Text = "Gửi";
			buttonSend.UseVisualStyleBackColor = true;
			buttonSend.Click += buttonSend_Click;
			// 
			// textBoxMessage
			// 
			textBoxMessage.Location = new Point(16, 31);
			textBoxMessage.Multiline = true;
			textBoxMessage.Name = "textBoxMessage";
			textBoxMessage.Size = new Size(500, 93);
			textBoxMessage.TabIndex = 0;
			textBoxMessage.TextChanged += textBoxMessage_TextChanged;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonExit.Location = new Point(295, 867);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(112, 34);
			buttonExit.TabIndex = 3;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// Client
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(701, 913);
			Controls.Add(buttonExit);
			Controls.Add(groupBoxMesssage);
			Controls.Add(richTextBoxChatLog);
			Controls.Add(groupBoxConnection);
			Name = "Client";
			Text = "Chat Client";
			Load += Client_Load;
			groupBoxConnection.ResumeLayout(false);
			groupBoxConnection.PerformLayout();
			groupBoxMesssage.ResumeLayout(false);
			groupBoxMesssage.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBoxConnection;
		private RichTextBox richTextBoxChatLog;
		private Button buttonDisconnect;
		private Button buttonConnect;
		private TextBox textBoxServerPort;
		private TextBox textBoxServerIP;
		private TextBox textBoxUsername;
		private Label labelServerPort;
		private Label labelServerIP;
		private Label labelUsername;
		private GroupBox groupBoxMesssage;
		private Button buttonSend;
		private TextBox textBoxMessage;
		private Button buttonExit;
	}
}