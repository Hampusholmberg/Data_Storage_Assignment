using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class PaymentMethodEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string PaymentMethodName { get; set; } = null!;

    public virtual ICollection<OrderEntity>? Orders { get; set; }
}
