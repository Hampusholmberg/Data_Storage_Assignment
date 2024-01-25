using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class AddressEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string StreetName { get; set; } = null!;

    [Required]
    [MaxLength(6)]
    public string PostalCode { get; set; } = null!;

    [Required]
    [MaxLength(50)]
    public string City { get; set; } = null!;

    //NAVS
    public virtual ICollection<CustomerEntity>? Customers { get; set; }
}
