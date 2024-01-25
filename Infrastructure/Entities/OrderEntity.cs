using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class OrderEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    //[ForeignKey("Customers")]
    public int CustomerId { get; set; }

    [Required]
    //[ForeignKey("PaymentMethods")]
    public int PaymentMethodId { get; set; }

    [Required]
    //[ForeignKey("DeliveryMethods")]
    public int DeliveryMethodId { get; set; }

    // NAVS
    public virtual ICollection<OrderRowEntity>? OrderRows { get; set; }
    public virtual CustomerEntity Customer { get; set; } = null!;
    public virtual PaymentMethodEntity PaymentMethod { get; set; } = null!;
    public virtual DeliveryMethodEntity DeliveryMethod { get; set; } = null!;
    
}