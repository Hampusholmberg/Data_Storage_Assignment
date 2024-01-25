using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class SubCategoryEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string SubCategoryName { get; set; } = null!;


    [Required]
    //[ForeignKey("CategoryEntity")]
    public int CategoryId { get; set; }

    public virtual ICollection<CategoryEntity>? Categories { get; set; }
    public virtual ICollection<ProductEntity>? Products { get; set; }
}
