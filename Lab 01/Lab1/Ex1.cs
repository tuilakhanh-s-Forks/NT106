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
	public partial class Ex1 : Form
	{
		public Ex1()
		{
			InitializeComponent();
		}

		private void btnCal_Click(object sender, EventArgs e)
		{
			int num1, num2;
			if (string.IsNullOrEmpty(textBoxNum1.Text) || string.IsNullOrEmpty(textBoxNum2.Text))
			{
				MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Int32.TryParse(textBoxNum1.Text, out num1) || !Int32.TryParse(textBoxNum2.Text, out num2))
			{
				MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			textBoxSum.Text = (num1 + num2).ToString();
		}

		private void Ex1_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			textBoxNum1.Text = string.Empty;
			textBoxNum2.Text = string.Empty;
			textBoxSum.Text = string.Empty;
		}
	}
}
