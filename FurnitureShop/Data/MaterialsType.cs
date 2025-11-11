namespace FurnitureShop.Data;

public partial class MaterialsType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float MaterialLossPercent { get; set; }

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
