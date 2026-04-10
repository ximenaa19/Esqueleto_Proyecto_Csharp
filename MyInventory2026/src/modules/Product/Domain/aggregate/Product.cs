
using MyInventory2026.src.modules.Product.Domain.valueObject;

namespace MyInventory2026.src.modules.Product.Domain.aggregate;

public class Product
{
    public ProductId Id { get; set; }
    public ProductName Name { get; set; }

    private Product(ProductId id, ProductName name)
    {
        Id = id;
        Name = name;
    }

    public static Product Create(int id, string name)
    {
        return new Product(
            ProductId.Create(id),
            ProductName.Create(name)
        );
    }

}
