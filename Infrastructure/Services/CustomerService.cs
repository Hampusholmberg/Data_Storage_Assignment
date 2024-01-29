using Infrastructure.Dtos;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using System.Diagnostics;

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

    // ------------------ CUSTOMERS ------------------ //
    /// <summary>
    /// Checks if customer already exists, if not it will attemp to create it.
    /// </summary>
    /// <param name="customer"></param>
    /// <returns>a status message as a string value.</returns>
    public string CreateCustomer(CustomerDto customer)
    {
        try
        {
            // Checks if customer already exists
            if (!_customerRepository.Exists(
                x => x.FirstName == customer.FirstName &&
                     x.LastName == customer.LastName &&
                     x.Email == customer.Email
            ))
            {
                // Checks if address already exists
                if (!_addressRepository.Exists(
                x => x.StreetName == customer.StreetName &&
                     x.PostalCode == customer.PostalCode &&
                     x.City == customer.City
            ))
                {
                    _addressRepository.Create(customer);
                    var result = _addressRepository.GetOne(x => x.StreetName == customer.StreetName && x.PostalCode == customer.PostalCode && x.City == customer.City);
                    customer.AddressId = result.Id;

                    try
                    {
                        _customerRepository.Create(customer);
                        return "Customer was created successfully.";
                    }
                    catch { return "Something went wrong, customer was not created."; }
                }
                else
                {
                    var result = _addressRepository.GetOne(x => x.StreetName == customer.StreetName && x.PostalCode == customer.PostalCode && x.City == customer.City);
                    customer.AddressId = result.Id;

                    try
                    {
                        _customerRepository.Create(customer);
                        return "Customer was created successfully.";
                    }
                    catch { return "Something went wrong, customer was not created."; }
                }
            }
            else
            return "Customer already exists.";                
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); return "Something went wrong, customer was not created."; }
    }

    /// <summary>
    /// Deletes a customer from the database.
    /// </summary>
    /// <param name="customer"></param>
    /// <returns>a status message as a string value.</returns>
    public string DeleteCustomer(CustomerEntity customer)
    {
        try
        {
            //Get AddressId
            //var result = _addressRepository.GetOne(x => x.StreetName == customer.StreetName && x.PostalCode == customer.PostalCode && x.City == customer.City);
            //customer.AddressId = result!.Id;

            //Get CustomerId
            var customerToDelete = _customerRepository.GetOne(x =>
                x.FirstName == customer.FirstName &&
                x.LastName == customer.LastName &&
                x.AddressId == customer.AddressId);

            var delete_result = _customerRepository.Delete(customerToDelete!);

            if (delete_result)
            {
                return "Customer successfully removed.";
            }
            else return "Something went wrong. Customer was not removed.";
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return "Something went wrong. Customer was not removed.";
    }

    /// <summary>
    /// Gets all the customers from the database.
    /// </summary>
    /// <returns>a list of customer along with their respective address.</returns>
    public IEnumerable<CustomerEntity> GetAllCustomers()
    {
        var customers = _customerRepository.GetAll();
        return customers;
    }
}