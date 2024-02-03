using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class OrderRowEntity
{
    public int Id { get; set; }
    public int OrderId { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal RowPrice { get; set; }

    public virtual OrderEntity Order {  get; set; } = null!;
}