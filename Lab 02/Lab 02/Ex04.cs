using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Lab_02
{
	public partial class Ex04 : Form
	{
		[Serializable]
		internal class Student
		{
			public string Name { get; set; }
			public int ID { get; set; }
			public string Phone { get; set; }
			public double Score1 { get; set; }
			public double Score2 { get; set; }
			public double Score3 { get; set; }
			public double AverageScore { get; set; }

			public Student() { }

		}



		private List<Student> _students;

		private int _index = 0;

		public Ex04()
		{
			InitializeComponent();
			_students = new List<Student>();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (IsEmpty())
			{
				MessageBox.Show("Please enter the missing information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!IsPhoneValid(textBoxPhoneInput.Text))
			{
				MessageBox.Show("Please input valid phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!IsValidStudentId(textBoxIDInput.Text))
			{
				MessageBox.Show("Please input valid student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!IsValidGrade(textBoxCourse1Input.Text) || !IsValidGrade(textBoxCourse2Input.Text) || !IsValidGrade(textBoxCourse3Input.Text))
			{
				MessageBox.Show("Please input valid grade!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var student = new Student();
			student.Name = textBoxNameInput.Text;
			student.ID = Int32.Parse(textBoxIDInput.Text);
			student.Phone = textBoxPhoneInput.Text;
			student.Score1 = double.Parse(textBoxCourse1Input.Text);
			student.Score2 = double.Parse(textBoxCourse2Input.Text);
			student.Score3 = double.Parse(textBoxCourse3Input.Text);
			student.AverageScore = (student.Score1 + student.Score2 + student.Score3) / 3;
			_students.Add(student);
			ClearTextBoxInput();
			UpdateStatus();
		}

		private static bool IsPhoneValid(string phone)
		{
			return Regex.IsMatch(phone, @"^0\d{9}$");
		}

		private static bool IsValidGrade(string grade)
		{
			if (!double.TryParse(grade, out var gradeNum))
				return false;
			if (gradeNum < 0 || gradeNum > 10)
			{
				return false;
			}
			return true;
		}

		public static bool IsValidStudentId(string id)
		{
			if (!Int32.TryParse(id, out var IDNum))
				return false;
			return IDNum >= 10000000 && IDNum <= 99999999;
		}

		public bool IsEmpty()
		{
			if (string.IsNullOrEmpty(textBoxNameInput.Text) ||
				string.IsNullOrEmpty(textBoxIDInput.Text) ||
				string.IsNullOrEmpty(textBoxPhoneInput.Text) ||
				string.IsNullOrEmpty(textBoxCourse1Input.Text) ||
				string.IsNullOrEmpty(textBoxCourse2Input.Text) ||
				string.IsNullOrEmpty(textBoxCourse3Input.Text))
			{ return true; }
			return false;
		}

		private void ClearTextBoxInput()
		{
			textBoxNameInput.Text = string.Empty;
			textBoxIDInput.Text = string.Empty;
			textBoxPhoneInput.Text = string.Empty;
			textBoxCourse1Input.Text = string.Empty;
			textBoxCourse2Input.Text = string.Empty;
			textBoxCourse3Input.Text = string.Empty;
		}

		private void UpdateOutputTextBox(int index)
		{
			labelIndex.Text = (_index + 1).ToString();
			textBoxNameOutput.Text = _students[index].Name;
			textBoxIDOutput.Text = _students[index].ID.ToString();
			textBoxPhoneOutput.Text = _students[index].Phone;
			textBoxCourse1Output.Text = $"{_students[index].Score1:0.##}";
			textBoxCourse2Output.Text = $"{_students[index].Score2:0.##}";
			textBoxCourse3Output.Text = $"{_students[index].Score3:0.##}";
			textBoxAverageOutput.Text = $"{_students[index].AverageScore:0.##}";
		}

		private void UpdateStatus()
		{
			richTextBoxOutput.Text = string.Empty;
			foreach (var student in _students)
			{
				richTextBoxOutput.Text += $"Name: {student.Name} \nMSSV: {student.ID} \nPhone: {student.Phone} \nCourse 1: {student.Score1:0.##} \nCourse 2: {student.Score2:0.##} \nCourse 3: {student.Score3:0.##} \nAverage score: {student.AverageScore:0.##}\n\n";
			}
			_index = 0;
			UpdateOutputTextBox(_index);
		}

		private void buttonReadTXT_Click(object sender, EventArgs e)
		{
			try
			{
				var openFileDialog = new OpenFileDialog
				{
					Filter = "Txt Files| *.txt"
				};
				string fileContent;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					_students.Clear();
					using (var streamReader = new StreamReader(openFileDialog.FileName))
					{
						while (streamReader.Peek() >= 0)
						{
							var student = new Student();

							student.Name = streamReader.ReadLine();
							student.ID = int.Parse(streamReader.ReadLine());
							student.Phone = streamReader.ReadLine();
							student.Score1 = double.Parse(streamReader.ReadLine());
							student.Score2 = double.Parse(streamReader.ReadLine());
							student.Score3 = double.Parse(streamReader.ReadLine());
							student.AverageScore = (student.Score1 + student.Score2 + student.Score3) / 3;
							_students.Add(student);
							_ = streamReader.ReadLine();
						}
					}
					UpdateStatus();
					MessageBox.Show($"Read file from {openFileDialog.FileName} success");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonWriteBinary_Click(object sender, EventArgs e)
		{
			if (_students.Count == 0)
			{
				MessageBox.Show("Please input student info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				var saveFileDialog = new SaveFileDialog
				{
					Filter = "Dat file|*.dat",
					FileName = "output4.dat"
				};
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					var outputPath = saveFileDialog.FileName;
					using (var fileStream = File.Open(outputPath, FileMode.Create))
					{
						var binaryFormatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
						binaryFormatter.Serialize(fileStream, _students);
#pragma warning restore SYSLIB0011
					}
					MessageBox.Show($"Ghi thành công file tại {outputPath}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonReadBinary_Click(object sender, EventArgs e)
		{
			try
			{
				var openFileDialog = new OpenFileDialog
				{
					Filter = "Dat Files| *.dat"
				};
				string fileContent;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					_students.Clear();
					var outputPath = openFileDialog.FileName;
					using (var fileStream = File.OpenRead(outputPath))
					{
						var formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
						_students = (List<Student>)formatter.Deserialize(fileStream);
#pragma warning restore SYSLIB0011
					}
					UpdateStatus();
					MessageBox.Show($"Read file from {openFileDialog.FileName} success");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			if (_students.Count == 0)
				return;
			if (_index == 0)
				return;
			_index--;
			UpdateOutputTextBox(_index);
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			if (_students.Count == 0)
				return;
			if (_index == _students.Count - 1)
				return;
			_index++;
			UpdateOutputTextBox(_index);
		}

		private void Ex04_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}
