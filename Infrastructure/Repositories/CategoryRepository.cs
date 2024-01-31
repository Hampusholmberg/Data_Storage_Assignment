using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Infrastructure.Repositories;

public class CategoryRepository : BaseRepository<Category, ProductCatalogContext>
{
    private readonly ProductCatalogContext _context;
    public CategoryRepository(ProductCatalogContext context) : base(context)
    {
        _context = context;
    }

    public override IEnumerable<Category> GetAll()
    {
        try
        {
            return _context.Categories
                .Include(x => x.SubCategories)
                .ToList();
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }
}
