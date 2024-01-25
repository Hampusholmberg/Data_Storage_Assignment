using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CategoryEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string CategoryName { get; set; } = null!;

    public virtual ICollection<ProductEntity>? Products { get; set; }
}
