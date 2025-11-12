namespace FurnitureShop
{
	public partial class BaseForm : Form
	{
		protected readonly Color MainColor = Color.White;                         // #FFFFFF
		protected readonly Color AdditionalColor = Color.FromArgb(191, 214, 246); // #BFD6F6
		protected readonly Color AccentColor = Color.FromArgb(64, 92, 115);       // #405C73

		protected readonly Font BaseFont = new Font("Constantia", 16F, FontStyle.Regular);

		public BaseForm()
		{
			ConfigureForm();
		}

		protected virtual void ConfigureForm()
		{
			Font = BaseFont;
			BackColor = MainColor;
			Size = new Size(1200, 800);
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Icon = Properties.Resources.Icon;
		}

		private void ApplyButtonStyle(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is Button btn)
				{
					btn.BackColor = AdditionalColor;
					btn.ForeColor = AccentColor;
					btn.FlatStyle = FlatStyle.Flat;
					btn.FlatAppearance.BorderSize = 1;
					btn.FlatAppearance.BorderColor = Color.Black;
					btn.Font = new Font("Constantia", 12F, FontStyle.Regular);
				}

				if (c.HasChildren)
					ApplyButtonStyle(c);
			}
		}

		private void ApplyTextBoxStyle(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is TextBox txt)
				{
					txt.BackColor = AdditionalColor;
					txt.ForeColor = AccentColor;
					txt.BorderStyle = BorderStyle.FixedSingle;
					txt.Font = new Font("Constantia", 14F, FontStyle.Regular);
				}

				if (c.HasChildren)
					ApplyTextBoxStyle(c);
			}
		}

		protected void ApplyGlobalStyle()
		{
			ApplyButtonStyle(this);
			ApplyTextBoxStyle(this);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			ApplyGlobalStyle();
		}
	}
}
