using Microsoft.EntityFrameworkCore;
using Practice.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Practice.Context
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> dbContext):base (dbContext)
        {
        }

        public DbSet<Employee> tblCompany => Set<Employee>();
    }
}
