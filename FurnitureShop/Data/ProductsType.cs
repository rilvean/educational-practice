namespace FurnitureShop.Data;

public partial class ProductsType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float Coefficient { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
