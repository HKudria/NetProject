using MediatR;

namespace Application;

public record CreateMerchant(string Name, string ApiKey): IRequest<Guid>;