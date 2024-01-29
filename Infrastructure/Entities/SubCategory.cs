using System;
using System.Collections.Generic;

namespace Infrastructure.Entities;

public partial class SubCategory
{
    public int Id { get; set; }

    public string SubCategoryName { get; set; } = null!;

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
