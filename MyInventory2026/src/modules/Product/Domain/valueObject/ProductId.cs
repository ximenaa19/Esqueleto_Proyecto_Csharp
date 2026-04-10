namespace MyInventory2026.src.modules.Product.Domain.valueObject;

public record class ProductId
{
    public int Value{get;}

    private ProductId(int value)
    {
        Value =value;
    }

    public static ProductId Create(int value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Product ID must be a positive integer", nameof(value));
        }
        return new ProductId(value);
    }
    public override string ToString()=> Value.ToString();
}
