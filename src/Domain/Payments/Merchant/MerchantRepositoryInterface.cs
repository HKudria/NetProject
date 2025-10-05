namespace Domain.Payments.Merchant;

public interface IMerchantRepository
{
    Task<Merchant?> GetAsync(Guid merchantId, CancellationToken ct = default);
    Task<IReadOnlyList<Merchant>?> GetAllAsync(CancellationToken ct = default);
    Task SaveAsync(Merchant merchant, CancellationToken ct = default);
}