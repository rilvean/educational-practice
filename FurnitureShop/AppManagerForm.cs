using FurnitureShop.Data;

namespace FurnitureShop
{
	public partial class AppManagerForm : Form
	{
		public AppManagerForm()
		{
			WindowState = FormWindowState.Minimized;
			Load += (s, e) => { Hide(); };

			Load += AppManagerLoad;
		}

		private void AppManagerLoad(object? sender, EventArgs e)
		{
			ShowLoginForm();
		}

		private void ShowLoginForm()
		{
			LogInForm loginForm = new LogInForm();
			loginForm.Show();

			loginForm.FormClosed += (s, args) =>
			{
				if (loginForm.IsAuthenticated)
					ShowMainForm(loginForm.User);
				else
					Close();
			};
		}

		private void ShowMainForm(User user)
		{
			MainForm mainForm = new MainForm(user);
			mainForm.Show();

			mainForm.Logout += (s, args) =>
			{
				mainForm.Close();
				ShowLoginForm();
			};

			mainForm.FormClosed += (s, args) =>
			{
				if (!mainForm.IsLogout)
					Close();
			};
		}
	}
}
