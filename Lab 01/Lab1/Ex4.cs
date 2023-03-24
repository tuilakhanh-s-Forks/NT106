using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
	public partial class Ex4 : Form
	{
		private double GetExchangeRate(string currencyCode)
		{
			switch (currencyCode)
			{
				case "USD": return 22.772;
				case "EUR": return 298.132;
				case "GBP": return 31.538;
				case "SGD": return 17.286;
				case "JPY": return 214;
				default: return 0;
			}
		}

		public Ex4()
		{
			InitializeComponent();
		}

		private void buttonConvert_Click(object sender, EventArgs e)
		{
			double amount;
			if (string.IsNullOrEmpty(textBoxInputMoney.Text))
			{
				MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Double.TryParse(textBoxInputMoney.Text, out amount))
			{
				MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(comboBoxUnit.Text))
			{
				MessageBox.Show("Vui lòng chọn đơn vị tiền tệ và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			double vndAmount = amount * GetExchangeRate(comboBoxUnit.Text);
			textBoxResultMoney.Text = vndAmount.ToString("N0").Replace(".", ",") + " VND";
		}

		private void Ex4_Load(object sender, EventArgs e)
		{
			comboBoxUnit.Items.Add("USD");
			comboBoxUnit.Items.Add("EUR");
			comboBoxUnit.Items.Add("GBP");
			comboBoxUnit.Items.Add("SGD");
			comboBoxUnit.Items.Add("JPY");
		}

		private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelRate.Text = "1 " + comboBoxUnit.Text + " = " + GetExchangeRate(comboBoxUnit.Text).ToString().Replace(".", ",") + " VND";
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			textBoxInputMoney.Text = string.Empty;
			textBoxResultMoney.Text = string.Empty;
			labelRate.Text = string.Empty;
			comboBoxUnit.Text = string.Empty;
		}

		private void Ex4_FormClosed(object sender, FormClosedEventArgs e)
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
