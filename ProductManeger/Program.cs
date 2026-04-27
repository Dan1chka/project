using Microsoft.EntityFrameworkCore;
using ProductManeger;

public class Program
{
    const string ConnectionString = @" Data Source=C:\Users\college\RiderProjects\ProductManeger\product.db;";

    public ProductContext db = new ProductContext(ConnectionString);

    public void AddProduct()
    {


        db.Products.Add(new Product()
        {
            Id = 1,
            Articul = 123412134,
            Name = "Вентилятор Натаха",
            Manufacturer = "Китай",
            Price = 2000,
            QuantityInStock = 6
        });

        db.SaveChanges();
    }

    public void DeleteProduct(ProductContext db)
    {
        var product = db.Products.Find();
    }

    public void UpdateProduct(ProductContext db)
    {
        db.Products.Update(new Product()
        {
            Id = 1,
            Articul = 123412134,
            Name = "Вентилятор Натаха",
            Manufacturer = "Китай",
            Price = 2000,
            QuantityInStock = 7
        });
    }

    public void GetAllProduct(ProductContext db)
    {
        db.Products.
    }
}

