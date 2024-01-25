using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class SubCategoryRepository : BaseRepository<SubCategoryEntity, ProductCatalogContext>
{
    public SubCategoryRepository(ProductCatalogContext context) : base(context)
    {
    }
}

