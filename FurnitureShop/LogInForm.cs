using FurnitureShop.Data;

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
			string login = txtLogin.Text.Trim();
			string password = txtPassword.Text.Trim();

			if (txtCaptcha.Text != App.captcha)
			{
				MessageBox.Show("Неверная капча!");
				return;
			}

			using (Context db = new Context())
			{
				var user = db.Users
					.FirstOrDefault(u => u.Login == login && u.Password == password);

				if (user != null)
				{
					MessageBox.Show($"Добро пожаловать, {user.FullName}!");
				}
				else
				{
					MessageBox.Show("Неверный логин или пароль!");
				}
			}
		}

		private void txt_KeyPress(object sendet, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) &&
				!char.IsLetterOrDigit(e.KeyChar) &&
				!(e.KeyChar == '@'))
			{
				e.Handled = true;
			}
		}
	}
}
