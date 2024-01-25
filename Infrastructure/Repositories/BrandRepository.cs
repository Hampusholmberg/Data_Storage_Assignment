using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class BrandRepository : BaseRepository<BrandEntity, ProductCatalogContext>
{
    public BrandRepository(ProductCatalogContext context) : base(context)
    {
    }
}
