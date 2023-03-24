using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Ex2 : Form
	{
		public Ex2()
		{
			InitializeComponent();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			textBoxNum1.Text = string.Empty;
			textBoxNum2.Text = string.Empty;
			textBoxNum3.Text = string.Empty;
			textBoxMax.Text = string.Empty;
			textBoxMin.Text = string.Empty;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			int num1, num2, num3;
			if (string.IsNullOrEmpty(textBoxNum1.Text) || string.IsNullOrEmpty(textBoxNum2.Text) || string.IsNullOrEmpty(textBoxNum3.Text))
			{
				MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Int32.TryParse(textBoxNum1.Text, out num1) || !Int32.TryParse(textBoxNum2.Text, out num2) || !Int32.TryParse(textBoxNum3.Text, out num3))
			{
				MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int[] numArray = new int[] { num1, num2, num3 };
			textBoxMin.Text = numArray.Min().ToString();
			textBoxMax.Text = numArray.Max().ToString();
		}

		private void Ex2_FormClosed(object sender, FormClosedEventArgs e)
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
