using Domain.Payments.Merchant;
using Infrastructure.config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class MerchantRepository(PaymentsDbContext db) : IMerchantRepository
{
    public async Task<Merchant?> GetAsync(Guid merchantId, CancellationToken ct = default)
    {
        return await db.Merchants
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == merchantId, ct);
    }
    
    public async Task<IReadOnlyList<Merchant>?> GetAllAsync(CancellationToken ct = default)
    {
        return await db.Merchants
            .AsNoTracking()
            .ToListAsync(ct);
    }

    public async Task SaveAsync(Merchant merchant, CancellationToken ct = default)
    {
        var exists = await db.Merchants.AnyAsync(m => m.Id == merchant.Id, ct);
        if (exists)
            db.Merchants.Update(merchant);
        else
            await db.Merchants.AddAsync(merchant, ct);

        await db.SaveChangesAsync(ct);
    }
}