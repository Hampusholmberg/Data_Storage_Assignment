using System;
using System.Collections.Generic;

namespace Infrastructure.Entities;

public partial class Product
{
    public int ArticleNumber { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public int SubCategoryId { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual SubCategory SubCategory { get; set; } = null!;
}
