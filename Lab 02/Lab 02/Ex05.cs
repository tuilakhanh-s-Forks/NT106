using System.IO.Compression;

namespace Lab_02
{
	public partial class Ex05 : Form
	{
		public Ex05()
		{
			InitializeComponent();
		}

		private void buttonExtractPath_Click(object sender, EventArgs e)
		{
			try
			{
				var openFileDialog = new OpenFileDialog
				{
					Filter = "Zip Files| *.zip"
				};
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					textBoxExtractPath.Text = openFileDialog.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonExtract_Click(object sender, EventArgs e)
		{
			var zipPath = textBoxExtractPath.Text;
			if (string.IsNullOrEmpty(zipPath))
			{
				MessageBox.Show("Please input zip path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!File.Exists(zipPath))
			{
				MessageBox.Show("File not exited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var outputPath = Path.GetDirectoryName(textBoxExtractPath.Text);
			Extract(zipPath, outputPath);
		}

		private void buttonCompressPath_Click(object sender, EventArgs e)
		{
			try
			{
				var openFileDialog = new OpenFileDialog
				{
					Filter = "Txt Files| *.txt"
				};
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					textBoxFilePath.Text = openFileDialog.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonCompress_Click(object sender, EventArgs e)
		{
			var filePath = textBoxFilePath.Text;
			if (string.IsNullOrEmpty(filePath))
			{
				MessageBox.Show("Please input zip path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!File.Exists(filePath))
			{
				MessageBox.Show("File not exited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var outputPath = $@"{Path.GetDirectoryName(filePath)}\{Path.GetFileNameWithoutExtension(filePath)}.zip";
			Compress(textBoxFilePath.Text, outputPath);
		}

		private void Extract(string zipPath, string outputPath)
		{
			try
			{
				var zipArchive = ZipFile.OpenRead(zipPath);

				// Calculate total size of all entries in the archive
				long totalSize = 0;
				foreach (var entry in zipArchive.Entries)
				{
					totalSize += entry.Length;
				}

				progressBar.Value = 0;
				progressBar.Maximum = 100;

				this.Enabled = false;
				int progress = 0;
				foreach (var entry in zipArchive.Entries)
				{
					string extractPath = Path.Combine(outputPath, entry.FullName);

					// Create directory if necessary
					if (entry.FullName.EndsWith("/"))
					{
						Directory.CreateDirectory(extractPath);
						continue;
					}

					if (File.Exists(extractPath))
					{
						var result = MessageBox.Show($"Do you want to replace {entry.Name}?", "Replace File", MessageBoxButtons.YesNo);
						if (result == DialogResult.No) continue;
					}

					entry.ExtractToFile(extractPath, true);

					double progressPercentage = entry.Length * 100 / totalSize;
					progress += (int)Math.Floor(progressPercentage);
					progressBar.Value = progress;
				}
				MessageBox.Show($"Extracted file to {outputPath}");
				this.Enabled = true;
			}
			catch (Exception ex)
			{
				this.Enabled = true;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Compress(string filePath, string outputPath)
		{
			if (File.Exists(outputPath))
			{
				var result = MessageBox.Show($"The file '{outputPath}' already exists. Do you want to replace it?", "Confirm file replacement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.No)
				{
					return;
				}
			}

			try
			{
				this.Enabled = false;
				using (FileStream sourceStream = new FileStream(filePath, FileMode.Open))
				{
					using (FileStream destinationStream = new FileStream(outputPath, FileMode.Create))
					{
						using (ZipArchive archive = new ZipArchive(destinationStream, ZipArchiveMode.Create))
						{
							ZipArchiveEntry entry = archive.CreateEntry(Path.GetFileName(filePath), CompressionLevel.Optimal);

							using (Stream entryStream = entry.Open())
							{
								byte[] buffer = new byte[4096];
								long totalBytesRead = 0;
								int bytesRead = 0;

								while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
								{
									entryStream.Write(buffer, 0, bytesRead);

									totalBytesRead += bytesRead;

									// Report progress
									double progressPercentage = (double)totalBytesRead / sourceStream.Length * 100;
									progressBar.Value = (int)progressPercentage;
									Application.DoEvents();
								}
							}
						}
					}
				}
				this.Enabled = true;
				MessageBox.Show($"Compressed file to {outputPath}");
			}
			catch (Exception ex)
			{
				this.Enabled = true;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Ex05_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}