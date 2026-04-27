using System.ComponentModel.DataAnnotations;

namespace ProductManeger;

public class Product
{[Key]
    public int Id { get; set; }
    public int Articul { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public int QuantityInStock { get; set; }
}