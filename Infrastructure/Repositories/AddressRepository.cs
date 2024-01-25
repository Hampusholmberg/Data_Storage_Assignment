using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class AddressRepository : BaseRepository<AddressEntity, OrderDbContext>
{
    public AddressRepository(OrderDbContext context) : base(context)
    {
    }
}
