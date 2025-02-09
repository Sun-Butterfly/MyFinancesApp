namespace finances_db.Models;

public class User
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Account> Accounts { get; set; } = new();
}