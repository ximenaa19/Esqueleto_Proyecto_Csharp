namespace MyInventory2026.src.modules.Product.Domain.valueObject;

public record class ProductCodeInv
{
    public string Value{get;}

    private ProductCodeInv(string value)
    {
        Value =value;
    }

    public static ProductCodeInv Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Product code cannot be empty",nameof(value));
        }
        return new ProductCodeInv(value.Trim());
    }
    public override string ToString()=> Value;

}
