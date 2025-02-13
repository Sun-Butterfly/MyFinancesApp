namespace finances_db.Models;

public class Account
{
    public enum Currencies
    {
        Ruble,
        Euro,
        Dollar
    }
    
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public int CashBalance { get; set; }
    public Currencies Currency { get; set; }
    
    public User User { get; set; } = null!;
    public long UserId { get; set; }
    public List<MoneyTransaction> MoneyTransactions { get; set; } = new();
}