using Microsoft.EntityFrameworkCore;
using QarzOldiBerdi.Models;

namespace DVDrentalEntityFramework.Data
{
    public class DataContext : DbContext
    {
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=QarzDb;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(connectionString);
        }
        public DbSet<qarzBeruvchi> qarzBeruvchi { get; set; }
        public DbSet<qarzdor> qarzdor { get; set; }
        public DbSet<qarz> qarz { get; set; }
    }
}
