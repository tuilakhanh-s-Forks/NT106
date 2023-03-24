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
	public partial class Ex3 : Form
	{
		private static String[] units = {"Không", "Một", "Hai", "Ba", "Bốn",
										"Năm", "Sau", "Bảy", "Tám", "Chín"};

		public Ex3()
		{
			InitializeComponent();
		}

		private void buttonRead_Click(object sender, EventArgs e)
		{
			int num;
			if (string.IsNullOrEmpty(textBoxInput.Text))
			{
				MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Int32.TryParse(textBoxInput.Text, out num))
			{
				MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (num < 0 || num > 9)
			{
				MessageBox.Show("Chỉ nhập số từ 0 đến 9 vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			textBoxResult.Text = units[num];
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			textBoxInput.Text = string.Empty;
			textBoxResult.Text = string.Empty;
		}

		private void Ex3_FormClosed(object sender, FormClosedEventArgs e)
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
