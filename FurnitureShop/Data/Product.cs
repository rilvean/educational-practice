namespace FurnitureShop.Data;

public partial class Product
{
    public int Id { get; set; }

    public int ProductsTypeId { get; set; }

    public string Name { get; set; } = null!;

    public int Article { get; set; }

    public float MinPrice { get; set; }

    public virtual ICollection<MaterialsProduct> MaterialsProducts { get; set; } = new List<MaterialsProduct>();

    public virtual ProductsType ProductsType { get; set; } = null!;
}
