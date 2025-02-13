using finances_db.Models;
using Microsoft.EntityFrameworkCore;

namespace finances_db;
// dotnet ef migrations add Init --context DatabaseContext --startup-project finances-api/finances-api.csproj --project finances-db/finances-db.csproj
//dotnet ef database update --context DatabaseContext --startup-project finances-api/finances-api.csproj --project finances-db/finances-db.csproj
public class DatabaseContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Account> Accounts { get; set; } = null!;

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>()
            .HasOne(x => x.User)
            .WithMany(y => y.Accounts)
            .HasForeignKey(z => z.UserId);

        modelBuilder.Entity<MoneyTransaction>()
            .HasOne(x => x.Account)
            .WithMany(y => y.MoneyTransactions)
            .HasForeignKey(z => z.AccountId);
    }
}