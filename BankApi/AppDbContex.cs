using Microsoft.EntityFrameworkCore;

namespace BankApi
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Bank> Banks { get; set; }
    }
}
