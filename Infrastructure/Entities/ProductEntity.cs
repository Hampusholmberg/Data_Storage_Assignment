using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class ProductEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = null!;

    [Required]
    public string Description { get; set; } = null!;

    [Required]
    public decimal Price { get; set; }

    // FK's
    [Required]
    //[ForeignKey("CategoryEntity")]
    public int CategoryId { get; set; }

    [Required]
    //[ForeignKey("SubCategoryEntity")]
    public int SubCategoryId { get; set; }

    [Required]
    //[ForeignKey("BrandEntity")]
    public int BrandId { get; set; }

    //Navs
    public virtual CategoryEntity Category { get; set; } = null!;
    public virtual SubCategoryEntity SubCategory { get; set; } = null!;
    public virtual BrandEntity Brand { get; set; } = null!;
}
