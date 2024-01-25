using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class CustomerRepository : BaseRepository<CustomerEntity, OrderDbContext>
{
    public CustomerRepository(OrderDbContext context) : base(context)
    {
    }
}
