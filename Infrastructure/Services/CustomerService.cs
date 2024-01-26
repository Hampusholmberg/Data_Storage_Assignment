using Infrastructure.Dtos;
using Infrastructure.Entities;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class CustomerService
{
    private readonly CustomerRepository _customerRepository;
    private readonly AddressRepository _addressRepository;

    public CustomerService(CustomerRepository customerRepository, AddressRepository addressRepository)
    {
        _customerRepository = customerRepository;
        _addressRepository = addressRepository;
    }


    // Kollar bara om addressen finns för tillfälet!!!
    public bool CreateCustomer(CustomerDto customer)
    {
        
        if (_addressRepository.Exists(x => x.Id == customer.AddressId))
        {
            Console.Clear();
            Console.WriteLine("Exists");
        }
        else 
        {
            Console.Clear();
            Console.WriteLine("Dont exist"); 
        }

        return false;
        Console.ReadKey();
    }
}