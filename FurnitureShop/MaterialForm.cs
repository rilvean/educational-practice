using FurnitureShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FurnitureShop
{
	public partial class MaterialForm : BaseForm
	{
		private Material? _material;
		private readonly Context db = new Context();

		public MaterialForm(Material? material)
		{
			InitializeComponent();
			_material = material;
			LoadMaterialTypes();
			LoadData();
		}

		private void LoadMaterialTypes()
		{
			var types = db.MaterialsTypes.ToList();
			cmbType.DataSource = types;
			cmbType.DisplayMember = "Name";
			cmbType.ValueMember = "Id";
		}

		private void LoadData()
		{
			if (_material == null)
			{
				lblId.Text = "new";
			}
			else
			{
				lblId.Text = _material.Id.ToString();
				txtName.Text = _material.Name;
				txtUnitPrice.Text = _material.UnitPrice.ToString();
				txtQtyInStock.Text = _material.QuantityInStock.ToString();
				txtMinQty.Text = _material.MinQuantity.ToString();
				txtQtyInPack.Text = _material.QuantityInPack.ToString();
				txtUoM.Text = _material.MeasurementUnit.ToString();
				cmbType.SelectedValue = _material.MaterialsTypeId;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text)))
			{
				App.Error("Fill all fields.");
				return;
			}

			if (_material == null)
			{
				var newMaterial = new Material
				{
					Name = txtName.Text,
					UnitPrice = float.Parse(txtUnitPrice.Text),
					QuantityInStock = float.Parse(txtQtyInStock.Text),
					MinQuantity = float.Parse(txtMinQty.Text),
					QuantityInPack = float.Parse(txtQtyInPack.Text),
					MeasurementUnit = txtUoM.Text,
					MaterialsTypeId = (int)cmbType.SelectedValue!
				};

				db.Materials.Add(newMaterial);
			}
			else
			{
				db.Materials
					.Where(m => m.Id == _material.Id)
					.ExecuteUpdate(s => s
					.SetProperty(p => p.Name, txtName.Text)
					.SetProperty(p => p.UnitPrice, float.Parse(txtUnitPrice.Text))
					.SetProperty(p => p.QuantityInStock, float.Parse(txtQtyInStock.Text))
					.SetProperty(p => p.MinQuantity, float.Parse(txtMinQty.Text))
					.SetProperty(p => p.QuantityInPack, float.Parse(txtQtyInPack.Text))
					.SetProperty(p => p.MeasurementUnit, txtUoM.Text)
					.SetProperty(p => p.MaterialsTypeId, (int)cmbType.SelectedValue!));
			}

			db.SaveChanges();
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
