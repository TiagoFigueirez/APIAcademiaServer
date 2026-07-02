using APIAcademia.Context;
using APIAcademia.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace APIAcademia.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>()
                        .AsNoTracking()
                        .ToListAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> precidacte)
        {
            return await _context.Set<T>()
                        .AsNoTracking()
                        .FirstOrDefaultAsync(precidacte);
        }

        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
                
        }

        public T Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
