using Microsoft.EntityFrameworkCore;

namespace AspCoreCrudProject.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> tblEmployees { get; set; }

    }
}
