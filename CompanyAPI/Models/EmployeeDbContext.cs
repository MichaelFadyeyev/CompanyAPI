using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
