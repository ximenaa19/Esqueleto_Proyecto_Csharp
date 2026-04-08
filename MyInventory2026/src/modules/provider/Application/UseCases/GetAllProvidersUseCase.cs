using MyInventory2026.src.modules.provider.domain.repositories;
using MyInventory2026.src.modules.provider.Domain.aggregate;

namespace MyInventory2026.src.modules.provider.Application.UseCases;

public sealed class GetAllProvidersUseCase
{
    private readonly IProviderRepository _providerRepository;

    public GetAllProvidersUseCase(IProviderRepository providerRepository)
    {
        _providerRepository = providerRepository;
    }

    public Task<IReadOnlyCollection<Provider>> ExecuteAsync(CancellationToken cancellationToken = default)
    {
        return _providerRepository.FindAllAsync(cancellationToken);
    }
}