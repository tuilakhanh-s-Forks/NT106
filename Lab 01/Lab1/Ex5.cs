using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Ex5 : Form
	{
		public Ex5()
		{
			InitializeComponent();
		}

		public static BigInteger Factorial(int n)
		{
			return Enumerable.Range(1, n).Aggregate(BigInteger.One, (f, x) => f * x);
		}

		public static int Func1(int n)
		{
			return Enumerable.Range(1, n).Sum();
		}

		public static long Func2(int a, int b)
		{
			return Enumerable.Range(1, b).Select(i => (long)Math.Pow(a, i)).Sum();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			int a, b;
			if (string.IsNullOrEmpty(textBoxInputA.Text) || string.IsNullOrEmpty(textBoxInputB.Text))
			{
				MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Int32.TryParse(textBoxInputA.Text, out a) || !Int32.TryParse(textBoxInputB.Text, out b))
			{
				MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (a < 1 || b < 1)
			{
				MessageBox.Show("Vui lòng nhập số nguyên lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			labelFactorialA.Text = Factorial(a).ToString("N0");
			labelFactorialB.Text = Factorial(b).ToString("N0");
			labelS1.Text = Func1(a).ToString("N0");
			labelS2.Text = Func1(b).ToString("N0");
			labelS3.Text = Func2(a, b).ToString("N0");
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			labelFactorialA.Text = string.Empty;
			labelFactorialB.Text = string.Empty;
			labelS1.Text = string.Empty;
			labelS2.Text = string.Empty;
			labelS3.Text = string.Empty;
			textBoxInputA.Text = string.Empty;
			textBoxInputB.Text = string.Empty;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close(); ;
		}

		private void Ex5_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}
