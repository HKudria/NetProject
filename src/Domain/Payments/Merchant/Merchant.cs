namespace Domain.Payments.Merchant;

public sealed class Merchant
{
    public Guid Id { get; private set; }
    private string _name = null!;
    private string _apiKey = null!;
    private DateTime _createdAt;
    
    private Merchant() { }
    
    public static Merchant Create(Guid id, string name, string apiKey, DateTime date)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name required");
        if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentException("ApiKey required");

        return new Merchant
        {
            Id = id,
            _name = name,
            _apiKey = apiKey,
            _createdAt = date
        };
    }
    
    public void Rename(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName)) throw new ArgumentException("Name required");
        _name = newName;
    }

    public void RotateApiKey(string newKey)
    {
        if (string.IsNullOrWhiteSpace(newKey)) throw new ArgumentException("ApiKey required");
        _apiKey = newKey;
    }
}