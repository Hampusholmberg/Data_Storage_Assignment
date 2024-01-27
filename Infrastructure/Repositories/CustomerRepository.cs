using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
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
}
