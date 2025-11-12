using FurnitureShop.Data;

namespace FurnitureShop
{
	public partial class MainForm : BaseForm
	{
		public event EventHandler? Logout;
		public bool IsLogout { get; private set; } = false;

		private User user;

		public MainForm(User user)
		{
			InitializeComponent();
			this.user = user;
			Load += MainForm_Load;
		}

		private void MainForm_Load(object? sender, EventArgs e)
		{
			lblUserInfo.Text = $"{user.FullName} ({user.Role})";
		}

		protected override void ConfigureForm()
		{
			base.ConfigureForm();
			BackColor = AdditionalColor;
		}

		private void picLogo_Click(object sender, EventArgs e)
		{
			IsLogout = true;
			Logout?.Invoke(this, EventArgs.Empty);
		}
	}
}
