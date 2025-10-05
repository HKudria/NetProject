using Domain.Payments.Merchant;
using MediatR;

namespace Application;

public class QueryMerchantsListHandler(IMerchantRepository repository): IRequestHandler<QueryMerchantsList, IReadOnlyList<Merchant>?>
{
    public async Task<IReadOnlyList<Merchant>?> Handle(QueryMerchantsList cmd, CancellationToken ct)
    {
        return await repository.GetAllAsync(ct);;
    }
}