using FurnitureShop.Data;
using FurnitureShop.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Tests
{
	public class MaterialRepositoryTests
	{
		private DbContextOptions<Context> _dbContextOptions;

		public MaterialRepositoryTests()
		{
			_dbContextOptions = new DbContextOptionsBuilder<Context>()
				.UseInMemoryDatabase(databaseName: $"FurnitureShopTestDb_{Guid.NewGuid()}")
				.Options;
		}

		private Context CreateContext() => new Context(_dbContextOptions);

		[Fact]
		public void AddMaterial_ShouldAddNewMaterial()
		{
			// Arrange
			using var context = CreateContext();
			var repository = new MaterialRepository(context);
			var materialName = "Wood";
			var unitPrice = 10.5f;
			var qtyInStock = 100f;
			var minQty = 10f;
			var qtyInPack = 50f;
			var uom = "kg";
			var materialTypeId = 1;

			// Act
			repository.Add(materialName, unitPrice, qtyInStock, minQty, qtyInPack, uom, materialTypeId);

			// Assert
			var material = context.Materials.SingleOrDefault(m => m.Name == materialName);
			Assert.NotNull(material);
			Assert.Equal(materialName, material.Name);
			Assert.Equal(unitPrice, material.UnitPrice);
			Assert.Equal(qtyInStock, material.QuantityInStock);
		}

		[Fact]
		public void EditMaterial_ShouldUpdateExistingMaterial()
		{
			// Arrange
			using var context = CreateContext();
			var repository = new MaterialRepository(context);
			var material = new Material
			{
				Name = "Wood",
				UnitPrice = 10.5f,
				QuantityInStock = 100f,
				MinQuantity = 10f,
				QuantityInPack = 50f,
				MeasurementUnit = "kg",
				MaterialsTypeId = 1
			};

			context.Materials.Add(material);
			context.SaveChanges();

			var updatedName = "Pine Wood";
			var updatedUnitPrice = 12.0f;

			// Act
			repository.Edit(material, updatedName, updatedUnitPrice, material.QuantityInStock, material.MinQuantity, material.QuantityInPack, material.MeasurementUnit, material.MaterialsTypeId);

			// Assert
			var updatedMaterial = context.Materials.SingleOrDefault(m => m.Id == material.Id);
			Assert.NotNull(updatedMaterial);
			Assert.Equal(updatedName, updatedMaterial.Name);
			Assert.Equal(updatedUnitPrice, updatedMaterial.UnitPrice);
		}
	}
}
