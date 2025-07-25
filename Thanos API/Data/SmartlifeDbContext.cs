using Microsoft.EntityFrameworkCore;
using Thanos_API.Models;

namespace Thanos_API.Data
{
    public class SmartlifeDbContext : DbContext
    {
        public SmartlifeDbContext(DbContextOptions<SmartlifeDbContext> options) : base(options) { }

        public DbSet<Contribution> Contributions { get; set; }
    }
}
