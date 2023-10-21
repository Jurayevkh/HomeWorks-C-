using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Services.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        public DbSet<EmployeeStaff> EmployeeStaff { get; set; }
    }
}
