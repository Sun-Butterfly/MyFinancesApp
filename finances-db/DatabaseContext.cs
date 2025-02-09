using Microsoft.EntityFrameworkCore;

namespace finances_db;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}