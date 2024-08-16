
using ErpUygulama.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ErpUygulama.Repositories
{
    public class Repsoitory<T> : IRepositories<T> where T : class
    {
        private readonly ErpUygulamaDbContext _context;

        public Repsoitory(ErpUygulamaDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync1()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
           _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IRepositories<T>> get_AllAsync()
        {
            return (IRepositories<T>)await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
           _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
           
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
