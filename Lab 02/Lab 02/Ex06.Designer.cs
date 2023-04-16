namespace Lab_02
{
	partial class Ex06
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex06));
			treeViewExplorer = new TreeView();
			imageList = new ImageList(components);
			groupBoxFileConten = new GroupBox();
			richTextBoxFile = new RichTextBox();
			pictureBoxFile = new PictureBox();
			groupBoxFileConten.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFile).BeginInit();
			SuspendLayout();
			// 
			// treeViewExplorer
			// 
			treeViewExplorer.ImageIndex = 0;
			treeViewExplorer.ImageList = imageList;
			treeViewExplorer.Location = new Point(30, 33);
			treeViewExplorer.Name = "treeViewExplorer";
			treeViewExplorer.SelectedImageIndex = 0;
			treeViewExplorer.Size = new Size(459, 811);
			treeViewExplorer.TabIndex = 0;
			treeViewExplorer.AfterSelect += treeViewExplorer_AfterSelect;
			// 
			// imageList
			// 
			imageList.ColorDepth = ColorDepth.Depth8Bit;
			imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
			imageList.TransparentColor = Color.Transparent;
			imageList.Images.SetKeyName(0, "icons8-folder-48.png");
			imageList.Images.SetKeyName(1, "icons8-file-64.png");
			// 
			// groupBoxFileConten
			// 
			groupBoxFileConten.Controls.Add(richTextBoxFile);
			groupBoxFileConten.Controls.Add(pictureBoxFile);
			groupBoxFileConten.Location = new Point(507, 33);
			groupBoxFileConten.Name = "groupBoxFileConten";
			groupBoxFileConten.Size = new Size(812, 811);
			groupBoxFileConten.TabIndex = 1;
			groupBoxFileConten.TabStop = false;
			groupBoxFileConten.Text = "File Content";
			// 
			// richTextBoxFile
			// 
			richTextBoxFile.Location = new Point(29, 42);
			richTextBoxFile.Name = "richTextBoxFile";
			richTextBoxFile.Size = new Size(751, 742);
			richTextBoxFile.TabIndex = 1;
			richTextBoxFile.Text = "";
			richTextBoxFile.Visible = false;
			// 
			// pictureBoxFile
			// 
			pictureBoxFile.Location = new Point(15, 30);
			pictureBoxFile.Name = "pictureBoxFile";
			pictureBoxFile.Size = new Size(778, 766);
			pictureBoxFile.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxFile.TabIndex = 0;
			pictureBoxFile.TabStop = false;
			// 
			// Ex06
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1352, 886);
			Controls.Add(groupBoxFileConten);
			Controls.Add(treeViewExplorer);
			Name = "Ex06";
			Text = "Ex06";
			FormClosed += Ex06_FormClosed;
			Load += Ex06_Load;
			groupBoxFileConten.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBoxFile).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TreeView treeViewExplorer;
		private GroupBox groupBoxFileConten;
		private ImageList imageList;
		private PictureBox pictureBoxFile;
		private RichTextBox richTextBoxFile;
	}
}