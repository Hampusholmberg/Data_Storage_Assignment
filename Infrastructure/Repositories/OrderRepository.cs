using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Infrastructure.Repositories;

public class OrderRepository : BaseRepository<OrderEntity, OrderDbContext>
{
    private readonly OrderDbContext _context;
    public OrderRepository(OrderDbContext context) : base(context)
    {
        _context = context;
    }

    public override IEnumerable<OrderEntity> GetAll()
    {
        try
        {
            return _context.Orders
                .Include(x => x.Customer)
                .Include(x => x.Customer.Address)
                .Include(x => x.DeliveryMethod)
                .Include(x => x.PaymentMethod)
                .Include(x => x.OrderRows)
                .ToList();
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }
}
