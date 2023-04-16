using System.Data;

namespace Lab_02
{
	public partial class Ex03 : Form
	{
		public Ex03()
		{
			InitializeComponent();
		}

		private string? _path;

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
					_path = Path.GetDirectoryName(openFileDialog.FileName);
					using var streamReader = new StreamReader(openFileDialog.FileName);
					richTextBoxExpression.Text = await streamReader.ReadToEndAsync();
					MessageBox.Show($"Đọc file {openFileDialog.FileName} thành công");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void buttonCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				richTextBoxResult.Text = "";
				foreach (var expression in richTextBoxExpression.Lines)
				{
					var result = new DataTable().Compute(expression, null);
					richTextBoxResult.Text += $"{expression} = {result:0.##}{Environment.NewLine}";
				}
				var outputPath = @$"{_path}\output3.txt";
				await File.WriteAllTextAsync(outputPath, richTextBoxResult.Text);
				MessageBox.Show($"Ghi thành công file tại {outputPath}");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Ex03_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}
