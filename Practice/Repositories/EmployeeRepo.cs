using Microsoft.EntityFrameworkCore;
using Practice.Context;
using Practice.Models;

namespace Practice.Repositories
{
    public class EmployeeRepo : GetRepo<Employee>
    {
        public EmployeeRepo(EmployeeDbContext employeeDbContext) : base(employeeDbContext)
        {
        }

        public override async Task<List<Employee>> GetAll()
        {
            try
            {
                var result = await base.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while getting employees: {ex.Message}");
                throw;
            }
        }

        public override async Task<Employee> GetAll(int id)
        {
            try
            {
                var result =  await dbSet.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while getting employee with id {id}: {ex.Message}");
                throw;
            }
        }

        public override async Task<Employee> GetAll(string name)
        {
            try
            {
                var result =  await dbSet.FirstOrDefaultAsync(e => e.FirstName == name);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while getting employee with name {name}: {ex.Message}");
                throw;
            }
        }
    }
}
