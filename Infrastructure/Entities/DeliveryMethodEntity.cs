using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class DeliveryMethodEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string DeliveryMethodName { get; set; } = null!;

    //NAVS
    public virtual ICollection<OrderEntity>? Orders { get; set; }
}
