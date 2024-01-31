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

    public override CustomerEntity Update(CustomerEntity entity)
    {
        try
        {
            var oldEntity = _context.Customers.FirstOrDefault(x => x.Id == entity.Id);
            
            if (oldEntity != null)
            {
                oldEntity.FirstName = entity.FirstName;
                oldEntity.LastName = entity.LastName;
                oldEntity.Email = entity.Email;
                oldEntity.AddressId = entity.AddressId;
            }
            _context.SaveChanges();
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }       
}
