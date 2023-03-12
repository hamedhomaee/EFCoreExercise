using System.ComponentModel.DataAnnotations;

namespace EFCoreExercise.Entities;

public class SellOrder
{
    [Key]
    public Guid SellOrderID { get; set; }

    [Required]
    public string? StockSymbol { get; set; }

    [Required]
    public string? StockName { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime DateAndTimeOfOrder { get; set; }

    [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100000")]
    public uint Quantity { get; set; }

    [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
    public double Price { get; set; }
}