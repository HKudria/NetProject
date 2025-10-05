using Domain.Payments.Merchant;
using MediatR;

namespace Application;

public class CreateMerchantHandler(IMerchantRepository repository): IRequestHandler<CreateMerchant, Guid>
{
    public async Task<Guid> Handle(CreateMerchant cmd, CancellationToken ct)
    {
        var merchant = Merchant.Create(Guid.NewGuid(), cmd.Name, cmd.ApiKey, DateTime.UtcNow);
        await repository.SaveAsync(merchant, ct);
        return merchant.Id;
    }
}