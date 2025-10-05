namespace Application;

public sealed record MerchantRequest
{
    public required string Name { get; init; }
    public required string ApiKey { get; init; }
}