using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Data;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialsProduct> MaterialsProducts { get; set; }

    public virtual DbSet<MaterialsType> MaterialsTypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsType> ProductsTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlServer("Server=82EY;Database=FurnitureShop;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>(entity =>
        {
            entity.Property(e => e.MeasurementUnit).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.MaterialsType).WithMany(p => p.Materials)
                .HasForeignKey(d => d.MaterialsTypeId)
                .HasConstraintName("FK_Materials_MaterialsType");
        });

        modelBuilder.Entity<MaterialsProduct>(entity =>
        {
            entity.HasOne(d => d.Material).WithMany(p => p.MaterialsProducts)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MaterialsProducts_Materials");

            entity.HasOne(d => d.Product).WithMany(p => p.MaterialsProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MaterialsProducts_Products");
        });

        modelBuilder.Entity<MaterialsType>(entity =>
        {
            entity.ToTable("MaterialsType");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.ProductsType).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductsTypeId)
                .HasConstraintName("FK_Products_ProductsType");
        });

        modelBuilder.Entity<ProductsType>(entity =>
        {
            entity.ToTable("ProductsType");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
