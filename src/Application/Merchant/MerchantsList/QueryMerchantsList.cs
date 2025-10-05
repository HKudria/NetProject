using Domain.Payments.Merchant;
using MediatR;

namespace Application;

public record QueryMerchantsList(): IRequest<IReadOnlyList<Merchant>?>;