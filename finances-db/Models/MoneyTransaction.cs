namespace finances_db.Models;

public class MoneyTransaction
{
    public enum TransactionType
    {
        Deposit,
        Withdraw
    }
    
    
    public long Id { get; set; }
    public TransactionType Type { get; set; }
    public Account Account { get; set; } = null!;
    public long AccountId { get; set; }
    public int Amount { get; set; }
    public TimeSpan TimeOfTransaction { get; set; }
}

