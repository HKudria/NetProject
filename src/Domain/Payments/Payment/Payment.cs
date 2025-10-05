namespace Domain.Payments.Payment;

public class Payment
{
    public Guid Id { get; set; }
    public Guid MerchantId { get; set; }
    public Merchant.Merchant Merchant { get; set; } = null!;

    public string Currency { get; set; } = "EUR";
    public decimal Amount { get; set; }
    public PaymentStatusEnum Status { get; set; } = PaymentStatusEnum.Created;

    public string? IdempotencyKey { get; set; }
    public DateTime CreatedAt { get; set; }
}