namespace Lab_02
{
	partial class Ex05
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
			buttonExtractPath = new Button();
			textBoxExtractPath = new TextBox();
			buttonExtract = new Button();
			groupBoxExtractArchive = new GroupBox();
			labelPathExtract = new Label();
			groupBoxAddToArchive = new GroupBox();
			labelPathCompress = new Label();
			textBoxFilePath = new TextBox();
			buttonCompress = new Button();
			buttonCompressPath = new Button();
			progressBar = new ProgressBar();
			groupBoxExtractArchive.SuspendLayout();
			groupBoxAddToArchive.SuspendLayout();
			SuspendLayout();
			// 
			// buttonExtractPath
			// 
			buttonExtractPath.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExtractPath.Location = new Point(700, 65);
			buttonExtractPath.Name = "buttonExtractPath";
			buttonExtractPath.Size = new Size(62, 37);
			buttonExtractPath.TabIndex = 3;
			buttonExtractPath.Text = "...";
			buttonExtractPath.UseVisualStyleBackColor = true;
			buttonExtractPath.Click += buttonExtractPath_Click;
			// 
			// textBoxExtractPath
			// 
			textBoxExtractPath.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxExtractPath.Location = new Point(37, 65);
			textBoxExtractPath.Name = "textBoxExtractPath";
			textBoxExtractPath.Size = new Size(658, 37);
			textBoxExtractPath.TabIndex = 4;
			// 
			// buttonExtract
			// 
			buttonExtract.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExtract.Location = new Point(304, 118);
			buttonExtract.Name = "buttonExtract";
			buttonExtract.Size = new Size(135, 47);
			buttonExtract.TabIndex = 5;
			buttonExtract.Text = "Extract";
			buttonExtract.UseVisualStyleBackColor = true;
			buttonExtract.Click += buttonExtract_Click;
			// 
			// groupBoxExtractArchive
			// 
			groupBoxExtractArchive.Controls.Add(labelPathExtract);
			groupBoxExtractArchive.Controls.Add(textBoxExtractPath);
			groupBoxExtractArchive.Controls.Add(buttonExtract);
			groupBoxExtractArchive.Controls.Add(buttonExtractPath);
			groupBoxExtractArchive.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			groupBoxExtractArchive.Location = new Point(45, 243);
			groupBoxExtractArchive.Name = "groupBoxExtractArchive";
			groupBoxExtractArchive.Size = new Size(778, 189);
			groupBoxExtractArchive.TabIndex = 6;
			groupBoxExtractArchive.TabStop = false;
			groupBoxExtractArchive.Text = "Extract Archive";
			// 
			// labelPathExtract
			// 
			labelPathExtract.AutoSize = true;
			labelPathExtract.Location = new Point(26, 32);
			labelPathExtract.Name = "labelPathExtract";
			labelPathExtract.Size = new Size(63, 30);
			labelPathExtract.TabIndex = 6;
			labelPathExtract.Text = "Path";
			// 
			// groupBoxAddToArchive
			// 
			groupBoxAddToArchive.Controls.Add(labelPathCompress);
			groupBoxAddToArchive.Controls.Add(textBoxFilePath);
			groupBoxAddToArchive.Controls.Add(buttonCompress);
			groupBoxAddToArchive.Controls.Add(buttonCompressPath);
			groupBoxAddToArchive.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			groupBoxAddToArchive.Location = new Point(45, 25);
			groupBoxAddToArchive.Name = "groupBoxAddToArchive";
			groupBoxAddToArchive.Size = new Size(778, 189);
			groupBoxAddToArchive.TabIndex = 7;
			groupBoxAddToArchive.TabStop = false;
			groupBoxAddToArchive.Text = "Add to Archive";
			// 
			// labelPathCompress
			// 
			labelPathCompress.AutoSize = true;
			labelPathCompress.Location = new Point(26, 33);
			labelPathCompress.Name = "labelPathCompress";
			labelPathCompress.Size = new Size(63, 30);
			labelPathCompress.TabIndex = 7;
			labelPathCompress.Text = "Path";
			// 
			// textBoxFilePath
			// 
			textBoxFilePath.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxFilePath.Location = new Point(44, 69);
			textBoxFilePath.Name = "textBoxFilePath";
			textBoxFilePath.Size = new Size(651, 37);
			textBoxFilePath.TabIndex = 4;
			// 
			// buttonCompress
			// 
			buttonCompress.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCompress.Location = new Point(304, 123);
			buttonCompress.Name = "buttonCompress";
			buttonCompress.Size = new Size(135, 47);
			buttonCompress.TabIndex = 5;
			buttonCompress.Text = "Compress";
			buttonCompress.UseVisualStyleBackColor = true;
			buttonCompress.Click += buttonCompress_Click;
			// 
			// buttonCompressPath
			// 
			buttonCompressPath.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCompressPath.Location = new Point(701, 69);
			buttonCompressPath.Name = "buttonCompressPath";
			buttonCompressPath.Size = new Size(61, 37);
			buttonCompressPath.TabIndex = 3;
			buttonCompressPath.Text = "...";
			buttonCompressPath.UseVisualStyleBackColor = true;
			buttonCompressPath.Click += buttonCompressPath_Click;
			// 
			// progressBar
			// 
			progressBar.Location = new Point(45, 460);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(778, 34);
			progressBar.TabIndex = 8;
			// 
			// Ex05
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(855, 517);
			Controls.Add(progressBar);
			Controls.Add(groupBoxAddToArchive);
			Controls.Add(groupBoxExtractArchive);
			Name = "Ex05";
			Text = "Exercise 05";
			FormClosed += Ex05_FormClosed;
			groupBoxExtractArchive.ResumeLayout(false);
			groupBoxExtractArchive.PerformLayout();
			groupBoxAddToArchive.ResumeLayout(false);
			groupBoxAddToArchive.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button buttonExtractPath;
		private TextBox textBoxExtractPath;
		private Button buttonExtract;
		private GroupBox groupBoxExtractArchive;
		private Label labelPathExtract;
		private GroupBox groupBoxAddToArchive;
		private Label labelPathCompress;
		private TextBox textBoxFilePath;
		private Button buttonCompress;
		private Button buttonCompressPath;
		private ProgressBar progressBar;
	}
}