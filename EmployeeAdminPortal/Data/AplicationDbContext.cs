using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base (options) 
        {
            // ctor - create constructor
            //prop - create properties
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
