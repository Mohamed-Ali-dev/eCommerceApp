using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Product : BaseEntity
{
    [MaxLength(50)]
    public required string Name { get; set; }
    [MaxLength(500)]
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public required string PictureUrl { get; set; }
    [MaxLength(50)]
    public required string Type { get; set; }
    [MaxLength(50)]
    public required string Brand { get; set; }
    public int Quantity { get; set; }

}
