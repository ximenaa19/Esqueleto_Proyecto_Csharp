namespace MyInventory2026.src.modules.Product.Domain.valueObject;

public record class ProductName
{
    public string Value { get; }

    private ProductName(string value)
    {
        Value = value;
    }

    public static ProductName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Product name cannot be empty.", nameof(value));
        }

        if (value.Trim().Length < 3)
        {
            throw new ArgumentException("Product name must have at least 3 characters.", nameof(value));
        }

        return new ProductName(value.Trim());
    }

    public override string ToString() => Value;
}
