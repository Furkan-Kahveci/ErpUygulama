namespace ErpUygulama.Repositories
{
    public interface IRepositories<T> where T : class
    {
        Task<List<T>> GetAllAsync1();
        Task<T>GetByIdAsync(int id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<List<T>> GetAllAsync();
    }
}
