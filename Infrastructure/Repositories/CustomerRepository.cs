using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace Infrastructure.Repositories;

public class CustomerRepository : BaseRepository<CustomerEntity, OrderDbContext>
{
    private readonly OrderDbContext _context;
    public CustomerRepository(OrderDbContext context) : base(context)
    {
        _context = context;
    }

    public override IEnumerable<CustomerEntity> GetAll()
    {
        try
        {
            return _context.Customers.Include(x => x.Address).ToList();
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }

    public CustomerEntity Update(CustomerEntity oldEntity, CustomerEntity newEntity)
    {
        try
        {            
            if (oldEntity != null)
            {
                oldEntity.FirstName = newEntity.FirstName;
                oldEntity.LastName = newEntity.LastName;
                oldEntity.Email = newEntity.Email;
                oldEntity.AddressId = newEntity.AddressId;
            }
            _context.SaveChanges();
            return oldEntity!;
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }       
}
