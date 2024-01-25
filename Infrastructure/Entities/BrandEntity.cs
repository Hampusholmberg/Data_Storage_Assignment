using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class BrandEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string BrandName { get; set; } = null!;

    public virtual ICollection<ProductEntity>? Products { get; set; }
}