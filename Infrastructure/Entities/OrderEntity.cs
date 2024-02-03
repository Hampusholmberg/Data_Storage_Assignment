using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class OrderEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    public int PaymentMethodId { get; set; }

    [Required]
    public int DeliveryMethodId { get; set; }

    public virtual ICollection<OrderRowEntity>? OrderRows { get; set; }
    public virtual CustomerEntity Customer { get; set; } = null!;
    public virtual PaymentMethodEntity PaymentMethod { get; set; } = null!;
    public virtual DeliveryMethodEntity DeliveryMethod { get; set; } = null!;
}