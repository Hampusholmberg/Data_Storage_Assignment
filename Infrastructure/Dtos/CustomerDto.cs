using Infrastructure.Entities;

namespace Infrastructure.Dtos;

public class CustomerDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;
    public string Email { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public int? AddressId { get; set; }
    //public int? Id { get; set; }

    public static implicit operator CustomerDto((CustomerEntity customer, AddressEntity address) source)
    {
        return new CustomerDto
        {
            FirstName = source.customer.FirstName,
            LastName = source.customer.LastName,
            Email = source.customer.Email,
            AddressId = source.customer.AddressId,
            StreetName = source.address.StreetName,
            PostalCode = source.address.PostalCode,
            City = source.address.City,
        };
    }
}
