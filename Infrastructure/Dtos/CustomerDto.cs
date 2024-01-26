namespace Infrastructure.Dtos;

public class CustomerDto
{
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set;} = null!;
    public string Email { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public int? AddressId { get; set; }
}
