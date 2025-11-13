using FurnitureShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace FurnitureShop
{
	public partial class MainForm : BaseForm
	{
		private User user;
		private List<Material> allMaterials = new();

		public event EventHandler? Logout;
		public bool IsLogout { get; private set; } = false;

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
			if (user.Role == Roles.Guest)
				lblUserInfo.Text += "\nLogin for more options.";

			lblLogo.ForeColor = AccentColor;
			LoadLoginHistory();
			LoadMaterials();
			LoadMaterialsToDataGrid();
			cmbSort.SelectedIndex = 0;

			txtFilterByLogin.Enabled = user.Role != Roles.Guest;
			txtSearch.Enabled = user.Role != Roles.Guest;
			cmbSort.Enabled = user.Role != Roles.Guest;
			cmbMaterialType.Enabled = user.Role != Roles.Guest;

			btnEdit.Enabled = user.Role == Roles.Admin;
			btnAdd.Enabled = user.Role == Roles.Admin;
			btnRemove.Enabled = user.Role == Roles.Admin;
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

		public static void FormatDataGridView(DataGridView dataGridView, Color backColor, Color additionalColor, Color accentColor, Font font,
			bool multiSelect = false, DataGridViewAutoSizeColumnsMode mode = DataGridViewAutoSizeColumnsMode.Fill)
		{
			dataGridView.ReadOnly = true;
			dataGridView.RowHeadersVisible = false;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.AllowUserToResizeColumns = false;
			dataGridView.AllowUserToResizeRows = false;

			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView.MultiSelect = multiSelect;

			dataGridView.AutoSizeColumnsMode = mode;
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

		//
		// LoginHistory
		//
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

		private void txtFilterByLogin_TextChanged(object sender, EventArgs e)
		{
			LoadLoginHistory(txtFilterByLogin.Text.Trim());
		}

		//
		// MaterialsList
		//
		private Panel CreateMaterialCard(Material material, float requiredQuantity = 0)
		{
			Panel card = new Panel
			{
				Width = flowLayoutPanelMaterials.ClientSize.Width - 40,
				Height = 130,
				BorderStyle = BorderStyle.FixedSingle,
				Margin = new Padding(10),
				BackColor = Color.White
			};

			Label lblTitle = new Label
			{
				Text = $"{material.MaterialsType.Name} | {material.Name}",
				Font = new Font(BaseFont.FontFamily, 12F, FontStyle.Bold),
				Location = new Point(10, 8),
				AutoSize = true
			};

			Label lblDetails = new Label
			{
				Text = $"Минимальное количество: {material.MinQuantity}\n" +
					   $"Количество на складе: {material.QuantityInStock}\n" +
					   $"Цена: {material.UnitPrice} р/{material.MeasurementUnit} | Кол-во в упаковке: {material.QuantityInPack}",
				Font = new Font(BaseFont.FontFamily, 12F),
				Location = new Point(10, 35),
				AutoSize = true
			};

			Label lblRequired = new Label
			{
				Text = requiredQuantity > 0 ? $"Требуемое количество:\n{requiredQuantity}" : "null",
				Font = new Font(BaseFont.FontFamily, 12F),
				TextAlign = ContentAlignment.MiddleRight,
				AutoSize = true
			};

			lblRequired.Location = new Point(card.Width - lblRequired.Width - 20, 20);
			lblRequired.Anchor = AnchorStyles.Top | AnchorStyles.Right;

			card.Controls.Add(lblTitle);
			card.Controls.Add(lblDetails);
			card.Controls.Add(lblRequired);

			card.Resize += (s, e) =>
			{
				lblRequired.Location = new Point(card.Width - lblRequired.Width - 20, 20);
			};

			return card;
		}

		private void LoadMaterials()
		{
			using (Context db = new())
			{
				allMaterials = db.Materials
					.Include(m => m.MaterialsType)
					.Include(m => m.MaterialsProducts)
					.ThenInclude(mp => mp.Product)
					.ToList();

				var types = db.MaterialsTypes
					.Select(t => t.Name)
					.ToList();

				cmbMaterialType.Items.Clear();
				cmbMaterialType.Items.Add("Все типы");
				cmbMaterialType.Items.AddRange(types.ToArray());
				cmbMaterialType.SelectedIndex = 0;
			}

			DisplayMaterials(allMaterials);
		}

		private void DisplayMaterials(IEnumerable<Material> materials)
		{
			flowLayoutPanelMaterials.SuspendLayout();
			flowLayoutPanelMaterials.Controls.Clear();

			foreach (var material in materials)
			{
				float requiredQty = material.MaterialsProducts.FirstOrDefault()?.RequiredQuantityMaterial ?? 0;
				var card = CreateMaterialCard(material, requiredQty);
				flowLayoutPanelMaterials.Controls.Add(card);
			}

			flowLayoutPanelMaterials.ResumeLayout();
		}

		private void ApplyFiltersAndSorting()
		{
			string query = txtSearch.Text.Trim().ToLower();
			var words = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);

			var filtered = allMaterials.Where(m =>
				words.All(word =>
					(m.Name?.ToLower().Contains(word) ?? false) ||
					(m.MaterialsType?.Name?.ToLower().Contains(word) ?? false)
				)
			);

			string? selectedType = cmbMaterialType.SelectedItem?.ToString();
			if (!string.IsNullOrEmpty(selectedType) && selectedType != "Все типы")
			{
				filtered = filtered.Where(m => m.MaterialsType?.Name == selectedType);
			}

			switch (cmbSort.SelectedIndex)
			{
				case 1:
					filtered = filtered.OrderBy(m => m.QuantityInStock);
					break;
				case 2:
					filtered = filtered.OrderByDescending(m => m.QuantityInStock);
					break;
			}

			DisplayMaterials(filtered.ToList());
		}


		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			ApplyFiltersAndSorting();
		}

		private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			ApplyFiltersAndSorting();
		}

		private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
		{
			ApplyFiltersAndSorting();
		}

		//
		// MaterialsManagement
		//
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dataMaterials.SelectedRows.Count != 1)
			{
				App.Error("Выберите только один материал для редактирования.");
				return;
			}

			int selectedId = (int)dataMaterials.SelectedRows[0].Cells["Id"].Value;

			using (var db = new Context())
			{
				var material = db.Materials
					.Include(m => m.MaterialsType)
					.FirstOrDefault(m => m.Id == selectedId);

				if (material == null)
				{
					App.Error("Материал не найден.");
					return;
				}

				var form = new MaterialForm(material);
				if (form.ShowDialog() == DialogResult.OK)
				{
					LoadMaterialsToDataGrid();
					LoadMaterials();
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var form = new MaterialForm(null);
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadMaterialsToDataGrid();
				LoadMaterials();
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Delete selected materials?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
				return;

			using (var db = new Context())
			{
				foreach (DataGridViewRow row in dataMaterials.SelectedRows)
				{
					int id = (int)row.Cells["Id"].Value;
					var material = db.Materials.Find(id);
					if (material != null)
					{
						db.Materials.Remove(material);
					}
				}
				db.SaveChanges();
			}

			LoadMaterialsToDataGrid();
			LoadMaterials();
		}

		private void LoadMaterialsToDataGrid()
		{
			FormatDataGridView(dataMaterials, MainColor, AdditionalColor, AccentColor, Font, true, DataGridViewAutoSizeColumnsMode.AllCells);

			using (var db = new Context())
			{
				var materials = db.Materials
					.Include(m => m.MaterialsType)
					.Select(m => new
					{
						m.Id,
						m.Name,
						Type = m.MaterialsType.Name,
						m.UnitPrice,
						m.QuantityInStock,
						m.MinQuantity,
						m.QuantityInPack,
						m.MeasurementUnit
					})
					.ToList();

				dataMaterials.DataSource = materials;
				dataMaterials.AutoResizeColumns();
				dataMaterials.AutoResizeRows();
			}
		}
	}
}
