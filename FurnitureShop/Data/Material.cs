namespace FurnitureShop.Data;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int MaterialsTypeId { get; set; }

    public float UnitPrice { get; set; }

    public float QuantityInStock { get; set; }

    public float MinQuantity { get; set; }

    public float QuantityInPack { get; set; }

    public string MeasurementUnit { get; set; } = null!;

    public virtual ICollection<MaterialsProduct> MaterialsProducts { get; set; } = new List<MaterialsProduct>();

    public virtual MaterialsType MaterialsType { get; set; } = null!;
}
