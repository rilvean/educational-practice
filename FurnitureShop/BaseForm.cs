namespace FurnitureShop
{
	public partial class BaseForm : Form
	{
		protected readonly Color mainColor = Color.White;                         // #FFFFFF
		protected readonly Color additionalColor = Color.FromArgb(191, 214, 246); // #BFD6F6
		protected readonly Color accentColor = Color.FromArgb(64, 92, 115);       // #405C73

		protected readonly Font baseFont = new Font("Constantia", 16F, FontStyle.Regular);

		public BaseForm()
		{
			ConfigureForm();
		}

		protected virtual void ConfigureForm()
		{
			Font = baseFont;
			BackColor = mainColor;
			Size = new Size(1200, 800);
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Icon = (Icon?)new System.ComponentModel.ComponentResourceManager(typeof(BaseForm)).GetObject("$this.Icon");
		}

		private void ApplyButtonStyle(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is Button btn)
				{
					btn.BackColor = additionalColor;
					btn.ForeColor = accentColor;
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
					txt.BackColor = additionalColor;
					txt.ForeColor = accentColor;
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
