namespace Practice.Interfaces
{
    public interface IGet<T> where T : class { 
        Task<List<T>> GetAll();
        Task<T> GetAll(int id);
        Task<T> GetAll(string name);
    }
}
