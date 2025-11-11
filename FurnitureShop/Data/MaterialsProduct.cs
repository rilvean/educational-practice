namespace FurnitureShop.Data;

public partial class MaterialsProduct
{
    public int Id { get; set; }

    public int? MaterialId { get; set; }

    public int? ProductId { get; set; }

    public float RequiredQuantityMaterial { get; set; }

    public virtual Material? Material { get; set; }

    public virtual Product? Product { get; set; }
}
