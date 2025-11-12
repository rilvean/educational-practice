using FurnitureShop.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

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
			lblUserInfo.ForeColor = AccentColor;
			lblLogo.ForeColor = AccentColor;
			LoadLoginHistory();
		}

		private void LoadLoginHistory(string loginFilter = null!)
		{
			FormatDataGridView(dataLoginHistory, MainColor, AdditionalColor, AccentColor, BaseFont);

			using (Context db = new())
			{
				var query = db.EntranceLogs
					.Select(l => new
					{
						l.LogInTime,
						l.FullName,
						l.Role,
						Login = l.User.Login
					});

				if (!string.IsNullOrEmpty(loginFilter))
				{
					query = query.Where(l => l.Login.Contains(loginFilter));
				}

				var logs = query
					.OrderByDescending(l => l.LogInTime)
					.ToList();

				dataLoginHistory.DataSource = logs;
			}

			dataLoginHistory.AutoResizeColumns();
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

		public static void FormatDataGridView(DataGridView dataGridView, Color backColor, Color additionalColor, Color accentColor, Font font)
		{
			dataGridView.ReadOnly = true;
			dataGridView.RowHeadersVisible = false;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.AllowUserToResizeColumns = false;
			dataGridView.AllowUserToResizeRows = false;

			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView.MultiSelect = false;

			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

			dataGridView.BackgroundColor = backColor;
			dataGridView.BorderStyle = BorderStyle.None;

			dataGridView.EnableHeadersVisualStyles = false;
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = accentColor;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = additionalColor;
			dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
			dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView.ColumnHeadersDefaultCellStyle.ForeColor;

			dataGridView.DefaultCellStyle.SelectionBackColor = additionalColor;
			dataGridView.DefaultCellStyle.SelectionForeColor = accentColor;
		}

		private void txtFilterByLogin_TextChanged(object sender, EventArgs e)
		{
			LoadLoginHistory(txtFilterByLogin.Text.Trim());
		}
	}
}
