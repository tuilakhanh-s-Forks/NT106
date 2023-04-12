namespace Lab_02
{
	public partial class Ex02 : Form
	{
		public Ex02()
		{
			InitializeComponent();
		}

		private async void buttonReadFile_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog()
			{
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var filePath = openFileDialog.FileName;

				try
				{
					var fileInfo = new FileInfo(filePath);

					textBoxFileName.Text = fileInfo.Name;
					textBoxSize.Text = fileInfo.Length.ToString();
					richTextBoxFile.Text = await File.ReadAllTextAsync(filePath);
					textBoxPath.Text = filePath;
					textBoxLines.Text = richTextBoxFile.Lines.Count().ToString();

					var textSplit = richTextBoxFile.Text.Split(new char[] { ' ', '\r', '\n', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
					textBoxWords.Text = textSplit.Length.ToString();
					textBoxCharacters.Text = richTextBoxFile.Text.Length.ToString();
					MessageBox.Show($"Read successfully from {filePath}");
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred while loading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Ex02_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}
