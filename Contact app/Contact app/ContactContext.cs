using Microsoft.EntityFrameworkCore;


public class ContactContext : DbContext
{
    public DbSet<ContactModel> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;database=contactapp;user=root;password=;",
            new MySqlServerVersion(new Version(10, 5, 0))
        );
    }
}