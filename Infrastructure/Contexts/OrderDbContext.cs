using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public partial class OrderDbContext(DbContextOptions<OrderDbContext> options) : DbContext(options)
{
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<PaymentMethodEntity> PaymentMethods { get; set; }
    public DbSet<DeliveryMethodEntity> DeliveryMethods { get; set; }
    public DbSet<OrderRowEntity> OrderRows { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Composite key between orders and order rows.
        modelBuilder.Entity<OrderRowEntity>()
            .HasKey(ore => new { ore.Id, ore.OrderId });
        
        modelBuilder.Entity<OrderRowEntity>()
            .HasOne(ore => ore.Order)
            .WithMany(o => o.OrderRows)
            .HasForeignKey(ore => ore.OrderId);


        //Ensures you cannot register duplicates of a customer, where first name, last name and address are all the same. 
        modelBuilder.Entity<CustomerEntity>()
            .HasIndex(x => new { x.FirstName, x.LastName, x.AddressId })
            .IsUnique();

        //Ensures you cannot register duplicates of an address, where street name, postal code and city are all the same. 
        modelBuilder.Entity<AddressEntity>()
            .HasIndex(x => new { x.StreetName, x.PostalCode, x.City })
            .IsUnique();

        //Ensures you cannot register duplicates of delivery methods, where the name is the same. 
        modelBuilder.Entity<DeliveryMethodEntity>()
            .HasIndex(x => x.DeliveryMethodName)
            .IsUnique();

        //Ensures you cannot register duplicates of payment methods, where the name is the same. 
        modelBuilder.Entity<PaymentMethodEntity>()
            .HasIndex(x => x.PaymentMethodName)
            .IsUnique();
    }
}