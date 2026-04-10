using MyInventory2026.src.modules.Product.Domain.valueObject;
using MyInventory2026.src.modules.Product.Domain.aggregate;

// Alias para resolver el conflicto
using ProductAggregate = MyInventory2026.src.modules.Product.Domain.aggregate.Product;

namespace MyInventory2026.src.modules.Product.Domain.Repositories;

public interface IProductRepository
{
    Task AddAsync(ProductAggregate product, CancellationToken cancellationToken = default);

    Task<ProductAggregate?> FindByIdAsync(ProductId id, CancellationToken cancellationToken = default);

    Task<IReadOnlyCollection<ProductAggregate>> FindAllAsync(CancellationToken cancellationToken = default);

    Task UpdateAsync(ProductAggregate product, CancellationToken cancellationToken = default);

    Task<bool> DeleteByIdAsync(ProductId id, CancellationToken cancellationToken = default);
}