using FurnitureShop.Data;
using FurnitureShop.Repositories;

namespace FurnitureShop
{
	public partial class MaterialForm : BaseForm
	{
		private Material? _externalMaterial;
		private Context context = new Context();
		private MaterialRepository repo;


		public MaterialForm(Material material)
		{
			repo = new MaterialRepository(context);

			InitializeComponent();
			_externalMaterial = material;
			LoadMaterialTypes();
			LoadForm();
		}

		private void LoadMaterialTypes()
		{
			var types = context.MaterialsTypes.ToList();
			cmbType.DataSource = types;
			cmbType.DisplayMember = "Name";
			cmbType.ValueMember = "Id";
		}

		private void LoadForm()
		{
			if (_externalMaterial == null)
			{
				lblId.Text = "new";
			}
			else
			{
				lblId.Text = _externalMaterial.Id.ToString();
				txtName.Text = _externalMaterial.Name;
				txtUnitPrice.Text = _externalMaterial.UnitPrice.ToString();
				txtQtyInStock.Text = _externalMaterial.QuantityInStock.ToString();
				txtMinQty.Text = _externalMaterial.MinQuantity.ToString();
				txtQtyInPack.Text = _externalMaterial.QuantityInPack.ToString();
				txtUoM.Text = _externalMaterial.MeasurementUnit.ToString();
				cmbType.SelectedValue = _externalMaterial.MaterialsTypeId;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text)))
			{
				App.Error("Fill all fields.");
				return;
			}

			if (_externalMaterial == null)
			{
				repo.Add(txtName.Text,
					float.Parse(txtUnitPrice.Text),
					float.Parse(txtQtyInStock.Text),
					float.Parse(txtMinQty.Text),
					float.Parse(txtQtyInPack.Text),
					txtUoM.Text,
					(int)cmbType.SelectedValue!);
			}
			else
			{
				repo.Edit(_externalMaterial,
					txtName.Text,
					float.Parse(txtUnitPrice.Text),
					float.Parse(txtQtyInStock.Text),
					float.Parse(txtMinQty.Text),
					float.Parse(txtQtyInPack.Text),
					txtUoM.Text,
					(int)cmbType.SelectedValue!);
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void txt_NumOnly_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (sender is TextBox tb)
			{
				if (!char.IsControl(e.KeyChar) &&
					!char.IsDigit(e.KeyChar) &&
					e.KeyChar != ',')
				{
					e.Handled = true;
					return;
				}

				if (tb.SelectionStart == 0 && e.KeyChar == ',')
				{
					e.Handled = true;
					return;
				}

				if (e.KeyChar == ',' && tb.Text.Contains(','))
				{
					e.Handled = true;
					return;
				}

				if (tb.Text.Contains(','))
				{
					int commaIndex = tb.Text.IndexOf(',');
					string afterComma = tb.Text.Substring(commaIndex + 1);

					if (tb.SelectionStart > commaIndex && afterComma.Length >= 2)
					{
						e.Handled = true;
					}
				}
			}
		}

	}
}
