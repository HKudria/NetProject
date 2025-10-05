namespace Domain.Payments.Merchant;

public class Merchant
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string ApiKey { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
}