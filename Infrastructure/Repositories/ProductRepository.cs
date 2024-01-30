using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;
public class ProductRepository : BaseRepository<Product, ProductCatalogContext>
{
    public ProductRepository(ProductCatalogContext context) : base(context)
    {
    }
}