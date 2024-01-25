using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class CustomerEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Required]
    //[ForeignKey("Addresses")]
    public int AddressId { get; set; }

    //NAVS
    public virtual ICollection<OrderEntity>? Orders { get; set; }
    public virtual AddressEntity Address { get; set; } = null!;
}
