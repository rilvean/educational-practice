namespace FurnitureShop
{
	public partial class LogInForm : BaseForm
	{
		public LogInForm()
		{
			InitializeComponent();
			picCaptcha.Image = App.GenerateCaptcha(picCaptcha.Width, picCaptcha.Height);
		}

		private void btnCaptchaRefresh_Click(object sender, EventArgs e)
		{
			picCaptcha.Image = App.GenerateCaptcha(picCaptcha.Width, picCaptcha.Height);
			txtCaptcha.Text = string.Empty;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtCaptcha.Text == App.captcha)
				MessageBox.Show("Верно!");
			else
				MessageBox.Show("Ошибка!");
		}
	}
}
