using Infrastructure.Dtos;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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

    public static implicit operator AddressEntity(CustomerDto customer) 
    {
        return new AddressEntity
        {
            StreetName = customer.StreetName,
            PostalCode = customer.PostalCode,
            City = customer.City,
        };
    }
}