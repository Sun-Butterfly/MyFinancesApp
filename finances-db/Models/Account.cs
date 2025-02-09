namespace finances_db.Models;

public class Account
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public int CashBalance { get; set; }
    public string Currency { get; set; } = null!;
}