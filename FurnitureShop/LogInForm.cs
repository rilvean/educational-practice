using FurnitureShop.Data;

namespace FurnitureShop
{
	public partial class LogInForm : BaseForm
	{
		private int attempts = 0;
		private bool isBlocked = false;
		private DateTime blockEndTime;

		public bool IsAuthenticated { get; set; } = false;
		public User User { get; set; } = null!;

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
			if (isBlocked)
			{
				App.Error("Application blocked. Restart required.");
				return;
			}

			if (blockEndTime != default && DateTime.Now < blockEndTime)
			{
				TimeSpan remaining = blockEndTime - DateTime.Now;
				App.Error($"Application blocked for {remaining.Minutes} min {remaining.Seconds} sec.");
				return;
			}

			string login = txtLogin.Text.Trim();
			string password = txtPassword.Text.Trim();

			using (Context db = new Context())
			{
				var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

				if (user != null)
				{
					if (attempts >= 1)
					{
						if (txtCaptcha.Text.Trim() != App.captcha)
						{
							attempts++;
							App.Error("Captcha incorrect.");
							CheckBlock();
							return;
						}
					}

					LogUser(user, db);
					User = user;
					IsAuthenticated = true;
					Close();
				}
				else
				{
					attempts++;
					pnlCaptcha.Visible = true;
					App.Error("User data incorrect.");
					CheckBlock();
				}
			}
		}

		private void CheckBlock()
		{
			if (attempts == 3)
			{
				App.Error("Application blocked for 3 minutes.");
				blockEndTime = DateTime.Now.AddMinutes(3);
			}
			else if (attempts >= 4)
			{
				App.Error("Application blocked until restart.");
				isBlocked = true;
			}
		}

		private void txt_KeyPress(object sender, KeyPressEventArgs e)
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

		private void LogUser(User user, Context context)
		{
			var entranceLog = new EntranceLog
			{
				UserId = user.Id,
				FullName = user.FullName,
				Role = user.Role,
				LogInTime = DateTime.Now
			};
			context.Add(entranceLog);
			context.SaveChanges();
		}

		private void linkLogInAsGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			User = new User
			{
				FullName = "Гость",
				Role = Roles.Guest
			};
			IsAuthenticated = true;
			Close();
		}
	}
}
