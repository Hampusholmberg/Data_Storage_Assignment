using Infrastructure.Entities;
using Infrastructure.Repositories;
using System.Collections.Generic;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly CustomerRepository _customerRepository;

    public OrderService(CustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
}
