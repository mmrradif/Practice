using Microsoft.EntityFrameworkCore;
using Practice.Context;
using Practice.Interfaces;

namespace Practice.Repositories
{
    public class GetRepo<T> : IGet<T> where T : class
    {
        public EmployeeDbContext _employeeDbContext;
        internal DbSet<T> dbSet;

        public GetRepo( EmployeeDbContext employeeDbContext)
        {
            this._employeeDbContext = employeeDbContext;
            this.dbSet = employeeDbContext.Set<T>();
        }



        public virtual async Task<List<T>> GetAll()
        {
            try
            {
                var result = await this.dbSet.ToListAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<T> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetAll(string name)
        {
            throw new NotImplementedException();
        }
    }
}
