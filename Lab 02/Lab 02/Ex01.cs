namespace Lab_02
{
	public partial class Ex01 : Form
	{
		public Ex01()
		{
			InitializeComponent();
		}

		private async void buttonReadFile_Click(object sender, EventArgs e)
		{
			try
			{
				var openFileDialog = new OpenFileDialog
				{
					Filter = "Txt Files| *.txt"
				};
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					using var streamReader = new StreamReader(openFileDialog.FileName);
					richTextBoxFile.Text = await streamReader.ReadToEndAsync();
					MessageBox.Show($"Read file from {openFileDialog.FileName}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private async void buttonWriteFile_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(richTextBoxFile.Text))
			{
				MessageBox.Show("Please input file contents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				var saveFileDialog = new SaveFileDialog
				{
					Filter = "Txt Files|*.txt",
					FileName = "output1.txt"
				};
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					var outputPath = saveFileDialog.FileName;
					await File.WriteAllTextAsync(outputPath, richTextBoxFile.Text.ToUpper());
					MessageBox.Show($"Success to write file at {outputPath}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Ex01_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
