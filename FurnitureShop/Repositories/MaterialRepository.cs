using FurnitureShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Repositories
{
	public class MaterialRepository
	{
		private readonly Context? _context;

		public MaterialRepository(Context context)
		{
			_context = context;
		}

		public void Add(string name, float unitPrice, float qtyInStock, float minQty, float qtyInPack, string uom, int mTypeId)
		{
			var newMaterial = new Material
			{
				Name = name,
				UnitPrice = unitPrice,
				QuantityInStock = qtyInStock,
				MinQuantity = minQty,
				QuantityInPack = qtyInPack,
				MeasurementUnit = uom,
				MaterialsTypeId = mTypeId
			};

			_context!.Materials.Add(newMaterial);
			_context!.SaveChanges();
		}

		public void Edit(Material material, string name, float unitPrice, float qtyInStock, float minQty, float qtyInPack, string uom, int mTypeId)
		{
			_context!.Materials
				.Where(m => m.Id == material.Id)
				.ExecuteUpdate(s => s
				.SetProperty(p => p.Name, name)
				.SetProperty(p => p.UnitPrice, unitPrice)
				.SetProperty(p => p.QuantityInStock, qtyInStock)
				.SetProperty(p => p.MinQuantity, minQty)
				.SetProperty(p => p.QuantityInPack, qtyInPack)
				.SetProperty(p => p.MeasurementUnit, uom)
				.SetProperty(p => p.MaterialsTypeId, mTypeId));
			_context!.SaveChanges();
		}
	}
}
