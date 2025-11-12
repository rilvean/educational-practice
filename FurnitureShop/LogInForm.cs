using FurnitureShop.Data;
using Microsoft.EntityFrameworkCore;

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

			using (Context db = new Context())
			{
				var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

				if (user != null)
				{
					App.Info($"{user.FullName}, {user.Role}");
					var entranceLog = new EntranceLog
					{
						UserId = user.Id,
						FullName = user.FullName,
						Role = user.Role,
						LogInTime = DateTime.Now
					};
					db.Add(entranceLog);
					db.SaveChanges();
				}
				else
				{
					App.Error("Неверный логин или пароль!");
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

		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
		}
	}
}
