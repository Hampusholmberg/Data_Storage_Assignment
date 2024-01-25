using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class ProductCatalogContext(DbContextOptions<ProductCatalogContext> options) : DbContext(options)
{
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<BrandEntity> Brands { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<SubCategoryEntity> SubCategories { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    modelBuilder.Entity<ProductEntity>()
    //        .HasIndex(x => x.Title)
    //        .IsUnique();

    //    modelBuilder.Entity<BrandEntity>()
    //        .HasIndex(x => x.BrandName)
    //        .IsUnique();

    //    modelBuilder.Entity<CategoryEntity>()
    //        .HasIndex(x => x.CategoryName)
    //        .IsUnique();

    //    modelBuilder.Entity<SubCategoryEntity>()
    //        .HasIndex(x => x.SubCategoryName)
    //        .IsUnique();
    //}
}