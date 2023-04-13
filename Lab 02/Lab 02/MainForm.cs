namespace Lab_02
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.FormClosed += (sender, e) => Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonEx01_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex01 = new Ex01();
			Ex01.Show();
		}

		private void buttonEx2_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex02 = new Ex02();
			Ex02.Show();
		}

		private void buttonEx3_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex03 = new Ex03();
			Ex03.Show();
		}

		private void buttonEx4_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex04 = new Ex04();
			Ex04.Show();
		}

		private void buttonEx6_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex06 = new Ex06();
			Ex06.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}